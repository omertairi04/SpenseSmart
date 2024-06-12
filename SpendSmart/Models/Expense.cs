using System.ComponentModel.DataAnnotations;

namespace SpenseSmart.Models;

public class Expense
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    [Required] // must add a value for description
    public string? Description { get; set; }
}