using System;
using Inheritance.Models;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            string line = "\n-/-/-/-/-/-/-/-/-\n";
            Car car = new Car("BMW", "1111", "200");
            SportsCar sportsCar = new SportsCar("Audi", "1111", "350", "Red");
            Taxi taxi = new Taxi("Mercedes", "3333", "100", "5");

            Console.WriteLine(car.displayInformationAboutTheCar(car.Name));
            Console.WriteLine(line);

            Console.WriteLine(car.displayInformationAboutTheCar(car.Name, car.Number));
            Console.WriteLine(line);

            Console.WriteLine(car.displayInformationAboutTheCar(car.Name, car.Number, car.Speed));
            Console.WriteLine(line);

            Console.WriteLine(sportsCar.displayInformationAboutTheCar(sportsCar.Name, sportsCar.Number, sportsCar.Speed));
            Console.WriteLine(line);

            Console.WriteLine(taxi.displayInformationAboutTheCar(taxi.Name, taxi.Number, taxi.Speed));
            Console.WriteLine(line);
            Console.ReadKey();
        }
    }
}
