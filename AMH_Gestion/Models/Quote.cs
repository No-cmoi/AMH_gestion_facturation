using System.ComponentModel.DataAnnotations;

namespace AMH_Gestion.Models;

public class Quote
{
    [Key]
    public int Id { get; set; }

    public string QuoteNumber { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool IsAccepted { get; set; }
    public decimal TotalAmount { get; set; }
    public string Comment { get; set; }

    public int ClientId { get; set; }
    public int CompanyId { get; set; }

    public ICollection<Invoice> Invoices { get; set; }
    public ICollection<QuoteDetail> QuoteDetails { get; set; }
}