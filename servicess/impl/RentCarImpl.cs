using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealershipApp.entity;

namespace CarDealershipApp.servicess.impl
{
    internal class RentCarImpl : IRentCar
    {
        private List<Car> rentCars = new List<Car>();

        public void AddCar(Car car, Bank bank)
        {
            if (bank.Balance >= car.CostPrice)
            {
                bank.Balance -= car.CostPrice;
                rentCars.Add(car);
                Console.WriteLine($"Icarelik masin elave olundu: {car.Brand} {car.Model}. Yeni balans: {bank.Balance}");
            }
            else
            {
                Console.WriteLine("Balans kifayet deyil, icarelik masin elave edilmedi.");
            }
        }

        public void RemoveCar(Car car)
        {
            if (rentCars.Remove(car))
            {
                Console.WriteLine($"Maşın silindi: {car.Brand} {car.Model}");
            }
            else
            {
                Console.WriteLine("Maşın tapılmadı.");
            }
        }

        public List<Car> GetAllCars()
        {
            return rentCars;
        }

        public List<Car> FilterCar(int year)
        {
            return rentCars.Where(c => c.Year == year).ToList();
        }

        public List<Car> SortCars()
        {
            return rentCars.OrderBy(c => c.SalePrice).ToList();
        }

        public void RentCar(int id, Bank bank)
        {
            Car car = rentCars.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                Console.WriteLine("Bu ID-yə uyğun maşın tapılmadı.");
                return;
            }

            if (car.IsRented)
            {
                Console.WriteLine("Bu maşın artıq icarədədir."); 
                return;
            }
            double rentPrice = car.SalePrice * 0.1; 
            car.IsRented = true; 
            bank.Balance += rentPrice; 

            Console.WriteLine($"Maşın icarəyə verildi: {car.Brand} {car.Model}. Icare haqqı: {rentPrice}. Yeni balans: {bank.Balance}");
        }
    }
}