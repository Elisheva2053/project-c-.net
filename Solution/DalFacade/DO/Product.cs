using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product(int Id,string Name,Enum Category,double Price,int QuantityInStock)
    {
        public Product(): this(0, "", category.wife, 1.1, 5) { }
  }
}
