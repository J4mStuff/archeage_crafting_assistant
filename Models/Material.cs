namespace Models;

public class Material
{
    public string Name { get; }
    public double MarketPrice { get; set; }
    
    private Recipe _recipe { get; set; }
}