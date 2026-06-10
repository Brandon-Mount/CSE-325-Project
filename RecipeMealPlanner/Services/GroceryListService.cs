using RecipeMealPlanner.Models;

namespace RecipeMealPlanner.Services;

public class GroceryListService
{
    private readonly List<GroceryItem> groceryItems = new();

    public List<GroceryItem> GetItems()
    {
        return groceryItems;
    }

    public void AddItem(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return;
        }

        groceryItems.Add(new GroceryItem
        {
            Id = groceryItems.Count + 1,
            Name = name
        });
    }

    public void TogglePurchased(int id)
    {
        var item = groceryItems.FirstOrDefault(i => i.Id == id);

        if (item is not null)
        {
            item.IsPurchased = !item.IsPurchased;
        }
    }

    public void DeleteItem(int id)
    {
        var item = groceryItems.FirstOrDefault(i => i.Id == id);

        if (item is not null)
        {
            groceryItems.Remove(item);
        }
    }
}