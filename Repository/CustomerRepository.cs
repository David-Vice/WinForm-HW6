using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WinForm_app9.Model;

namespace WinForm_app9.Repository
{
    class CustomerRepository : ICustomerRepository
    {
        public string xmlPath { get; set; }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;
    
        public CustomerRepository(string path)
        {
            xmlPath = path + "\\customer.xml";
            if(!File.Exists(xmlPath))
            {
                XmlFakeRepo();
            }
            customers = new List<Customer>();

            using(var ser = new StreamReader(xmlPath))
            {
                customers = (List<Customer>)xmlSerializer.Deserialize(ser);
            }
        }

        void XmlFakeRepo()
        {
            List<Customer> customerList = new List<Customer>
            {
                new Customer("John Doe", "Washington str","doe@gmail.com","USA"),
                new Customer("David Vice", "Nizami str","vice@gmail.com","UK"),
            };
            SaveCustomers(customerList);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer GetCustomerByID(int id)
        {
            return customers[id];
        }

        public void AddSaveCustomer(Customer customer)
        {
            customers.Add(customer);
            SaveCustomers(customers);
        }

        public void SaveCustomers(List<Customer> _customers)
        {
            using (var ser = new StreamWriter(xmlPath))
            {
                xmlSerializer.Serialize(ser, _customers);
            }
        }
        public void SaveCustomer(int id, Customer customer)
        {
            customers[id] = customer;
            SaveCustomers(customers);
        }
    }
}
