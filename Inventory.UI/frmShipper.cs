using Inventory.BLL.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DLL.Entities;

namespace Inventory.UI
{
    public partial class frmShipper : Form
    {
        private int id = 0;
        public frmShipper()
        {
            InitializeComponent();
        }

        private void frmShipper_Load(object sender, EventArgs e)
        {
            LoadShipper();
        }

        private void LoadShipper()
        {
            gvShipper.AutoGenerateColumns = false;
            ShipperBLL shipperBLL = new ShipperBLL();
            List<Shipper> shipper = shipperBLL.GetAll();
            gvShipper.DataSource = shipper;

        }

        private void ClearField()
        {
            txtCompanyName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            
        }


        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                id = Convert.ToInt32(gvShipper.Rows[e.RowIndex].Cells[0].Value);
                txtCompanyName.Text = Convert.ToString(gvShipper.Rows[e.RowIndex].Cells[2].Value);
                txtPhone.Text = Convert.ToString(gvShipper.Rows[e.RowIndex].Cells[3].Value);
            }
            else if (e.ColumnIndex == 6)
            {
                var id = Convert.ToInt32(gvShipper.Rows[e.RowIndex].Cells[0].Value);
                DeleteShipper(id);
            }
        }

        private Boolean IsFormValid()
        {
            epShipper.Clear();
            Boolean iv = true;

            if (txtCompanyName.Text == string.Empty)
            {
                txtCompanyName.Focus();
                epShipper.SetError(txtCompanyName, "Can't empty");
                iv = false;
            }


            return iv;
        }

        private void SaveShipper()
        {
            if (IsFormValid())
            {
                Shipper shipper = new Shipper();
                //shipper.Id = shipperId;
                shipper.CompanyName = txtCompanyName.Text;
                shipper.Phone = txtPhone.Text;
                var shipperBLL = new ShipperBLL();
                shipperBLL.Save(shipper);


                LoadShipper();
                ClearField();
            }
        }


        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string cn = "CompanyName LIKE '%" + txtsearch.Text + "%'";
           
            string cn = "";
            if (txtsearch.Text != "")
            {
              cn += "CompanyName LIKE '%" + txtsearch.Text + "%'";

            }

            if (txtPhoneS.Text != "")
            {
                if (cn != string.Empty)
                    cn = cn + " AND ";
                cn += "Phone LIKE '%" + txtPhoneS.Text + "%'";

            }
            ShipperBLL shu = new ShipperBLL();
            List<Shipper> shippers = shu.GetAll(cn);
            gvShipper.DataSource = shippers;


        }
        private void DeleteShipper(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete the shipper?", "Delete Shipper", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                var shipperBLL = new ShipperBLL();
                shipperBLL.Delete(id);
                LoadShipper();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveShipper();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvShipper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }
    }
}