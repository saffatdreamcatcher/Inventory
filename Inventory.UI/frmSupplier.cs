using Inventory.BLL.BusinessLogic;
using Inventory.DLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.UI
{

   
    public partial class frmSupplier : Form
    {

        private int supplierId = 0;
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }


        private void gvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }


        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                supplierId = Convert.ToInt32(gvSupplier.Rows[e.RowIndex].Cells[0].Value);
                txtName2.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[2].Value);
                txtContact.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[3].Value);
                txtContactTitle.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[4].Value);
                txtAddress.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[5].Value);
                txtCity.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[6].Value);
                txtPostalCode.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[7].Value);
                txtCountry.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[9].Value);
                txtRegion.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[10].Value);
                txtPhone.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[11].Value);
                txtFax.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[12].Value);
                txtHomePage.Text = Convert.ToString(gvSupplier.Rows[e.RowIndex].Cells[13].Value);
            }
            else if (e.ColumnIndex == 15)
            {
                var id = Convert.ToInt32(gvSupplier.Rows[e.RowIndex].Cells[0].Value);
                DeleteSupplier(id);
            }
        }

        private void SaveCustomer()
        {
            
            //Boolean isValid = IsFormValid();
            if (IsFormValid())
            {

                Supplier supplier = new Supplier();
                supplier.Id = supplierId;
                supplier.Name = txtName2.Text;
                supplier.Address = txtAddress.Text;
                supplier.Contact = txtContact.Text;
                supplier.ContactTitle = txtContactTitle.Text;
                supplier.City = txtCity.Text;
                supplier.PostalCode = txtPostalCode.Text;
                supplier.Country = txtCountry.Text;
                supplier.Region = txtRegion.Text;
                supplier.Phone = txtPhone.Text;
                supplier.Fax = txtFax.Text;
                supplier.HomePage = txtHomePage.Text;
                var supplierBLL = new SupplierBLL();
                supplierBLL.Save(supplier);
                LoadSupplier();
                ClearField();
            }
            
        }

        private Boolean IsFormValid()
        {
           epSupplier.Clear();
            Boolean iv = true;

            if (txtName2.Text == string.Empty)
            {
                txtName2.Focus();
                epSupplier.SetError(txtName2 , "Can't empty");
                iv = false;
            }
          

           return iv;
        }


        private void LoadSupplier()
        {
            gvSupplier.AutoGenerateColumns = false;
            SupplierBLL supplierBLL = new SupplierBLL();
            List<Supplier> supplier = supplierBLL.GetAll();
            gvSupplier.DataSource = supplier;

        }

        private void ClearField()
        {
            txtName2.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtContactTitle.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtRegion.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtHomePage.Text = string.Empty;
            supplierId = 0;
        }

        private void DeleteSupplier(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete this Supplier?", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                var supplierBLL = new SupplierBLL();
                supplierBLL.Delete(id);
                LoadSupplier();
            }

        }

        private void gvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }
    }
}
