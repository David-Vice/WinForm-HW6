using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_app9.Repository;
using WinForm_app9.Model;
using WinForm_app9.View;

namespace WinForm_app9.Presenter
{
    public class CustomerPresenter
    {
        ICustomerRepository repository;
        ICustomerView view;

        public CustomerPresenter(ICustomerView customerForm, ICustomerRepository repository)
        {
            this.view = customerForm;
            this.view.customerPresenter = this;
            this.repository = repository;
            UpdateCustomerListView();
        }

        public void UpdateCustomerView(int id)
        {
            Customer customer = repository.GetCustomerByID(id);
            view.FullName = customer.FullName;
            view.Address = customer.Address;
            view.Email = customer.Email;
            view.Citizenship = customer.Citizenship;
        }
        public void SaveCustomer() //Edit
        {
            Customer customer = new Customer(view.FullName, view.Address, view.Email, view.Citizenship);
            repository.SaveCustomer(view.SelectedCustomer,customer);
            UpdateCustomerListView();
        }
        public void SaveCustomer2()
        {
            Customer customer = new Customer(view.FullName, view.Address, view.Email, view.Citizenship);
            repository.AddSaveCustomer(customer);
            UpdateCustomerListView();
        }
        public void UpdateCustomerListView()
        {
            var customerNames = repository.GetAllCustomers().Select(x => x.FullName);
            int selectedCustomer = view.SelectedCustomer >= 0 ? view.SelectedCustomer : 0;
            view.CustomerList = customerNames.ToList();
            view.SelectedCustomer = selectedCustomer;
        }
    }
}
