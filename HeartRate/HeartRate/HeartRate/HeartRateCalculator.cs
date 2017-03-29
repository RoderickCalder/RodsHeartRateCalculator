using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRate
{
    public class HeartRateCalculator
    {
        public static void Main()
        {
            var restingHeartRate = 0;
            var personsAge = 0;

            while (restingHeartRate <= 0 && personsAge <= 0)
            {
                Console.WriteLine("Please Enter Your Heart Rate: ");
                var  userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out restingHeartRate))
                {
                    Console.WriteLine("That Is Not A Valid Input");
                    continue;
                }

                Console.WriteLine("Please Enter Your Age: ");
                userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out personsAge))
                {
                    Console.WriteLine("That Is Not A Valid Input");
                    continue;
                }

                OutputHeartRate(restingHeartRate, personsAge);

                Console.WriteLine("Press Any Button To Continue....");
                Console.ReadKey();
            }
        }

        private static void OutputHeartRate(int heartRate, int personsAge)
        {
            var results = CalculateHeartRate(heartRate, personsAge);
            var intensity = 50;

            Console.WriteLine("Intensity | Heart rate");
            Console.WriteLine("----------|-----------");

            foreach (var heartOutcome in results)
            {
                intensity += 5;
                Console.WriteLine(intensity + "%       |     " + heartOutcome);
            }

        }

        public static List<double> CalculateHeartRate(int heartRate, int personsAge)
        {
            var results = new List<double>();

            for(var intensity = 0.5; intensity < 0.95; intensity += 0.05)
            {
                results.Add(((220 - personsAge) - heartRate) * intensity + heartRate) ;
            }

            return results;
        }
    }
}
