namespace Models;

public class Recipe
{
    public string Name { get; init; }
    public IList<RecipeMaterial> Materials { get; init; }
}