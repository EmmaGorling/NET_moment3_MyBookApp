using System.ComponentModel.DataAnnotations;

namespace MyBookApp.Models;

public class Loan {
    // Properties
    public int Id { get; set; }
    [Required]
    public int BookId { get; set; }
    public Book? Book { get; set; }

    [Required]
    [Display(Name = "Låntagarens namn")]
    public string? BorrowerName { get; set; }

    [Required]
    [Display(Name = "Lånedatum")]
    public DateTime LoanDate { get; set; } = DateTime.Now;
}