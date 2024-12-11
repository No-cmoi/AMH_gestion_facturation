using System.ComponentModel.DataAnnotations;

namespace AMH_Gestion.Models;

public class InvoiceDetail
{
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}