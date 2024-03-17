using Models.Recipes;

namespace App;

public class Runner
{
    private readonly RecipeReader _recipeReader = new();

    public void Run()
    {
        var y = _recipeReader.GetAllRecipes();
    }
}