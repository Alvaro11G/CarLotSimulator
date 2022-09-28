 using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot Lot = new CarLot();

            Car ford = new Car();
            Lot.CarList.Add(ford);

            ford.Make = "Ford";
            ford.Model = "F-150";
            ford.Year = 2018;
            ford.EngineNoise = "Vroom";
            ford.HonkNoise = "BeepBeep";
            ford.IsDriveable = true;

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            var toyota = new Car()
            {
                Make = "Toyota",
                Model = "Tacoma",
                Year = 2020,
                EngineNoise = "Vroom",
                HonkNoise = "Beep",
                IsDriveable = true
            };
            Lot.CarList.Add(toyota);

            toyota.MakeEngineNoise();
            toyota.MakeHonkNoise();

            var chevy = new Car("Chevy", "Silverado", 2010, "Vroom", "Honk Honk", true);
            Lot.CarList.Add(chevy);

            chevy.MakeEngineNoise();
            chevy.MakeHonkNoise();

            //Counting cars
            Console.WriteLine($"\nNumber of cars created: {CarLot.numberOfCars}\n");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            foreach (var car in Lot.CarList)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
