namespace Inventory.UI
{
    partial class frmSupplier
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
      this.resetbtn = new System.Windows.Forms.Button();
      this.txtCountry = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPostalCode = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtCity = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.Address = new System.Windows.Forms.Label();
      this.txtContact = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtName2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtRegion = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtContactTitle = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtHomePage = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txtFax = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.gvSupplier = new System.Windows.Forms.DataGridView();
      this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.epSupplier = new System.Windows.Forms.ErrorProvider(this.components);
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isNewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contacttitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.homePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
      this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epSupplier)).BeginInit();
      this.SuspendLayout();
      // 
      // resetbtn
      // 
      this.resetbtn.Location = new System.Drawing.Point(609, 151);
      this.resetbtn.Name = "resetbtn";
      this.resetbtn.Size = new System.Drawing.Size(85, 28);
      this.resetbtn.TabIndex = 28;
      this.resetbtn.Text = "Reset";
      this.resetbtn.UseVisualStyleBackColor = true;
      this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
      // 
      // txtCountry
      // 
      this.txtCountry.Location = new System.Drawing.Point(372, 106);
      this.txtCountry.Name = "txtCountry";
      this.txtCountry.Size = new System.Drawing.Size(175, 22);
      this.txtCountry.TabIndex = 27;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(306, 112);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 17);
      this.label4.TabIndex = 26;
      this.label4.Text = "Country";
      // 
      // txtPostalCode
      // 
      this.txtPostalCode.Location = new System.Drawing.Point(672, 31);
      this.txtPostalCode.Name = "txtPostalCode";
      this.txtPostalCode.Size = new System.Drawing.Size(183, 22);
      this.txtPostalCode.TabIndex = 25;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(580, 34);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 17);
      this.label5.TabIndex = 24;
      this.label5.Text = "PostalCode";
      // 
      // txtCity
      // 
      this.txtCity.Location = new System.Drawing.Point(372, 72);
      this.txtCity.Name = "txtCity";
      this.txtCity.Size = new System.Drawing.Size(175, 22);
      this.txtCity.TabIndex = 23;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(329, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 17);
      this.label3.TabIndex = 22;
      this.label3.Text = "City";
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(364, 34);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(183, 22);
      this.txtAddress.TabIndex = 21;
      // 
      // Address
      // 
      this.Address.AutoSize = true;
      this.Address.Location = new System.Drawing.Point(300, 37);
      this.Address.Name = "Address";
      this.Address.Size = new System.Drawing.Size(60, 17);
      this.Address.TabIndex = 20;
      this.Address.Text = "Address";
      // 
      // txtContact
      // 
      this.txtContact.Location = new System.Drawing.Point(89, 72);
      this.txtContact.Name = "txtContact";
      this.txtContact.Size = new System.Drawing.Size(175, 22);
      this.txtContact.TabIndex = 19;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(31, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 17);
      this.label2.TabIndex = 18;
      this.label2.Text = "Contact";
      // 
      // txtName2
      // 
      this.txtName2.Location = new System.Drawing.Point(81, 34);
      this.txtName2.Name = "txtName2";
      this.txtName2.Size = new System.Drawing.Size(183, 22);
      this.txtName2.TabIndex = 17;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(28, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 17);
      this.label1.TabIndex = 16;
      this.label1.Text = " Name";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(485, 151);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(84, 28);
      this.btnSave.TabIndex = 15;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtRegion
      // 
      this.txtRegion.Location = new System.Drawing.Point(672, 66);
      this.txtRegion.Name = "txtRegion";
      this.txtRegion.Size = new System.Drawing.Size(175, 22);
      this.txtRegion.TabIndex = 32;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(607, 66);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 17);
      this.label6.TabIndex = 31;
      this.label6.Text = "Region";
      // 
      // txtContactTitle
      // 
      this.txtContactTitle.Location = new System.Drawing.Point(96, 106);
      this.txtContactTitle.Name = "txtContactTitle";
      this.txtContactTitle.Size = new System.Drawing.Size(179, 22);
      this.txtContactTitle.TabIndex = 34;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 112);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(83, 17);
      this.label7.TabIndex = 33;
      this.label7.Text = "ContactTitle";
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(672, 106);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(175, 22);
      this.txtPhone.TabIndex = 36;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(606, 112);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(49, 17);
      this.label8.TabIndex = 35;
      this.label8.Text = "Phone";
      // 
      // txtHomePage
      // 
      this.txtHomePage.Location = new System.Drawing.Point(981, 77);
      this.txtHomePage.Name = "txtHomePage";
      this.txtHomePage.Size = new System.Drawing.Size(175, 22);
      this.txtHomePage.TabIndex = 40;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(887, 83);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(78, 17);
      this.label9.TabIndex = 39;
      this.label9.Text = "HomePage";
      // 
      // txtFax
      // 
      this.txtFax.Location = new System.Drawing.Point(981, 37);
      this.txtFax.Name = "txtFax";
      this.txtFax.Size = new System.Drawing.Size(175, 22);
      this.txtFax.TabIndex = 38;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(916, 37);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(30, 17);
      this.label10.TabIndex = 37;
      this.label10.Text = "Fax";
      // 
      // gvSupplier
      // 
      this.gvSupplier.AutoGenerateColumns = false;
      this.gvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isNewDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.contacttitleDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.homePageDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
      this.gvSupplier.DataSource = this.supplierBindingSource;
      this.gvSupplier.Location = new System.Drawing.Point(12, 202);
      this.gvSupplier.Name = "gvSupplier";
      this.gvSupplier.RowHeadersWidth = 51;
      this.gvSupplier.RowTemplate.Height = 24;
      this.gvSupplier.Size = new System.Drawing.Size(1174, 198);
      this.gvSupplier.TabIndex = 41;
      this.gvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSupplier_CellClick);
      this.gvSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSupplier_CellContentClick);
      // 
      // supplierBindingSource
      // 
      this.supplierBindingSource.DataSource = typeof(Inventory.DLL.Entities.Supplier);
      // 
      // epSupplier
      // 
      this.epSupplier.ContainerControl = this;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.Visible = false;
      this.idDataGridViewTextBoxColumn.Width = 125;
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
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.Width = 125;
      // 
      // contactDataGridViewTextBoxColumn
      // 
      this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
      this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
      this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
      this.contactDataGridViewTextBoxColumn.Width = 125;
      // 
      // contacttitleDataGridViewTextBoxColumn
      // 
      this.contacttitleDataGridViewTextBoxColumn.DataPropertyName = "ContactTitle";
      this.contacttitleDataGridViewTextBoxColumn.HeaderText = "ContactTitle";
      this.contacttitleDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.contacttitleDataGridViewTextBoxColumn.Name = "contacttitleDataGridViewTextBoxColumn";
      this.contacttitleDataGridViewTextBoxColumn.Visible = false;
      this.contacttitleDataGridViewTextBoxColumn.Width = 125;
      // 
      // addressDataGridViewTextBoxColumn
      // 
      this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
      this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
      this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
      this.addressDataGridViewTextBoxColumn.Width = 125;
      // 
      // cityDataGridViewTextBoxColumn
      // 
      this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
      this.cityDataGridViewTextBoxColumn.HeaderText = "City";
      this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
      this.cityDataGridViewTextBoxColumn.Visible = false;
      this.cityDataGridViewTextBoxColumn.Width = 125;
      // 
      // postalCodeDataGridViewTextBoxColumn
      // 
      this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
      this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
      this.postalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
      this.postalCodeDataGridViewTextBoxColumn.Visible = false;
      this.postalCodeDataGridViewTextBoxColumn.Width = 125;
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
      // countryDataGridViewTextBoxColumn
      // 
      this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
      this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
      this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
      this.countryDataGridViewTextBoxColumn.Width = 125;
      // 
      // regionDataGridViewTextBoxColumn
      // 
      this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
      this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
      this.regionDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
      this.regionDataGridViewTextBoxColumn.Visible = false;
      this.regionDataGridViewTextBoxColumn.Width = 125;
      // 
      // phoneDataGridViewTextBoxColumn
      // 
      this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
      this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
      this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
      this.phoneDataGridViewTextBoxColumn.Visible = false;
      this.phoneDataGridViewTextBoxColumn.Width = 125;
      // 
      // faxDataGridViewTextBoxColumn
      // 
      this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
      this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
      this.faxDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
      this.faxDataGridViewTextBoxColumn.Visible = false;
      this.faxDataGridViewTextBoxColumn.Width = 125;
      // 
      // homePageDataGridViewTextBoxColumn
      // 
      this.homePageDataGridViewTextBoxColumn.DataPropertyName = "HomePage";
      this.homePageDataGridViewTextBoxColumn.HeaderText = "HomePage";
      this.homePageDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.homePageDataGridViewTextBoxColumn.Name = "homePageDataGridViewTextBoxColumn";
      this.homePageDataGridViewTextBoxColumn.Visible = false;
      this.homePageDataGridViewTextBoxColumn.Width = 125;
      // 
      // Edit
      // 
      this.Edit.HeaderText = "Edit";
      this.Edit.MinimumWidth = 6;
      this.Edit.Name = "Edit";
      this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.Edit.Text = "Edit";
      this.Edit.ToolTipText = "Edit";
      this.Edit.UseColumnTextForLinkValue = true;
      this.Edit.Width = 80;
      // 
      // Delete
      // 
      this.Delete.HeaderText = "Delete";
      this.Delete.MinimumWidth = 6;
      this.Delete.Name = "Delete";
      this.Delete.Text = "Delete";
      this.Delete.UseColumnTextForLinkValue = true;
      this.Delete.Width = 80;
      // 
      // frmSupplier
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1220, 450);
      this.Controls.Add(this.gvSupplier);
      this.Controls.Add(this.txtHomePage);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.txtFax);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txtContactTitle);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtRegion);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.resetbtn);
      this.Controls.Add(this.txtCountry);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtPostalCode);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtCity);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.Address);
      this.Controls.Add(this.txtContact);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtName2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSave);
      this.Name = "frmSupplier";
      this.Text = "Supplier";
      this.Load += new System.EventHandler(this.frmSupplier_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epSupplier)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHomePage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gvSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ErrorProvider epSupplier;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isNewDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn contacttitleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn homePageDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewLinkColumn Edit;
    private System.Windows.Forms.DataGridViewLinkColumn Delete;
  }
}