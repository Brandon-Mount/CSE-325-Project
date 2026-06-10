using RecipeMealPlanner.Models;

namespace RecipeMealPlanner.Services;

public class MealPlanService
{
    private readonly List<MealPlan> mealPlans = new();

    public List<MealPlan> GetMealPlans()
    {
        return mealPlans;
    }

    public void AddMealPlan(MealPlan mealPlan)
    {
        mealPlan.Id = mealPlans.Count == 0 ? 1 : mealPlans.Max(m => m.Id) + 1;
        mealPlans.Add(mealPlan);
    }

    public void DeleteMealPlan(int id)
    {
        var mealPlan = mealPlans.FirstOrDefault(m => m.Id == id);

        if (mealPlan is not null)
        {
            mealPlans.Remove(mealPlan);
        }
    }
}