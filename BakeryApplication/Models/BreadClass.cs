namespace BakeryApplication.Models 
{
    public class BreadClass
    {
        public int BreadLoafAmount { get; set; }
        public int BreadCost { get; set; }
        public int BonusBreadLoaves { get; set; }
        public int TotalBreadLoafCost { get; set; }

        public BreadClass(int breadLoafAmount)
        {
            BreadLoafAmount = breadLoafAmount;
            BreadCost = CalculatedBaseCost(breadLoafAmount);
        }
    }   
}


