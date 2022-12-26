using Inventory.BLL.BusinessLogic;
using Inventory.DLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.UI
{
    public partial class frmCategories : Form
    {
        private int categoriesId = 0;
        public frmCategories()
        {
            InitializeComponent();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
          ClearField();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCategories();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void ClearField()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPhotoFilePath.Text = string.Empty;
            categoriesId = 0;
        }


        private void gvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                categoriesId = Convert.ToInt32(gvCategories.Rows[e.RowIndex].Cells[0].Value);
                txtName.Text = Convert.ToString(gvCategories.Rows[e.RowIndex].Cells[2].Value);
                txtDescription.Text = Convert.ToString(gvCategories.Rows[e.RowIndex].Cells[3].Value);
                

            }
            else if (e.ColumnIndex == 6)
            {
                var id = Convert.ToInt32(gvCategories.Rows[e.RowIndex].Cells[0].Value);
                DeleteCategories(id);
            }
        }

        private void SaveCategories()
        {
            if (IsFormValid())
            {
                Categories categories = new Categories();
                categories.Id = categoriesId;
                categories.Name = txtName.Text;
                categories.Description = txtDescription.Text;
                byte[] picture = GetPhoto(txtPhotoFilePath.Text);
                categories.Picture = picture;
                 

                var categoriesBLL = new CategoriesBLL();
                categoriesBLL.Save(categories);

                LoadCategories();
                ClearField();
            }
        }


        private Boolean IsFormValid()
        {
            epCategories.Clear();
            Boolean iv = true;

            if (txtName.Text == string.Empty)
            {
                txtName.Focus();
                epCategories.SetError(txtName, "Can't empty");
                iv = false;
            }


            return iv;
        }


        private void LoadCategories()
        {
            gvCategories.AutoGenerateColumns = false;
            CategoriesBLL categoriesBLL = new CategoriesBLL();
            var categories = categoriesBLL.GetAll();
            gvCategories.DataSource = categories;

        }

        private void DeleteCategories(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete this Categories?", "Delete Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                var categoriesBLL = new CategoriesBLL();
                categoriesBLL.Delete(id);
                LoadCategories();
            }

        }

        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }
            private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = oFDPhoto.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                txtPhotoFilePath.Text = oFDPhoto.FileName;

            }
        }
    }
}
