using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
    class MenuSystem
    {
        private List<Cars> cars;
        private List<Customer> customers;
        private List<Rental> rentals;

        public MenuSystem()
        {
            cars = new List<Cars>();
            customers = new List<Customer>();
            rentals = new List<Rental>();
        }
        public void AddCar(Cars car)
        {
            cars.Add(car);
        }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void RentCar(Cars car, Customer customer, int Days)
        {
            if (car.isAvailable())
            {
                car.Rent();
                rentals.Add(new Rental(car, customer, Days));
            }
            else
            {
                Console.WriteLine("Car not Available for rental");
            }
        }
        public void Return(Cars car)
        {
            car.Return();
            Rental RemoveRental = null;
            foreach (Rental rental in rentals)
            {
                if (rental.C == car)
                {
                    RemoveRental = rental;
                    break;
                }
            }
            if (RemoveRental != null)
            {
                rentals.Remove(RemoveRental);
            }
            else
            {
                Console.WriteLine("Car was not Rented");
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("========CarRentals========");
                Console.WriteLine("1.Rent a Car");
                Console.WriteLine("2.Return a Car");
                Console.WriteLine("3.Exit");

                Console.WriteLine("Enter Your Choice:");


                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("===Rent A Car===");
                    Console.WriteLine("Enter Your Name:");
                    // Enter the logic for the rental of the car
                    string CustomerName = Console.ReadLine();
                    Console.WriteLine("Avilable Cars:");
                    foreach (Cars car in cars)
                    {
                        if (car.isAvailable())
                        {
                            Console.WriteLine(car.CarId + "-" + car.Brand + " " + car.Model);


                        }

                    }
                    Console.WriteLine("Enter the car id you want to rent");
                    string carid = Console.ReadLine();
                    Console.WriteLine("Enter the number of days you want to rent");
                    int RentalDays = int.Parse(Console.ReadLine());
                    int newCustomerId = customers.Count + 1;
                    Customer newcustomer = new Customer(newCustomerId, CustomerName);
                    AddCustomer(newcustomer);

                    Cars selectedCar = null;
                    foreach (Cars car in cars)
                    {
                        if (car.CarId.Equals(carid) && car.isAvailable())
                        {
                            selectedCar = car;
                            break;
                        }
                    }

                    if (selectedCar != null)
                    {
                        double TotalPrice = selectedCar.GetPrice(RentalDays);
                        Console.WriteLine("n======Rental Information=======");
                        Console.WriteLine("Customer Id:" + newcustomer.customerId);
                        Console.WriteLine("Customer Name:" + newcustomer.name);
                        Console.WriteLine("Selected Car:" + selectedCar.Brand + " " + selectedCar.Model);
                        Console.WriteLine("Renatal Days:" + RentalDays);
                        Console.WriteLine("Total Price:" + TotalPrice);

                        Console.WriteLine("Confirm rental (Y/N): ");
                        string confirm = Console.ReadLine();

                        if (confirm.Equals("Y", StringComparison.OrdinalIgnoreCase))
                        {
                            RentCar(selectedCar, newcustomer, RentalDays);
                            Console.WriteLine("Car rented successfully");

                        }
                        else
                        {
                            Console.WriteLine("Rental Canceled");
                        }


                    }
                    else
                    {
                        Console.WriteLine("\nInvalid car selection or car not available for rent.");
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("======Return Car=======");
                    Console.WriteLine("Enter the car id");
                    string carid = Console.ReadLine();

                    Cars cartoreturn = null;
                    foreach (Cars car in cars)
                    {
                        if (car.CarId.Equals(carid) && !car.isAvailable())
                        {
                            cartoreturn = car;
                            break;
                        }
                        if (cartoreturn != null)
                        {
                            Customer customer = null;
                            foreach (Rental rental in rentals)
                            {
                                if (rental.C == cartoreturn)
                                {
                                    customer = rental.Cus;
                                    break;
                                }
                            }
                            if (customer != null)
                            {
                                Return(cartoreturn);
                                Console.WriteLine("Car Returned Sucessfdully by:" + customer.name);
                            }
                            else
                            {
                                Console.WriteLine("Car not found in rentals");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                    //Enter the logic for the returning of the car

                }
                else if (choice == 3)
                {
                    break;
                    // exit the prgm
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }

            }
            Console.WriteLine("\nThank you for using the Car Rental System!");
        }
    }
}
