using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Repository;
using StockManagementSystem.Model;


namespace StockManagementSystem.BLL
{
    class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool AddCustomer(Customer _customer)
        {
            return _customerRepository.AddCustomer(_customer);
        }

        public bool UpdateCustomer(Customer _customer)
        {
            return _customerRepository.UpdateCustomer(_customer);
        }

        public List<ViewCustomer> Display()
        {
            return _customerRepository.Display();
        }

        public bool IsCodeUniqe(Customer customer)
        {
            return _customerRepository.IsCodeUniqe(customer);
        }

        public bool IsContactUniqe(String contact)
        {
            return _customerRepository.IsContactUniqe(contact);
        }

    }
}
