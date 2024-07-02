using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace CarRentalSystem.Pages.CarsPages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Cars> cars { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            cars = _db.cars.ToList();
        }
    }
}
