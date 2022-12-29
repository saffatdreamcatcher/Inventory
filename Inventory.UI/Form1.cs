using MyApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventory.DLL.Repositories;
using Inventory.DLL.Entities;
using Inventory.UI;

namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
    }

    private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnClear_Click(object sender, EventArgs e)
    {

    }

    private void btnProduct_Click(object sender, EventArgs e)
    {
            frmProduct p = new frmProduct();
            p.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //var productDLL = new ProductDLL();
            //Product D = productDLL.GetById(10);
            // int d= productDLL.GetCount();

            // int d1 = productDLL.GetCount("id = 9");

            //int d2 = productDLL.GetCount("Name like '%a%'");

            //var customerDLL = new CustomerDLL();
            //Customer D = customerDLL.GetById(3);

            //var customerDLL = new CustomerDLL();
            //int d3 = customerDLL.GetCount("id = 5");

            //var customerDLL = new CustomerDLL();
            //List<Customer> H = customerDLL.GetAll();

            //var customerDLL = new CustomerDLL();
            //var customer = new Customer();
            //customer.Name = "Saffat";
            //customer.Contact = "01751834923";
            //customer.City = "Berlin";
            //customer.Country = "Germany";
            //customer.PostalCode = "9805";
            //customer.Address = "Berlin Street";

            //int id = customerDLL.Save(customer);

            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //var customerDLL = new CustomerDLL();
            //Customer D = customerDLL.GetById(1);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier frmSupplier = new frmSupplier();
            frmSupplier.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategories frmCategories = new frmCategories();
            frmCategories.ShowDialog();
        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            frmRegion frmRegion = new frmRegion();
            frmRegion.ShowDialog();
        }
    }
}
