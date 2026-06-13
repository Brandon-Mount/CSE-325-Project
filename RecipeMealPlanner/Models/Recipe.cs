using System.ComponentModel.DataAnnotations;

namespace RecipeMealPlanner.Models;

public class Recipe
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Recipe name is required.")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Category is required.")]
    public string Category { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ingredients are required.")]
    public string Ingredients { get; set; } = string.Empty;

    [Required(ErrorMessage = "Instructions are required.")]
    public string Instructions { get; set; } = string.Empty;

    [Range(0, 300, ErrorMessage = "Prep time must be between 0 and 300 minutes.")]
    public int PrepTimeMinutes { get; set; }

    [Range(0, 300, ErrorMessage = "Cook time must be between 0 and 300 minutes.")]
    public int CookTimeMinutes { get; set; }

    [Range(1, 20, ErrorMessage = "Servings must be between 1 and 20.")]
    public int Servings { get; set; }
}