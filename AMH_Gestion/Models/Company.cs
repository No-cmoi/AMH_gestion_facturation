using System.ComponentModel.DataAnnotations;

namespace AMH_Gestion.Models;

public class Company
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Company name is required")]
    public string CompanyName { get; set; }
    [Required(ErrorMessage = "Company address number is required")]
    public string AddressNumber { get; set; }
    [Required(ErrorMessage = "Company address street is required")]
    public string AddressStreet { get; set; }
    [Required(ErrorMessage = "Company postal code is required")]
    public string PostalCode { get; set; }
    [Required(ErrorMessage = "Company city is required")]
    public string City { get; set; }
    [Required(ErrorMessage = "Company country is required")]
    public string Country { get; set; }
    [Required(ErrorMessage = "Company phone is required")]
    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; }
    [Required(ErrorMessage = "Company email is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    public string SiretNumber { get; set; }
    public string LegalStatus { get; set; }
    public string TaxRegime { get; set; }
    public bool? IsPayingVAT { get; set; }
    public string VATMessage { get; set; }

    public ICollection<Quote>? Quotes { get; set; }
    public ICollection<Invoice>? Invoices { get; set; }
    public ICollection<ActivityLog>? ActivityLogs { get; set; }
}