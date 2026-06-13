using System.ComponentModel.DataAnnotations;

namespace RecipeMealPlanner.Models;

public class MealPlan
{
    public int Id { get; set; }

    [Required]
    public DateTime MealDate { get; set; }

    [Required(ErrorMessage = "Meal type is required.")]
    public string MealType { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "Please select a recipe.")]
    public int RecipeId { get; set; }

    public string RecipeName { get; set; } = string.Empty;
}