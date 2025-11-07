using CarDealershipApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp.servicess
{
    internal interface ICarService
    {
        void AddCar(Car car , Bank bank);
        void RemoveCar(Car car);
        List<Car> GetAllCars();
        List<Car> FilterCar(int year);

        List<Car> SortCars();
        void SaleCar(int id , Bank bank);

    }
}
