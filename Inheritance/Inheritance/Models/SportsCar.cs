namespace Inheritance.Models
{
    class SportsCar : Car
    {
        private static string _color;

        public static string Color { get => _color; set => _color = value; }

        public SportsCar(string name, string number, string speed, string color) : base(name, number, speed)
            => Color = color;

        public override string displayInformationAboutTheCar(string name, string number, string speed)
            => base.displayInformationAboutTheCar(name, number, speed) + "\nCar color is " + Color;
    }
}
