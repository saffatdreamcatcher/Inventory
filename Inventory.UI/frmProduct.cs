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
                cboSupplier.SelectedValue = Convert.ToInt32(gvProduct.Rows[e.RowIndex].Cells[6].Value);
                cboCategory.SelectedValue = Convert.ToInt32(gvProduct.Rows[e.RowIndex].Cells[7].Value);
                txtQuantity.Text = Convert.ToString(gvProduct.Rows[e.RowIndex].Cells[8].Value);
                nUpUnitPrice.Value = Convert.ToDecimal(gvProduct.Rows[e.RowIndex].Cells[9].Value);
                nUpDownUnitinStock.Value = Convert.ToDecimal(gvProduct.Rows[e.RowIndex].Cells[10].Value);
                nUpDownUOD.Value = Convert.ToDecimal(gvProduct.Rows[e.RowIndex].Cells[11].Value);
                nUpDownReorder.Value = Convert.ToDecimal(gvProduct.Rows[e.RowIndex].Cells[12].Value);
                chkDiscontinued.Checked = Convert.ToBoolean(gvProduct.Rows[e.RowIndex].Cells[13].Value);


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
            product.SupplierId = Convert.ToInt32(cboSupplier.SelectedValue);
            product.CategoryId = Convert.ToInt32(cboCategory.SelectedValue);
            product.Quantity = txtQuantity.Text;
            product.UnitPrice = Convert.ToDouble(nUpUnitPrice.Value);
            product.UnitInStock = Convert.ToInt32(nUpDownUnitinStock.Value);
            product.UnitsOnOrder = Convert.ToInt32(nUpDownUOD.Value);
            product.ReorderLevel = Convert.ToInt32(nUpDownReorder.Value);
            product.Discontinued = chkDiscontinued.Checked;
            
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
            cboSupplier.SelectedValue = string.Empty;
            cboCategory.SelectedValue = string.Empty;
            txtQuantity.Text = string.Empty;
            nUpUnitPrice.Value = 0;
            nUpDownUnitinStock.Value = 0;
            nUpDownUOD.Value = 0;
            nUpDownReorder.Value = 0;
            chkDiscontinued.Checked = false;




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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
