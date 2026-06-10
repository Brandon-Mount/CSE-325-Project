using RecipeMealPlanner.Models;

namespace RecipeMealPlanner.Services;

public class RecipeService
{
    private readonly List<Recipe> recipes = new()
    {
        new Recipe
        {
            Id = 1,
            Name = "Spaghetti",
            Category = "Dinner",
            Ingredients = "Noodles, sauce, ground beef",
            Instructions = "Cook noodles, brown beef, add sauce, and combine.",
            PrepTimeMinutes = 10,
            CookTimeMinutes = 20,
            Servings = 4
        },
        new Recipe
        {
            Id = 2,
            Name = "Chicken Tacos",
            Category = "Dinner",
            Ingredients = "Chicken, tortillas, cheese, lettuce",
            Instructions = "Cook chicken, prepare toppings, and assemble tacos.",
            PrepTimeMinutes = 15,
            CookTimeMinutes = 20,
            Servings = 4
        }
    };

    public List<Recipe> GetRecipes()
    {
        return recipes;
    }

    public Recipe? GetRecipeById(int id)
    {
        return recipes.FirstOrDefault(r => r.Id == id);
    }

    public void AddRecipe(Recipe recipe)
    {
        recipe.Id = recipes.Count == 0 ? 1 : recipes.Max(r => r.Id) + 1;
        recipes.Add(recipe);
    }

    public void UpdateRecipe(Recipe updatedRecipe)
    {
        var recipe = GetRecipeById(updatedRecipe.Id);

        if (recipe is null)
        {
            return;
        }

        recipe.Name = updatedRecipe.Name;
        recipe.Category = updatedRecipe.Category;
        recipe.Ingredients = updatedRecipe.Ingredients;
        recipe.Instructions = updatedRecipe.Instructions;
        recipe.PrepTimeMinutes = updatedRecipe.PrepTimeMinutes;
        recipe.CookTimeMinutes = updatedRecipe.CookTimeMinutes;
        recipe.Servings = updatedRecipe.Servings;
    }

    public void DeleteRecipe(int id)
    {
        var recipe = GetRecipeById(id);

        if (recipe is not null)
        {
            recipes.Remove(recipe);
        }
    }
}