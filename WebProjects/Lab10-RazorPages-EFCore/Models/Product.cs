using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab_10_albertspencer.Models
{
    public class Product
    {
        public int ProductID { get; set; } // Primary Key

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Product Image")]
        public string ImageURL { get; set; } = string.Empty;

        // Navigation property for related reviews
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
