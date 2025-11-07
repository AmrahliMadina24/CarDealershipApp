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
            
        }

        public List<Car> FilterCar(int year)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public void RemoveCar(Car car)
        {
            throw new NotImplementedException();
        }

        public void SaleCar(int id, Bank bank)
        {
            throw new NotImplementedException();
        }

        public List<Car> SortCars()
        {
            throw new NotImplementedException();
        }
    }
}
