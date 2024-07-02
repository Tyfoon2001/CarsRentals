using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace CarRentalSystem.Pages.CarsPages
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Cars cars { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int CarId)
        {
            if (CarId != 0)
            {
                cars = _db.cars.Find(CarId);
                if (cars != null)
                {
                    cars.CarId = CarId;
                }
            }
        }
        public IActionResult OnPost(int CarId)
        {
            if (CarId != 0)
            {
                Cars obj = _db.cars.Find(CarId);


                _db.cars.Remove(obj);
                _db.SaveChanges();



            }
            return RedirectToPage("Index");
        }
    }
}
