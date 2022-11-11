namespace Repositories.Models;

public class Pricing
{
    public int Id { get; set; }
    public int From { get; set; }
    public int To { get; set; }
    public float StandardPrice { get; set; }
}