namespace BakeryApplication.Models 
{
    public class BreadClass
    {
        public int BreadAmount { get; set;}

        public BreadPrice(int breadAmount)
        {
            BreadAmount = breadAmount;
            return BreadAmount * 5.00;
        }
    }   
}


