using System.ComponentModel.DataAnnotations;

namespace MyBookApp.Models; 
public class Author {
    // Properties
    public int Id { get; set; }
    [Required(ErrorMessage = "Författarens namn är obligatoriskt")]
    [Display(Name = "Namn")]
    public string?  Name { get; set; }
    
    [Display(Name = "Böcker")]
    public List<Book>? Books { get; set; }
}