using System.ComponentModel.DataAnnotations;

namespace MyBookApp.Models;

public class Book {
    // Properties
    public int Id { get; set; }

    [Required(ErrorMessage = "Bokens titel är obligatoriskt")]
    [Display(Name = "Titel")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Bokens genre är obligatoriskt")]
    public string? Genre { get; set; }

    [Display(Name = "Beskrivning")]
    public string? Description { get; set; }

    public int AuthorId { get; set; }

    [Display(Name = "Författare")]
    public Author? Author { get; set; }
}