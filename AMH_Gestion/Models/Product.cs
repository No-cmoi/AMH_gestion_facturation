using System.ComponentModel.DataAnnotations;

namespace AMH_Gestion.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal TaxRate { get; set; }
    public bool IsActive { get; set; }

    public ICollection<QuoteDetail>? QuoteDetails { get; set; }
    public ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
}