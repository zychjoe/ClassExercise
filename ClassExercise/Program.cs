using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Chevy92 = new Car();
            Chevy92.Make = "Chevrolet";
            Chevy92.Model = "Cavalier";
            Chevy92.Year = 1992;

            Console.WriteLine($"Make: {Chevy92.Make}, Model: {Chevy92.Model}, Year: {Chevy92.Year}");
        }
    }
}
