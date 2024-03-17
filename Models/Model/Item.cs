namespace Models.Model;

public class Item
{
    public string Name { get; set; }
    public string Alias { get; set; }
    public double MarketPrice { get; set; }
    public IEnumerable<RecipeMaterial> Recipe { get; set; }
}