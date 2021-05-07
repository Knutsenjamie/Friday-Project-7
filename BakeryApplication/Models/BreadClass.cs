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

// if (BreadAmount >= 2 && % 2 )
//             {
//             return BreadAmount / 2;
//             }
