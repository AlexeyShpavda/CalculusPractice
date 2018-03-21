using Inheritance.Interfaces;

namespace Inheritance.Models
{
    class Car : IDisplayInformationAboutTheCar
    {
        private string _name;
        private string _number;
        private string _speed;

        public string Name { get => _name; set => _name = value; }
        public string Number { get => _number; set => _number = value; }
        public string Speed { get => _speed; set => _speed = value; }

        public Car(string name, string number, string speed)
        {
            Name = name;
            Number = number;
            Speed = speed;
        }

        public string displayInformationAboutTheCar(string name)
            => ("Car name is " + name);

        public string displayInformationAboutTheCar(string name, string number)
            => ("Car name is " + name + "\nCar number is " + number);

        public virtual string displayInformationAboutTheCar(string name, string number, string speed)
            => ("Car name is " + name + "\nCar number is " + number + "\nCar speed is " + speed);
    }
}
