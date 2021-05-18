using System; 
using BakeryApplication.Models;

namespace BakeryApplication
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("\n 🥖🥐🥖 Welcome To Pierre's Bakery! We have fresh baked bread and buttery pastries! Baked bread loaves  start at $5 a loaf, and pastries start at just $2! 🥖🥐🥖");

            Console.WriteLine("\n ----------------------------------------------------------------------------------------------");

            Console.WriteLine(" \n How many loaves of bread 🥖 would you like? Please enter in a number to see your total price: \n");
            string stringInput = Console.ReadLine();
            int personsInput = int.Parse(stringInput);

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            BreadClass breadOrder = new BreadClass(personsInput);
            Console.WriteLine("\n Congratulations! Because of our special today, you get some extra loaves thrown in " + "( You get " + breadOrder.TotalAmountOfBreadLoaves + "  loaves in total! ) " + " AND you only pay $" + breadOrder.BreadCost + ".00, " + "Which means you ONLY pay for " + personsInput + " Loaves! \n");

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            Console.WriteLine("\n How many pastries 🥐 would you like? Please enter in a number to see your total price: \n");
            string stringInput2 = Console.ReadLine(); 
            int personsInput2 =  int.Parse(stringInput2);

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            PastryClass pastryOrder = new PastryClass(personsInput2);

            Console.WriteLine($"\n The pastries cost will be: $" + pastryOrder.FinalTotalCost + ".00. If you bought at least three pastries *drumroll* you ALSO got the 3 for $5 deal DISCOUNTED 💃 price!");

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            int total = breadOrder.BreadCost + pastryOrder.FinalTotalCost;
            Console.WriteLine("\n For your amount of baked goods, your total is: $" + total + ".00. Have a wonderful day! (And enjoy the deals if you got them 😏) \n");
        }
    }
}