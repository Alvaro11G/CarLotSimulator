using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
            //Class name.Static member
        }
        public Car(string makeInput, string modelInput, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = makeInput;
            Model = modelInput;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string HonkNoise { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDriveable { get; set; }
    }
}
