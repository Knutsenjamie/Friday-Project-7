namespace BakeryApplication.Models 
{
    public class PastryClass
    {
        public int PastryAmount { get; set; }

        public PastryClass(int pastryAmount)
        {
            PastryAmount = pastryAmount;
        }

        public int PastryPrice(int pastryAmount)
        {
            int StartingPrice = 2;
            PastryClass newPastryClass = new PastryClass(pastryAmount);
            

            if (PastryAmount == 1) {
                return pastryAmount * StartingPrice;
            } else if (pastryAmount % 3 == 0) {
                return (pastryAmount / 3) * 5;
            } else if (pastryAmount % 3 == 1) {
                return (pastryAmount - 1) / 3 * 5 + StartingPrice;
            } else if (pastryAmount % 3 == StartingPrice) {
                return (pastryAmount - StartingPrice) / 3 * 5 + StartingPrice + StartingPrice;
            } else {
                return 0;
            }
        }
    }
}

