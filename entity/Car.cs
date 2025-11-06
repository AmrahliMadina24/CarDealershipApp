using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp.entity
{
    public class Car
    {
        private static int idCounter = 1;

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public bool IsRented { get; set; }

        public Car() { }

        public Car(string brand, string model, int year, double costPrice, double salePrice, bool isRented)
        {
            Id = idCounter++;
            Brand = brand;
            Model = model;
            Year = year;
            CostPrice = costPrice;
            SalePrice = salePrice;
            IsRented = isRented;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} , Brand: {Brand} , Model: {Model} , Year: {Year} , CostPrice: {CostPrice} , SalePrice: {SalePrice} , isRented: {IsRented}");
        }

        

    }
}
