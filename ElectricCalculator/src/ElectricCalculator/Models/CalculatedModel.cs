namespace ElectricCalculator.Models;

public class CalculatedModel
{
    public IList<CalculatedItem> Items { get; set; }
    public float Usage { get; set; }
    public float Total { get; set; }
}