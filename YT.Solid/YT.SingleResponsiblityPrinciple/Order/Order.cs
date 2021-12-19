using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.SingleResponsiblityPrinciple.Order
{
    public class Order
    {
        public long IdCustomer { get; }
        public long IdProduct { get; }
        public int Amount { get; }
        public decimal Value { get; }
        public bool IsOpen { get; }

        public Order(long idCustomer, long idProduct, int amount, decimal value)
           => (IdCustomer, IdProduct, Amount, Value, IsOpen) =
                (idCustomer, idProduct, amount, value, false);

        public Order(long idCustomer, long idProduct, int amount, decimal value, bool isOpen)
            => (IdCustomer, IdProduct, Amount, Value, IsOpen) =
                (idCustomer, idProduct, amount, value, isOpen);

        public void IsValid() { }
    }
}
