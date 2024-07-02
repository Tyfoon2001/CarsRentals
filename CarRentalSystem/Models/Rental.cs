using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Rental
    {
        public Cars cars;
        public Customer customer;
        public int Days;

        public Rental(Cars cars, Customer customer, int days)
        {
            this.cars = cars;
            this.customer = customer;
            this.Days = Days;
        }

        public Cars C
        {
            get { return cars; }
            set { cars = value; }
        }

        public Customer Cus
        {
            get { return customer; }
            set { customer = value; }
        }
    }
}
