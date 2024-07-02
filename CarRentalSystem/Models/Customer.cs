using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        
        [Required]
       
        private int CustomerId;
        [Required]
        private string Name;

        public Customer() { }
        public Customer(int CustomerId, string Name)
        {
           
            this.CustomerId = CustomerId;
            this.Name = Name;
        }
        public int customerId
        {
            get { return this.CustomerId; }
            set { this.CustomerId = value; }
        }

        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

    }
}
