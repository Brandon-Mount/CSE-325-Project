using System.ComponentModel.DataAnnotations;

namespace RecipeMealPlanner.Models;

public class GroceryItem
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Quantity { get; set; } = string.Empty;

    public bool IsPurchased { get; set; }
}