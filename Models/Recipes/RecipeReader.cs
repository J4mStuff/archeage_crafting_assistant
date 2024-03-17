using Models.Model;
using Newtonsoft.Json;

namespace Models.Recipes;

public class RecipeReader
{
    private readonly Dictionary<string, Item> _recipes = new();
    public IEnumerable<Item> GetAllRecipes()
    {
        var filepath = Path.Combine(".", "Data");
        var d = new DirectoryInfo(filepath);

        foreach (var fileInfo in d.GetFiles("*.json"))
        {
            var item = GetItemFromFile(fileInfo);
            if (item != null)
            {
                _recipes[item.Name] = item;
            }
        }

        foreach (var item in _recipes.Values)
        {
            item.Recipe = ExpandRecipe(item);
        }
        
        return _recipes.Values;
    }

    private Item? GetItemFromFile(FileInfo fileInfo)
    {
        var r = fileInfo.OpenText();
        var json = r.ReadToEnd();
        var items = JsonConvert.DeserializeObject<Item>(json);

        return items;
    }

    private IEnumerable<RecipeMaterial> ExpandRecipe(Item item)
    {
        foreach (var mat in item.Recipe)
        {
            if(_recipes.TryGetValue(mat.Name, out var recipe))
            {
                mat.Recipe = ExpandRecipe(recipe);
            }
        }

        return item.Recipe;
    }
}