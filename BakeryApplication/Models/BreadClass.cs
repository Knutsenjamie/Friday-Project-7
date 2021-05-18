namespace BakeryApplication.Models 
{
    public class BreadClass
    {
        public int BreadLoafAmount { get; set; }
        public int BreadCost { get; set; }
        public int BonusBreadLoaves { get; set; }
        public int TotalAmountOfBreadLoaves { get; set; }

        public BreadClass(int breadLoafAmount)
        {
            BreadLoafAmount = breadLoafAmount;
            BreadCost = CalculatedBaseCost(breadLoafAmount);
            BonusBreadLoaves = CalculatedBonusCost(breadLoafAmount);
            TotalAmountOfBreadLoaves = BreadLoafAmount + BonusBreadLoaves;
        }

        public int CalculatedBaseCost(int breadLoafAmount)
        {
            if(breadLoafAmount <= 0)
            {
                return 0;
            }
            else
            {
                return breadLoafAmount * 5;
            }
        }

        public int CalculatedBonusCost(int breadLoafAmount)
        {
            if(breadLoafAmount < 2)
            {
                return 0;
            }
            else
            {
                int extraLoaves = breadLoafAmount / 2;
                return extraLoaves;
            }
        }
    }   
}


