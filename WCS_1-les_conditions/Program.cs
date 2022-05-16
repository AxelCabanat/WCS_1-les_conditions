using System;

namespace WCS_1_les_conditions
{
    class Program
    {
        static void Main()
        {
            int limit1 = PickANumber("Chose a first number");
            int limit2 = PickANumber("Chose a second number");
            int topLimit = Math.Max(limit1, limit2);
            int bottomLimit = Math.Min(limit1, limit2);
            int myNumber = PickANumber("And now, chose number betwwen the previous two");
            if (myNumber > topLimit)
            {
                Console.WriteLine(myNumber + " is too high for your interval. The highest is " + topLimit);
            } else if (myNumber < bottomLimit)
            {
                Console.WriteLine(myNumber + " is too low for your interval. The lowest is " + bottomLimit);
            } else
            {
                Console.WriteLine(myNumber + " is between " + bottomLimit + " and " + topLimit);
            }
            Console.ReadKey();
        }

        static int PickANumber(string question)
        {
            Console.WriteLine(question);
            string result = Console.ReadLine();
            int parsedResult;

            while (!int.TryParse(result, out parsedResult))
            {
                Console.WriteLine("I say NUMBER ! N-U-M-B-E-R ! A round one ! Do it ! NOW !");
                result = Console.ReadLine();              
            }
            return parsedResult;
        }
   
    }
}
