using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Name = "Jose Beltran";
            const string Location = "Provo, UT";

            Console.WriteLine($"My name is {Name}, I am from {Location}.");

            DateTime today = DateTime.Today;
            DateTime christmasDate = new DateTime(today.Year, 12, 25);
            TimeSpan daysRemaining = christmasDate - today;
            Console.WriteLine(daysRemaining);

            Console.Write("Width (in feet): ");
            string widthString = Console.ReadLine();
            double width = double.Parse(widthString);

            Console.Write("Height (in feet): ");
            string heightString = Console.ReadLine();
            double height = double.Parse(heightString);

            double woodLength = 2 * (width + height) * 3.25;
            double glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square feet");

            Console.WriteLine("press a key to shut-down");
            Console.ReadKey();
        }
    }
}
