using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace Argos.Common;

public record Ingredient
{
    public int Id { get; init; }
    public int Count { get; init; } = 1;
}

public record RecipeGroupIngredient
{
    public string Id { get; init; }
    public int Count { get; init; } = 1;
}

public static class RecipeHelper
{
    public static Dictionary<int, ICollection<Recipe>> RecipesToDisableByRecipe { get; } = new();
    public static ICollection<int> RecipesToDisable { get; } = [];

    public static Ingredient Ingredient(int itemId,
            int count = 1) =>
            new() { Id = itemId, Count = count };

    public static RecipeGroupIngredient RecipeGroup(string itemId,
            int count = 1) =>
            new() { Id = itemId, Count = count };

    public static void AddRecipe(int itemToCreate,
            Ingredient[] ingredients = null,
            ushort[] tiles = null,
            Condition[] conditions = null,
            RecipeGroupIngredient[] recipeGroups = null,
            int amount = 1)
    {
        Recipe recipe = Recipe.Create(itemToCreate, amount);

        if (ingredients != null)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                recipe.AddIngredient(ingredient.Id, ingredient.Count);
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

        if (recipeGroups != null)
        {
            foreach (RecipeGroupIngredient recipeGroup in recipeGroups)
            {
                recipe.AddRecipeGroup(recipeGroup.Id, recipeGroup.Count);
            }
        }

        recipe.Register();

        AddToDisabledRecipes(itemToCreate, recipe);
    }

    private static void AddToDisabledRecipes(int itemToCreate,
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
            Recipe b) =>
            a.createItem.type == b.createItem.type && a.requiredItem.SequenceEqual(b.requiredItem) &&
            a.requiredTile.SequenceEqual(b.requiredTile) && a.Conditions.SequenceEqual(b.Conditions);
}
