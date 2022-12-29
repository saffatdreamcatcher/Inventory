using Inventory.BLL.BusinessLogic;
using Inventory.DLL.Entities;
using System;
using System.Windows.Forms;

namespace Inventory.UI
{
  public partial class frmCustomer : Form
  {
    private int customerId = 0;

    public frmCustomer()
    {
      InitializeComponent();
    }

    private void btnSave2_Click(object sender, EventArgs e)
    {
      SaveCustomer();
    }

    private void frmCustomer_Load(object sender, EventArgs e)
    {
      LoadCustomer();
    }

    private void gvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      ManageEdit(e);
    }

    private void ManageEdit(DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 9)
      {
        customerId = Convert.ToInt32(gvCustomer.Rows[e.RowIndex].Cells[0].Value);
        txtName2.Text = Convert.ToString(gvCustomer.Rows[e.RowIndex].Cells[2].Value);
        txtContact.Text = Convert.ToString(gvCustomer.Rows[e.RowIndex].Cells[3].Value);
        txtAddress.Text = Convert.ToString(gvCustomer.Rows[e.RowIndex].Cells[4].Value);
        txtCity.Text = Convert.ToString(gvCustomer.Rows[e.RowIndex].Cells[5].Value);
        txtPostalCode.Text = Convert.ToString(gvCustomer.Rows[e.RowIndex].Cells[6].Value);
        txtCountry.Text = Convert.ToString(gvCustomer.Rows[e.RowIndex].Cells[7].Value);

      }
      else if (e.ColumnIndex == 10)
      {
        var id = Convert.ToInt32(gvCustomer.Rows[e.RowIndex].Cells[0].Value);
        DeleteCustomer(id);
      }
    }

    private void SaveCustomer()
    {
      Customer customer = new Customer();
      customer.Id = customerId;
      customer.Name = txtName2.Text;
      customer.Address = txtAddress.Text;
      customer.Contact = txtContact.Text;
      customer.City = txtCity.Text;
      customer.PostalCode = txtPostalCode.Text;
      customer.Country = txtCountry.Text;
      var customerBLL = new CustomerBLL();
      customerBLL.Save(customer);
      LoadCustomer();
      ClearField();
    }

    private void LoadCustomer()
    {
      gvCustomer.AutoGenerateColumns = false;
      CustomerBLL customerBLL = new CustomerBLL();
      var customer = customerBLL.GetAll();
      gvCustomer.DataSource = customer;

    }

    private void ClearField()
    {
      txtName2.Text = string.Empty;
      txtAddress.Text = string.Empty;
      txtContact.Text = string.Empty;
      txtPostalCode.Text = string.Empty;
      txtCountry.Text = string.Empty;
      txtCity.Text = string.Empty;
      customerId = 0;
    }

    private void btnSave2_Click_1(object sender, EventArgs e)
    {
      SaveCustomer();
    }

    private void DeleteCustomer(int id)
    {
      if (MessageBox.Show("Are you sure you want to delete this Customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
      {
        var customerBLL = new CustomerBLL();
        customerBLL.Delete(id);
        LoadCustomer();
      }

    }

    private void resetbtn_Click(object sender, EventArgs e)
    {

      ClearField();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
