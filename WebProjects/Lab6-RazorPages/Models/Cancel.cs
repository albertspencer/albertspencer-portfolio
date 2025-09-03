using System.ComponentModel.DataAnnotations;

namespace lab_6_albertspencer.Models
{
    public enum Product
    {
        MindSync,
        Seraphine,
        SoulSear,
        PhantomClaw
    }

    public class Cancel
    {
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Display(Name = "Phone Number")]
        [Phone]
        public string Phone { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Product")]
        public Product? Product { get; set; }

        [Display(Name = "Agree to non-disclosure terms.")]
        public bool AgreeToNDA { get; set; }

        [Display(Name = "Agree to waive all liability.")]
        public bool AgreeToLiability { get; set; }

        [Display(Name = "Agree to early termination fee.")]
        public bool AgreeToFee { get; set; }
    }
}
