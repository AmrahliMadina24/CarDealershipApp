using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp.servicess
{
    internal interface IRentCar
    {
        void AddCar(Car car, Bank bank);
        void RemoveCar(int car_id);
        List<Car> GetAllCars();
        List<Car> FilterCar(int year);
        List<Car> SortCars();
        void RentCar(int id, Bank bank);
    }
}
