using System.ComponentModel.DataAnnotations;

namespace AMH_Gestion.Models;

public class Client
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Client name is required")]
    public string ClientName { get; set; }

    [Required(ErrorMessage = "Address number is required")]
    public string AddressNumber { get; set; }

    [Required(ErrorMessage = "Address street is required")]
    public string AddressStreet { get; set; }
    
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; }
    
    [Required(ErrorMessage = "Postal Code is required")]
    public string PostalCode { get; set; }
    
    [Required(ErrorMessage = "Country is required")]
    public string Country { get; set; }
    
    [Required(ErrorMessage = "Phone number is required")]
    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime DateCreated { get; set; }

    public ICollection<Quote> Quotes { get; set; }
    public ICollection<Invoice> Invoices { get; set; }
    
}