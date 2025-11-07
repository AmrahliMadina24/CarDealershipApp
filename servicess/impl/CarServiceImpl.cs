using CarDealershipApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp.servicess.impl
{
    internal class CarServiceImpl : ICarService
    {
        private List<Car> cars = new List<Car>();
        public void AddCar(Car car , Bank bank)
        {
            if (bank.Balance >= car.CostPrice)
            {
                bank.Balance -= car.CostPrice;
                cars.Add(car);
                Console.WriteLine($"Masin ugurla elve olundu: {car.Brand} , {car.Model} , Hal hazirki bank balanci: {bank.Balance}");
            }else
            {
                Console.WriteLine("Balans yoxdur masn ala bilmediz");
            }
        }

        public List<Car> FilterCar(int year)
        {
            return cars.Where(c => c.Year == year).ToList();
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public void RemoveCar(int id)
        {
            Car car = cars.FirstOrDefault(c =>  c.Id == id);
            if (car != null) 
            { 
                cars.Remove(car);
                Console.WriteLine($"Masin ugurla silindi: {car.Brand} , {car.Model}");
            }else
            {
                Console.WriteLine("Id ye uygun masin tapilmadi");
            }
        }

        public void SaleCar(int id, Bank bank)
        {
            Car car = cars.FirstOrDefault(c => c.Id == id);

            if (car != null)
            {
                cars.Remove(car);
                bank.Balance -= car.CostPrice;
                Console.WriteLine("Masin ugurla satildi tebrikler!!");
            }else
            {
                Console.WriteLine("Uygun id tapilmadi");
            }
        }

        public List<Car> SortCars()
        {
            return cars.OrderBy(c => c.SalePrice).ToList();
        }
    }
}
