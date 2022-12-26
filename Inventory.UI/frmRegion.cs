using Inventory.BLL.BusinessLogic;
using Inventory.DLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.UI
{
    public partial class frmRegion : Form
    {

        private int regionId = 0;
        

        public frmRegion()
        {
            InitializeComponent();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRegion();
        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            LoadRegion();
        }

        private void ClearField()
        {
           
            txtDescription.Text = string.Empty;
            regionId = 0;
        }


        private void gvRegion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }


        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                regionId = Convert.ToInt32(gvRegion.Rows[e.RowIndex].Cells[0].Value);
                
                txtDescription.Text = Convert.ToString(gvRegion.Rows[e.RowIndex].Cells[2].Value);


            }
            else if (e.ColumnIndex == 5)
            {
                var id = Convert.ToInt32(gvRegion.Rows[e.RowIndex].Cells[0].Value);
                DeleteRegion(id);
            }
        }


        private void SaveRegion()
        {
            if (IsFormValid())
            {
                Region region = new Region();
                region.Id = regionId;
                region.Description = txtDescription.Text;
                var regionBLL = new RegionBLL();
                regionBLL.Save(region);


                LoadRegion();
                ClearField();
            }
        }


        private Boolean IsFormValid()
        {
            epRegion.Clear();
            Boolean iv = true;

            if (txtDescription.Text == string.Empty)
            {
                txtDescription.Focus();
                epRegion.SetError(txtDescription, "Can't empty");
                iv = false;
            }


            return iv;
        }


        private void LoadRegion()
        {
            gvRegion.AutoGenerateColumns = false;
            RegionBLL regionBLL = new RegionBLL();
            var region = regionBLL.GetAll();
            gvRegion.DataSource = region;

        }

        private void DeleteRegion(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete this Region?", "Delete Region", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                var regionBLL = new RegionBLL();
                regionBLL.Delete(id);
                LoadRegion();
            }

        }


    }
}
