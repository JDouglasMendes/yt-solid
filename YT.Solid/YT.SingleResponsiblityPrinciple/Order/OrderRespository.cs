using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.SingleResponsiblityPrinciple.Order
{
    public interface OrderRespository
    {
        public void Save(Order order);
    }
}
