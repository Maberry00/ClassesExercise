using Microsoft.VisualBasic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Nissan";
            myCar.Model = "GTR";
            myCar.Year = 2010;

            var jeep = new Car()
            {
                Make = "Jeep",
                Model = "SRT",
                Year = 2022
            };

            var ford = new Car("Ford", "Mustang", 1965);

            var carList = new List<Car>() { myCar, ford, jeep};

            foreach (var car in carList) 
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }

        }
    }
}
