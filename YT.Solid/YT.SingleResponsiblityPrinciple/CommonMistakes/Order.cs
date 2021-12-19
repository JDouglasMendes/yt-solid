using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.SingleResponsiblityPrinciple.CommonMistakes
{
    public class Order
    {
        public long IdCustomer { get;set; }
        public long IdProduct { get; set; }
        public int Amount { get; set; }
        public decimal Value { get; set; }
        public bool IsOpen { get; set; }
        public void Save() { }
        public void NotifyCustomer() { }
        public void IsValid() { }
    }    
}
