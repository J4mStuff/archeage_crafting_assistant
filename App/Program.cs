using Models;
using Newtonsoft.Json;

namespace App;

public static class HelloWorld
{
    public static void Main()
    {
        var x = LoadJson("Data/recipes.json");
        
        Console.WriteLine("siusiak1");
        Console.WriteLine("siusiak1");
        Console.WriteLine("siusiak1");
        Console.WriteLine("siusiak1");
        Console.WriteLine("siusiak1");
    }

    private static IEnumerable<Recipe>? LoadJson(string filepath)
    {
        using var r = new StreamReader(filepath);
        var json = r.ReadToEnd();
        var items = JsonConvert.DeserializeObject<List<Recipe>>(json);

        return items;
    }
}