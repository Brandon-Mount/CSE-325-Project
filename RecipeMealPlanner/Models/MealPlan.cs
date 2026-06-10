namespace RecipeMealPlanner.Models;

public class MealPlan
{
    public int Id { get; set; }

    public DateTime MealDate { get; set; }

    public string MealType { get; set; } = string.Empty;

    public int RecipeId { get; set; }

    public string RecipeName { get; set; } = string.Empty;
}