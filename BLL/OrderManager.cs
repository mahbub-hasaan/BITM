using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITM_Works.Models;
using BITM_Works.Repository;
namespace BITM_Works.BLL
{
    class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public DataTable ItemCombo()
        {
            return _orderRepository.ItemCombo();
        }
        public DataTable CustomerCombo()
        {
            return _orderRepository.CustomerCombo();
        }

        public double GetItemPrice(int id)
        {
            return _orderRepository.GetItemPrice(id);
        }

        public bool Add(Order order)
        {
            return _orderRepository.Add(order);
        }

        public DataTable Display()
        {
            return _orderRepository.Display();
        }
    }
}
