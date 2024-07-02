using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cars
    {

        [Key]
        [Required]
        public int CarId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }

        public Cars() { }
        public Cars(int carId, string brand, string model, double price)
        {
            this.CarId = CarId;
            this.Brand = Brand;
            this.Model = Model;
            this.Price = Price;
            this.IsAvailable = true;
        }
        public double GetPrice(int RentalDays)
        {
            return Price * RentalDays;
        }

        public bool isAvailable()
        {
            return IsAvailable;
        }

        public void Rent()
        {
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }
    }
}
