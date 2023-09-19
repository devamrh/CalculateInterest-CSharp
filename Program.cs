using System;

namespace CalculateInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Money Input
            Console.WriteLine("Enter the money amount (In Taka):");

            double moneyAmount = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(moneyAmount);

            // Interest Input
            Console.WriteLine("Enter the interest amount (In %):");

            double InterestAmount = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(InterestAmount);

            // Period Input
            Console.WriteLine("Enter the period (In Year):");

            double yearAmount = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(yearAmount);


            double simpleInterest = ( moneyAmount * InterestAmount * yearAmount )/ 100;

            Console.WriteLine($"The Simple Interest : {simpleInterest}");






        }
    }
}
