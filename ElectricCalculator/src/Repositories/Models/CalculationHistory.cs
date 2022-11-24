namespace Repositories.Models;

public class CalculationHistory
{
    public int Id { get; set; }
    public int TotalUsage { get; set; }
    public float CalculatedPrice { get; set; }
    public DateTime IssuedTime { get; set; }
}