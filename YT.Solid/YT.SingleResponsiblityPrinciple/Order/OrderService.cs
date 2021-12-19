using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.SingleResponsiblityPrinciple.Order
{
    public class OrderService
    {
        private OrderRespository orderRespository;
        private CustomerService customerService;
        public OrderService(OrderRespository orderRespository, 
                            CustomerService customerService)
        {
            this.orderRespository = orderRespository;
            this.customerService = customerService;
        }

        public void Save(Order order) => orderRespository.Save(order);
        public void NotifyCustomer(Order order) => customerService.NotifyCustomer(order.IdCustomer);
    }
}
