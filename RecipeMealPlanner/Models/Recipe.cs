using System.ComponentModel.DataAnnotations;

namespace RecipeMealPlanner.Models;

public class Recipe
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Ingredients { get; set; } = string.Empty;

    public string Instructions { get; set; } = string.Empty;

    public int PrepTimeMinutes { get; set; }

    public int CookTimeMinutes { get; set; }

    public int Servings { get; set; }
}