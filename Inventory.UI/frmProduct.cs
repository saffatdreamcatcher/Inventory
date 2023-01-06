using Inventory.BLL.BusinessLogic;
using Inventory.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmProduct : Form
    {
        private int id = 0;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadSupplier();
            LoadCategory();
        }

        private void gvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);

        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                id = Convert.ToInt32(gvProduct.Rows[e.RowIndex].Cells[0].Value);
                txtName.Text = Convert.ToString(gvProduct.Rows[e.RowIndex].Cells[1].Value);
            }
            else if (e.ColumnIndex == 5)
            {
                var id = Convert.ToInt32(gvProduct.Rows[e.RowIndex].Cells[0].Value);
                DeleteProduct(id);
            }
        }

        private void SaveProduct()
        {
            Product product = new Product();
            product.Id = id;
            product.Name = txtName.Text;
            product.UnitInStock = Convert.ToInt32(nUpDownUnitinStock.Value);
            product.Discontinued = chkDiscontinued.Checked;
            //Do the other assignment here

            product.Quantity = txtQuantity.Text;
            var productBLL = new ProductBLL();
            productBLL.Save(product);
            LoadProduct();
            ClearField();
        }

        private void LoadProduct()
        {
            gvProduct.AutoGenerateColumns = false;
            ProductBLL productBLL = new ProductBLL();
            List<Product> products = productBLL.GetAll();
            gvProduct.DataSource = products;


        }

        private void LoadSupplier()
        {
            SupplierBLL supplierBLL = new SupplierBLL();
            List<Supplier> suppliers = supplierBLL.GetAll();
            cboSupplier.DataSource = suppliers;
            cboSupplier.ValueMember = "Id";
            cboSupplier.DisplayMember = "Name";
        }


        private void LoadCategory()
        {
            CategoriesBLL categoryBLL = new CategoriesBLL();
            List<Categories> categories = categoryBLL.GetAll();
            cboCategory.DataSource = categories;
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";
        }
        private void ClearField()
        {
            txtName.Text = string.Empty;
            id = 0;
        }

        private void DeleteProduct(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete the product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                var productBLL = new ProductBLL();
                productBLL.Delete(id);
                LoadProduct();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
