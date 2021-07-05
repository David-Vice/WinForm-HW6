using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_app9.Model;

namespace WinForm_app9.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerByID(int id);
        void SaveCustomer(int id, Customer customer);
        void AddSaveCustomer(Customer customer);
    }
}
