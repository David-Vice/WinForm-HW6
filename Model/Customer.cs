using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_app9.Model
{
    public class Customer
    {
        public Customer() { }

        public Customer(string fullname, string address, string email, string citizenship)
        {
            FullName = fullname;
            Address = address;
            Email = email;
            Citizenship = citizenship;
        }

        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Citizenship { get; set; }
    }
}
