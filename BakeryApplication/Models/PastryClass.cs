namespace BakeryApplication.Models 
{
    public class PastryClass
    {
        public int PastryAmount { get; set; }

        public static int pastryPrice(int pastryAmount)
        {
            int PastryAmount = pastryAmount;
            int StartingPrice = 2;

            if (PastryAmount == 1) {
                return pastryAmount * StartingPrice;
            }
        }
    }
}

//Pastry: Buy 1 for \$2 or 3 for $5.
//if amount == 1... return price * amount?
//else if ... something with modulo three? Cant remember syntax to make it work.