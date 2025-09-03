using System.ComponentModel.DataAnnotations;

namespace lab_10_albertspencer.Models;

public class Review // Make this class public
{
    public int ReviewID { get; set; } // Primary Key
    
    [Range(1, 5, ErrorMessage = "Score must be between 1 and 5.")]
    public int Score { get; set; }
    
    public string? ReviewText { get; set; }

    // Foreign key to Product
    public int ProductID { get; set; }
    public Product? Product { get; set; } // Navigation property
}
