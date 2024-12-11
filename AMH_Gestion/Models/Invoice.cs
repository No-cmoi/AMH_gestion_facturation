namespace AMH_Gestion.Models;

public class Invoice
{
    public int Id { get; set; }
    public string Number { get; set; }
    public DateTime DateIssued { get; set; }
    public decimal TotalAmount { get; set; }
    public bool IsPaid { get; set; }
    public string PaymentMethod { get; set; }
    public string Comment { get; set; }

    public int ClientId { get; set; }
    public int CompanyId { get; set; }
    public int QuoteId { get; set; }

    public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    
}