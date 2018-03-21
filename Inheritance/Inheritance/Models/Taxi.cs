namespace Inheritance.Models
{
    class Taxi : Car
    {
        private static string _numberOfPassengers;

        public static string NumberOfPassengers { get => _numberOfPassengers; set => _numberOfPassengers = value; }

        public Taxi(string name, string number, string speed, string numberOfPassengers) : base(name, number, speed)
            => NumberOfPassengers = numberOfPassengers;

        public override string displayInformationAboutTheCar(string name, string number, string speed)
            => base.displayInformationAboutTheCar(name, number, speed) + "\nNumber of passengers is " + NumberOfPassengers;
    }
}
