using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_app9.Presenter;

namespace WinForm_app9.View
{
    public interface ICustomerView
    {
        IList<string> CustomerList { get; set; }
        int SelectedCustomer { get; set; }
        string FullName { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string Citizenship { get; set; }
        CustomerPresenter customerPresenter { get; set; }
    }
}
