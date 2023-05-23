using System;

namespace ConsoleApp1
{
    class InheritanceVehicles
    {
        public static void Main(string[] args)
        {
            Car car = new Car("Joe", "Hyundai", 2022);
            car.NoOfDoors = 5;

            Motorcycle motorcycle = new Motorcycle("Manju", "Pulsar", 2020);
            motorcycle.HasSideCar = false;

            car.Start();
            car.Stop();
            motorcycle.Start();
            motorcycle.Stop();

            Console.WriteLine($"the motorcycle has sidecar: {motorcycle.HasSideCar}");
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }

        virtual public void Start()
        {
            Console.WriteLine("The vehicle has started");
        }
        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped");
        }
    }
    class Car : Vehicle
    {
        public Car(string manufacturer, string make, int year)
        {
            Manufacturer = manufacturer;
            Make = make;
            Year = year;
        }
        public int NoOfDoors { get; set; }
        public override void Start()
        {
            Console.WriteLine("The car has started");
        }
    }
    class Motorcycle : Vehicle
    {
        public Motorcycle(string manufacturer, string make, int year)
        {
            this.Manufacturer = manufacturer;
            this.Make = make;
            this.Year = year;
        }
        public bool HasSideCar { get; set; }
        public override void Start()
        {
            Console.WriteLine("The mototrcycle has started");
        }
    }
}
