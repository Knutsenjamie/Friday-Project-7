namespace BakeryApplication.Models 
{
    public class BreadClass
    {
        public int BreadAmount { get; set;}

        public int BreadCount(int breadAmount)
        {
            BreadAmount = breadAmount;
            return BreadAmount * 5;
        }
    
    }   
}


