using MyApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Inventory.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmProduct p = new frmProduct();
            //p.ShowDialog();
            CloseAllForms();
            frmProduct myForm = new frmProduct();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCustomer frmCustomer = new frmCustomer();
            //frmCustomer.ShowDialog();

            CloseAllForms();
            frmCustomer myForm = new frmCustomer();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSupplier frmSupplier = new frmSupplier();
            //frmSupplier.ShowDialog();
            CloseAllForms();
            frmSupplier myForm = new frmSupplier();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCategories frmCategories = new frmCategories();
            //frmCategories.ShowDialog();
            CloseAllForms();
            frmCategories myForm = new frmCategories();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRegion frmRegion = new frmRegion();
            //frmRegion.ShowDialog();
            CloseAllForms();
            frmRegion myForm = new frmRegion();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        private void territoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTerritory frmTerritory = new frmTerritory();
            //frmTerritory.ShowDialog();
            frmTerritory myForm = new frmTerritory();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.pForm.Controls.Add(myForm);
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();

        }

        private void CloseAllForms()
        {
            Control.ControlCollection ctrls = this.pForm.Controls;
            foreach (Control ct in ctrls)
            {
                Form f = ct as Form;
                f.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShipper frmShipper = new frmShipper();
            frmShipper.ShowDialog();
        }
    }
}
