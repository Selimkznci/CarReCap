using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //  TestSimü();
            //    ColorTest();
            //BrandTest();
            // CarTest();
            //UserTest();
            RentalTest();
            //CustomerTest();
        }
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();

            if (result.Succes)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine("Car with ID: " + rental.CarId + " rented at " + rental.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.message);
            }
        }
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Succes)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + " " + user.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.message);
            }
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();

            if (result.Succes)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }

            else
            {
                Console.WriteLine(result.message);
            }
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            if (result.Succes)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.message);
            }
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.carDetailDtos();
            if (result.Succes)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.CarName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.message);
            }
        }
            private static void CustomerTest()
            {
                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

                var result = customerManager.GetAll();

                if (result.Succes)
                {
                    foreach (var customer in result.Data)
                    {
                        Console.WriteLine(customer.CompanyName);
                    }
                }
                else
                {
                    Console.WriteLine(result.message);
                }
            }
        }
    }

