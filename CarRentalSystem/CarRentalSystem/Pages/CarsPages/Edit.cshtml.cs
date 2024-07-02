using Data;
using Data.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace CarRentalSystem.Pages.CarsPages
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Cars cars { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int CarId)
        {
        
                cars = _db.cars.Find(CarId);
                
            

        }

        public IActionResult OnPost()
        {
            
                _db.cars.Update(cars);
                _db.SaveChanges();
            
            //if (CarId != 0)
            //{
            //  var obj = _db.cars.Find(CarId);
            //_db.cars.Update(obj);
            //_db.SaveChanges();
            //}

            return RedirectToPage("Index");

            
        }

        

    }
}

