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
    class CustomerManager
    {
        CustomerRepository _customerRepository=new CustomerRepository();

        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public DataTable Display()
        {
            return _customerRepository.Display();
        }
    }
}
