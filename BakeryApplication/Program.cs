using System; 
using BakeryApplication.Models;

namespace BakeryApplication
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("\n Welcome To Pierre's Bakery! We have fresh baked bread and buttery pastries! Baked bread loaves start at $5 a loaf, and pastries start at just $2!");

            Console.WriteLine(" \n How many loaves of bread would you like? Please enter in a number to see your total price: \n");
            string personInput = Console.ReadLine();
            int personsInput = int.Parse(personInput);

            BreadClass breadOrder = new BreadClass();
            Console.WriteLine($"\n Price: ${breadOrder.BreadCount(personsInput)} & you also get { breadOrder.BreadTotal()} for free! \n");

            Console.WriteLine("How many pastries would you like? Please enter in a number to see your total price: \n");
            string result1 = Console.ReadLine(); 
            int result2 =  int.Parse(result1);


            Console.WriteLine($"\n The pastries cost will be: ${PastryClass.pastryPrice(result2)} \n");
            int total = breadOrder.BreadCount(personsInput) + PastryClass.pastryPrice(result2);
            Console.WriteLine("\n For your amount of baked goods, your total is: $" + total + ". Have a wonderful day! \n");
        }
    }
}