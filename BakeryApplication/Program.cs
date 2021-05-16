using System; 
using BakeryApplication.Models;

namespace BakeryApplication
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome To Pierre's Bakery! We have fresh baked bread and buttery pastries! Baked bread loaves start at $5 a loaf, and pastries start at just $2!");

            Console.WriteLine("How many loaves of bread would you like? Please enter in a number to see your total price:");
            string personInput = Console.ReadLine();
            int personsInput = int.Parse(personInput);

            BreadClass breadOrder = new BreadClass();
            Console.WriteLine($"Price: {breadOrder.BreadCount(personsInput)}  +  you also get { breadOrder.BreadTotal()} free!");

            
        }
    }
}