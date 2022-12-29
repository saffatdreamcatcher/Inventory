namespace Inventory.UI
{
    partial class frmTerritory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.lbRegion = new System.Windows.Forms.Label();
            this.txtTerritory = new System.Windows.Forms.TextBox();
            this.lbTerritoryDes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gvTerritory = new System.Windows.Forms.DataGridView();
            this.territoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epTerritory = new System.Windows.Forms.ErrorProvider(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isNewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvTerritory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTerritory)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(306, 29);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 24);
            this.cboRegion.TabIndex = 0;
            // 
            // lbRegion
            // 
            this.lbRegion.AutoSize = true;
            this.lbRegion.Location = new System.Drawing.Point(210, 32);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(51, 16);
            this.lbRegion.TabIndex = 1;
            this.lbRegion.Text = "Region";
            // 
            // txtTerritory
            // 
            this.txtTerritory.Location = new System.Drawing.Point(306, 84);
            this.txtTerritory.Name = "txtTerritory";
            this.txtTerritory.Size = new System.Drawing.Size(159, 22);
            this.txtTerritory.TabIndex = 2;
            // 
            // lbTerritoryDes
            // 
            this.lbTerritoryDes.AutoSize = true;
            this.lbTerritoryDes.Location = new System.Drawing.Point(163, 90);
            this.lbTerritoryDes.Name = "lbTerritoryDes";
            this.lbTerritoryDes.Size = new System.Drawing.Size(128, 16);
            this.lbTerritoryDes.TabIndex = 3;
            this.lbTerritoryDes.Text = "Territory Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(352, 148);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gvTerritory
            // 
            this.gvTerritory.AutoGenerateColumns = false;
            this.gvTerritory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTerritory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.regionIdDataGridViewTextBoxColumn,
            this.isNewDataGridViewCheckBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.gvTerritory.DataSource = this.territoryBindingSource;
            this.gvTerritory.Location = new System.Drawing.Point(12, 214);
            this.gvTerritory.Name = "gvTerritory";
            this.gvTerritory.RowHeadersWidth = 51;
            this.gvTerritory.RowTemplate.Height = 24;
            this.gvTerritory.Size = new System.Drawing.Size(690, 157);
            this.gvTerritory.TabIndex = 6;
            this.gvTerritory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTerritory_CellClick);
            this.gvTerritory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvTerritory_DataBindingComplete);
            // 
            // territoryBindingSource
            // 
            this.territoryBindingSource.DataSource = typeof(Inventory.DLL.Entities.Territory);
            // 
            // epTerritory
            // 
            this.epTerritory.ContainerControl = this;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // regionIdDataGridViewTextBoxColumn
            // 
            this.regionIdDataGridViewTextBoxColumn.DataPropertyName = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.HeaderText = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionIdDataGridViewTextBoxColumn.Name = "regionIdDataGridViewTextBoxColumn";
            this.regionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // isNewDataGridViewCheckBoxColumn
            // 
            this.isNewDataGridViewCheckBoxColumn.DataPropertyName = "IsNew";
            this.isNewDataGridViewCheckBoxColumn.HeaderText = "IsNew";
            this.isNewDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isNewDataGridViewCheckBoxColumn.Name = "isNewDataGridViewCheckBoxColumn";
            this.isNewDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isNewDataGridViewCheckBoxColumn.Visible = false;
            this.isNewDataGridViewCheckBoxColumn.Width = 125;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Visible = false;
            this.createTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.Width = 125;
            // 
            // frmTerritory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.gvTerritory);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTerritoryDes);
            this.Controls.Add(this.txtTerritory);
            this.Controls.Add(this.lbRegion);
            this.Controls.Add(this.cboRegion);
            this.Name = "frmTerritory";
            this.Text = "frmTerritory";
            this.Load += new System.EventHandler(this.frmTerritory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTerritory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTerritory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label lbRegion;
        private System.Windows.Forms.TextBox txtTerritory;
        private System.Windows.Forms.Label lbTerritoryDes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView gvTerritory;
        private System.Windows.Forms.ErrorProvider epTerritory;
        private System.Windows.Forms.BindingSource territoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}