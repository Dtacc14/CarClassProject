using System;

namespace CarClassProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCurrentCar = new Car() { Make = "Kia", Modle = "Rio", Year = 2021};
            Console.WriteLine($"I drive a {myCurrentCar.Year} {myCurrentCar.Make} {myCurrentCar.Modle}.");
            Console.WriteLine();

            var myLastCar = new Car() { Make = "Volkswagen", Modle = "Jetta", Year = 2017 };
            Console.WriteLine($"I used to drive a {myLastCar.Year} {myLastCar.Make} {myLastCar.Modle}.");
        }
    }
}