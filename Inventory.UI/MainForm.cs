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
      form1 p = new form1();
      p.ShowDialog();
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
      frmSupplier frmSupplier = new frmSupplier();
      frmSupplier.ShowDialog();
    }

    private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmCategories frmCategories = new frmCategories();
      frmCategories.ShowDialog();
    }

    private void regionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmRegion frmRegion = new frmRegion();
      frmRegion.ShowDialog();
    }

    private void territoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmTerritory frmTerritory = new frmTerritory();
      frmTerritory.ShowDialog();

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
  }
}
