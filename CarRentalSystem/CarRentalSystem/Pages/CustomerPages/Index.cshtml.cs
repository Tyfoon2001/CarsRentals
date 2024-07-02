using CarRentalSystem.Pages.CustomerPages;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace CarRentalSystem.Pages.CustomerPages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Customer> customers { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            db = _db;
        }
        public void OnGet()
        {
            customers = _db.customers.ToList();
        }
    }
}
