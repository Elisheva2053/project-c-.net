using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    
    
    public record Sale(int Id,int IdProduct,int CountForSale,double TotalPrice,bool NeedClub,DateTime StartSale,DateTime FinishSale )
    {
        static private int id = 0;
        public Sale() : this(id++, 123, 50, 100.0, true, DateTime.Now, DateTime.Now) { }
     

    }
}
