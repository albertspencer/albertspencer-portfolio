using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using lab_10_albertspencer.Models;

namespace lab_10_albertspencer.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductContext _context;

        public IndexModel(ProductContext context)
        {
            _context = context;
        }

        // Option 1: Make Product nullable
        public IList<Product>? Product { get; set; }

        // Option 2: Initialize Product as an empty list
        // public IList<Product> Product { get; set; } = new List<Product>();

        public void OnGet()
        {
            Product = _context.Products
                .Include(p => p.Reviews) // Include related reviews
                .ToList();
        }
    }
}
