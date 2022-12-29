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
    public partial class frmTerritory : Form
    {
        private int territoryId;

        public frmTerritory()
        {
            InitializeComponent();
        }

        private void LoadRegion()
        {

            RegionBLL regionBLL = new RegionBLL();
            List<Region> regions = regionBLL.GetAll();   // calls getall method
            
            cboRegion.DataSource = regions;
            cboRegion.ValueMember = "Id";                 //combobox a id value assign kora
            cboRegion.DisplayMember = "Description";


        }

      private void LoadTerritory()
        {
            TerritoryBLL territoryBLL = new TerritoryBLL();
            List<Territory> territory = territoryBLL.GetAll();     //List of territory, this cls  comes from get all DLL
            gvTerritory.DataSource = territory;
        }


        private void frmTerritory_Load(object sender, EventArgs e)
        {
            LoadRegion();
            LoadTerritory();
        }

        private void gvTerritory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }


        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                territoryId = Convert.ToInt32(gvTerritory.Rows[e.RowIndex].Cells[0].Value);  // here field = territoryId
                txtTerritory.Text = Convert.ToString(gvTerritory.Rows[e.RowIndex].Cells[1].Value);
                cboRegion.SelectedValue = Convert.ToInt32(gvTerritory.Rows[e.RowIndex].Cells[2].Value);

            }
            else if (e.ColumnIndex == 6)
            {
                var id = Convert.ToInt32(gvTerritory.Rows[e.RowIndex].Cells[0].Value);
                DeleteTerritory(id);
            }
        }
            private void DeleteTerritory(int id)
            {
                if (MessageBox.Show("Are you sure you want to delete this Categories?", "Delete Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    var territoryBLL = new TerritoryBLL();
                    territoryBLL.Delete(id);
                    LoadTerritory();
                }

            }

        private void ClearField()
        {
            
            txtTerritory.Text = string.Empty;
            cboRegion.SelectedValue = string.Empty;
            territoryId = 0;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTerritory();
        }

        private void SaveTerritory()
        {
            if (IsFormValid())
            {
                Territory territory = new Territory();   //Territory class er instance territory
                territory.Id = territoryId;              //territoryId field int type return kore
                territory.RegionId = Convert.ToInt32(cboRegion.SelectedValue);
                territory.Description = txtTerritory.Text;
                
                var territoryBLL = new TerritoryBLL();
                territoryBLL.Save(territory);

                LoadTerritory();
                ClearField();
            }
        }



        private Boolean IsFormValid()
        {
            epTerritory.Clear();
            Boolean iv = true;

            if (txtTerritory.Text == string.Empty)
            {
                txtTerritory.Focus();
                epTerritory.SetError(txtTerritory, "Can't empty");
                iv = false;
            }

            return iv;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void gvTerritory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gvTerritory.Rows)
            {
                //row.HeaderCell.Value = row.Cells[0].Value.ToString();
            }
        }
    }

    }

