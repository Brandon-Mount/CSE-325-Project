using System.ComponentModel.DataAnnotations;

namespace RecipeMealPlanner.Models;

public class GroceryItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Item name is required.")]
    public string Name { get; set; } = string.Empty;

    public bool IsPurchased { get; set; }
}