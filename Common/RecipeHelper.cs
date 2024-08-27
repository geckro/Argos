using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace Argos.Common;

public static class RecipeHelper
{
    public static Dictionary<short, ICollection<Recipe>> AddedRecipes { get; set; } = new();

    public static void AddRecipe(short itemToCreate,
            (short id, int count)[] ingredients,
            ushort[] tiles = null,
            Condition[] conditions = null,
            (string id, int count)[] recipeGroups = null,
            (int id, int count)[] moddedIngredients = null,
            int amount = 1)
    {
        Recipe recipe = Recipe.Create(itemToCreate, amount);

        foreach ((short id, int count) ingredient in ingredients)
        {
            recipe.AddIngredient(ingredient.id, ingredient.count);
        }

        if (moddedIngredients != null)
        {
            foreach ((int id, int count) ingredient in moddedIngredients)
            {
                recipe.AddIngredient(ingredient.id, ingredient.count);
            }
        }

        if (recipeGroups != null)
        {
            foreach ((string id, int count) recipeGroup in recipeGroups)
            {
                recipe.AddRecipeGroup(recipeGroup.id, recipeGroup.count);
            }
        }

        if (tiles != null)
        {
            foreach (ushort tile in tiles)
            {
                recipe.AddTile(tile);
            }
        }

        if (conditions != null)
        {
            foreach (Condition condition in conditions)
            {
                recipe.AddCondition(condition);
            }
        }

        recipe.Register();

        if (!AddedRecipes.TryGetValue(itemToCreate, out ICollection<Recipe> value))
        {
            AddedRecipes[itemToCreate] = new List<Recipe> { recipe };
        }
        else
        {
            value.Add(recipe);
        }
    }
}

public class PostAddRecipe : ModSystem
{
    public override void PostAddRecipes()
    {
        for (int i = 0; i < Recipe.numRecipes; i++)
        {
            Recipe recipe = Main.recipe[i];

            foreach ((short id, ICollection<Recipe> addedRecipes) in RecipeHelper.AddedRecipes)
            {
                // if there is no new recipe that Argos adds, just skip it
                if (!recipe.HasResult(id))
                {
                    continue;
                }

                // Mod.Logger.Info($"ITEM: {recipe.createItem} | " +
                //                 $"REQUIRED_ITEMS: [{string.Join(",", recipe.requiredItem)}] | " +
                //                 $"CONDITIONS: [{string.Join(",", recipe.Conditions)}]");

                // Check to see if the recipe is added by Argos or not (it should have equal items/tiles/conditions).
                // If not, then disable the recipe.
                if (!addedRecipes.Any(addedRecipe => RecipesAreEqual(recipe, addedRecipe)))
                {
                    recipe.DisableRecipe();
                }
            }
        }
    }

    private static bool RecipesAreEqual(Recipe a,
            Recipe b)
    {
        return a.createItem.type == b.createItem.type && a.requiredItem.SequenceEqual(b.requiredItem) &&
               a.requiredTile.SequenceEqual(b.requiredTile) && a.Conditions.SequenceEqual(b.Conditions);
    }
}
