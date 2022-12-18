using Inventory.BLL.BusinessLogic;
using Inventory.DLL.Entities;
using System;
using System.Windows.Forms;

namespace MyApp
{
  public partial class form1 : Form
  {
    private int id =  0;
    public form1()
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
      Product product = new Product() { Id = id, Name = txtName.Text };
      var productBLL = new ProductBLL();
      productBLL.Save(product);
      LoadProduct();
      ClearField();
    }

    private void LoadProduct()
    {
            gvProduct.AutoGenerateColumns = false;
            ProductBLL productBLL = new ProductBLL();
            var products = productBLL.GetAll();
            gvProduct.DataSource = products;

        }

        private void ClearField()
    {
      txtName.Text = string.Empty;
      id = 0;
    }

    private void DeleteProduct(int id)
    {
      if (MessageBox.Show("Are you sure you want to delete the product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
      {
        var productBLL = new ProductBLL();
        productBLL.Delete(id);
        LoadProduct();
      }
      
    }

  }
}
