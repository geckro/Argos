using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace Argos.Common;

public static class RecipeHelper
{
    public static Dictionary<int, ICollection<Recipe>> RecipesToDisableByRecipe { get; set; } = new();
    public static ICollection<int> RecipesToDisable { get; set; } = [];

    public static void AddRecipe(int itemToCreate,
            (int id, int count)[] ingredients,
            ushort[] tiles = null,
            Condition[] conditions = null,
            (string id, int count)[] recipeGroups = null,
            (int id, int count)[] moddedIngredients = null,
            int amount = 1)
    {
        Recipe recipe = Recipe.Create(itemToCreate, amount);

        foreach ((int id, int count) ingredient in ingredients)
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

        AddToDisabledRecipes(itemToCreate, recipe);
    }

    public static void AddToDisabledRecipes(int itemToCreate,
            Recipe recipe)
    {
        if (!RecipesToDisableByRecipe.TryGetValue(itemToCreate, out ICollection<Recipe> value))
        {
            RecipesToDisableByRecipe[itemToCreate] = new List<Recipe> { recipe };
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

            foreach ((int id, ICollection<Recipe> addedRecipes) in RecipeHelper.RecipesToDisableByRecipe)
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

            foreach (int id in RecipeHelper.RecipesToDisable)
            {
                if (!recipe.HasResult(id))
                {
                    continue;
                }

                recipe.DisableRecipe();
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
