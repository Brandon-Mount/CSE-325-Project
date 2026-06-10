namespace RecipeMealPlanner.Models;

public class GroceryItem
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool IsPurchased { get; set; }
}