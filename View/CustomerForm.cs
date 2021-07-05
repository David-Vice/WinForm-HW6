using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_app9.Presenter;
using WinForm_app9.Model;

namespace WinForm_app9.View
{
    public partial class CustomerForm : Form, ICustomerView
    {
        public IList<string> CustomerList
        {
            get { return (IList<string>)this.listBox1.DataSource; }
            set { this.listBox1.DataSource = value; }
        }
        public string FullName
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }
        public string Address
        {
            get { return addressTextBox.Text; }
            set { addressTextBox.Text = value; }
        }
        public string Email
        {
            get { return emailTextBox.Text; }
            set { emailTextBox.Text = value; }
        }
        public string Citizenship
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public CustomerPresenter customerPresenter { get; set; }
        public int SelectedCustomer {get => listBox1.SelectedIndex; set => listBox1.SelectedIndex = value; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerPresenter.UpdateCustomerView(listBox1.SelectedIndex);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            customerPresenter.SaveCustomer2();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            customerPresenter.SaveCustomer();
        }
    }
}
