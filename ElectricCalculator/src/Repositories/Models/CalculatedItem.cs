namespace Repositories.Models;

public class CalculatedItem
{
    public int Id { get; set; }
    public int From { get; set; }
    public float StandardPrice { get; set; }
    public float Price { get; set; }
    public int Usage { get; set; }
}