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

        private void gvShipper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cn = "CompanyName LIKE '%" + txtsearch.Text + "%'";
            ShipperBLL shu = new ShipperBLL();
            List<Shipper> shippers = shu.GetAll(cn); 
            gvShipper.DataSource = shippers;


        }
    }
}