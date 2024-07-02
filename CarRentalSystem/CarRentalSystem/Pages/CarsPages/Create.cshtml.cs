using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace CarRentalSystem.Pages.CarsPages
{ 
    public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public Cars cars { get; set; }
    public CreateModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        _db.cars.Add(cars);
        _db.SaveChanges();
        return RedirectToPage("Index");
    }
}
}
