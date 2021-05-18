namespace BakeryApplication.Models 
{
    public class BreadClass
    {
        public int BreadLoafAmount { get; set; }
        public int BreadCost { get; set; }
        public int BonusBreadLoaves { get; set; }
        public int FinalBreadLoafCost { get; set; }

        public BreadClass(int breadLoafAmount)
        {
            BreadLoafAmount = breadLoafAmount;
            BreadCost = CalculatedBaseCost(breadLoafAmount);
            BonusBreadLoaves = CalculatedBonusCost(breadLoafAmount);
            FinalBreadLoafCost = BreadLoafAmount + BonusBreadLoaves;
        }

        public int CalculatedBaseCost(int breadLoafAmount)
        {

        }

        public int CalculatedBonusCost(int breadLoafAmount)
        {

        }
    }   
}


