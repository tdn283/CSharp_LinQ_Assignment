using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int ManufacturingYear { get; set; }
        public double Price { get; set; }
        public Vehicle(int id, string brand, int manufacturingYear, double price)
        {
            Id = id;
            Brand = brand;
            ManufacturingYear = manufacturingYear;
            Price = price;
        }
    }
    public class Car : Vehicle
     {
        public string EngineType { get; set; } = "Gasoline";
        public int PassengerCapacity { get; set; }
        public Car(int id, string brand, int manufacturingYear, double price, string engineType, int passengerCapacity) : base(id, brand, manufacturingYear, price)
        {
            EngineType = engineType;
            PassengerCapacity = passengerCapacity;
        }
    }
    public class Truck : Vehicle
    {
        public string Company { get; set; }
        public double LoadCapacity { get; set; }
        public Truck(int id, string brand, int manufacturingYear, double price, string company, double loadCapacity) : base(id, brand, manufacturingYear, price)
        {
            Company = company;
            LoadCapacity = loadCapacity;
        }
    }
}
