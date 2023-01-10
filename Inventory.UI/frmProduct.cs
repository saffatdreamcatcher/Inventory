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
            if (e.ColumnIndex == 14)
            {
                id = Convert.ToInt32(gvProduct.Rows[e.RowIndex].Cells[0].Value);
                txtName.Text = Convert.ToString(gvProduct.Rows[e.RowIndex].Cells[1].Value);
                cboSupplier.SelectedValue = Convert.ToInt32(gvProduct.Rows[e.RowIndex].Cells[4].Value);
                cboCategory.SelectedValue = Convert.ToInt32(gvProduct.Rows[e.RowIndex].Cells[5].Value);
                txtQuantity.Text = Convert.ToString(gvProduct.Rows[e.RowIndex].Cells[6].Value);
                nUpUnitPrice.Value = Convert.ToDecimal(gvProduct.Rows[e.RowIndex].Cells[7].Value);
                nUpDownUnitinStock.Value = Convert.ToDecimal(gvProduct.Rows[e.RowIndex].Cells[8].Value);
                nUpDownUOD.Value = Convert.ToDecimal(gvProduct.Rows[e.RowIndex].Cells[9].Value);
                nUpDownReorder.Value = Convert.ToDecimal(gvProduct.Rows[e.RowIndex].Cells[10].Value);
                chkDiscontinued.Checked = Convert.ToBoolean(gvProduct.Rows[e.RowIndex].Cells[11].Value);


            }
            else if (e.ColumnIndex == 15)
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
            //if (Convert.ToInt32(cboSupplier.SelectedValue) > -1)
            //{
                product.SupplierId = Convert.ToInt32(cboSupplier.SelectedValue);
            //}
            //else
            //{
            //    product.SupplierId = null;
            //}

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
            Supplier supplier = new Supplier();
            supplier.Id = -1;
            supplier.Name = "Please Select-";

            SupplierBLL supplierBLL = new SupplierBLL();
            List<Supplier> suppliers = supplierBLL.GetAll();
            suppliers.Insert(0, supplier);
            cboSupplier.DataSource = suppliers;
            cboSupplier.ValueMember = "Id";
            cboSupplier.DisplayMember = "Name";

            List<Supplier> suppliersSearch = supplierBLL.GetAll();
            suppliersSearch.Insert(0, supplier);
            comboSupplier.DataSource = suppliersSearch;
            comboSupplier.ValueMember = "Id";
            comboSupplier.DisplayMember = "Name";
            
        }


        private void LoadCategory()
        {
            Categories categories1 = new Categories();
            categories1.Id = -1;
            categories1.Name = "Please Select-";

            CategoriesBLL categoryBLL = new CategoriesBLL();
            List<Categories> categories = categoryBLL.GetAll();
            categories.Insert(0, categories1);
            cboCategory.DataSource = categories;
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";

            List<Categories> categoriesSearch = categoryBLL.GetAll();
            categoriesSearch.Insert(0, categories1);
            comboCategory.DataSource = categoriesSearch;
            comboCategory.ValueMember = "Id";
            comboCategory.DisplayMember= "Name";
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
            txtName.Focus();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sn = "";
            //if (comboSupplier.SelectedIndex != -1)
            if (Convert.ToInt32(comboSupplier.SelectedValue) > -1)

            {
                sn += "SupplierId =" + comboSupplier.SelectedValue;

            }

            //if (comboCategory.SelectedValue != "")
            if (Convert.ToInt32(comboCategory.SelectedValue) > -1)
            {
                if (sn != string.Empty)
                    sn = sn + " AND ";
                sn +=  "CategoryId =" + comboCategory.SelectedValue;

            }

            ProductBLL pro = new ProductBLL();
            List<Product> products = pro.GetAll(sn);
            gvProduct.DataSource = products;

        }
    }
}
