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
            } else if (pastryAmount % 3 == 0) {
                return (pastryAmount / 3) * 5;
            } else {
                return 0;
            }
        }
    }
}

