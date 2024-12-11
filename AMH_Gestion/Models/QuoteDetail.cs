using System.ComponentModel.DataAnnotations;

namespace AMH_Gestion.Models;

public class QuoteDetail
{
    [Key]
    public int Id { get; set; }
    public int QuoteId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}