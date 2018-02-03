namespace DabAgent
{
    partial class CustForm
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
            System.Windows.Forms.Label nRICLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label countryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustForm));
            this.customerBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerTBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.customerBS = new System.Windows.Forms.BindingSource(this.components);
            this.dabAgencyDS = new DabAgent.DabAgencyDataSet();
            this.customerTA = new DabAgent.DabAgencyDataSetTableAdapters.CustomerTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.btnView = new System.Windows.Forms.Button();
            nRICLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBN)).BeginInit();
            this.customerBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabAgencyDS)).BeginInit();
            this.SuspendLayout();
            // 
            // nRICLabel
            // 
            nRICLabel.AutoSize = true;
            nRICLabel.Location = new System.Drawing.Point(12, 44);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(36, 13);
            nRICLabel.TabIndex = 1;
            nRICLabel.Text = "NRIC:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(12, 96);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(47, 13);
            contactLabel.TabIndex = 5;
            contactLabel.Text = "Contact:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 122);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(12, 149);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 9;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(12, 174);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 11;
            countryLabel.Text = "Country:";
            // 
            // customerBN
            // 
            this.customerBN.AddNewItem = null;
            this.customerBN.BindingSource = this.customerBS;
            this.customerBN.CountItem = this.bindingNavigatorCountItem;
            this.customerBN.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.customerTBBindingNavigatorSaveItem});
            this.customerBN.Location = new System.Drawing.Point(0, 0);
            this.customerBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBN.Name = "customerBN";
            this.customerBN.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBN.Size = new System.Drawing.Size(574, 25);
            this.customerBN.TabIndex = 0;
            this.customerBN.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customerTBBindingNavigatorSaveItem
            // 
            this.customerTBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerTBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerTBBindingNavigatorSaveItem.Image")));
            this.customerTBBindingNavigatorSaveItem.Name = "customerTBBindingNavigatorSaveItem";
            this.customerTBBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerTBBindingNavigatorSaveItem.Text = "Save Data";
            this.customerTBBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerTBBindingNavigatorSaveItem_Click);
            // 
            // nRICTextBox
            // 
            this.nRICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "NRIC", true));
            this.nRICTextBox.Location = new System.Drawing.Point(87, 41);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.Size = new System.Drawing.Size(200, 20);
            this.nRICTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(87, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(87, 93);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(87, 119);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBS, "Date of Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(87, 145);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 10;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(87, 171);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(338, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(487, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(338, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 46);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update/Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(470, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 46);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // customerBS
            // 
            this.customerBS.DataMember = "CustomerTB";
            this.customerBS.DataSource = this.dabAgencyDS;
            // 
            // dabAgencyDS
            // 
            this.dabAgencyDS.DataSetName = "DabAgencyDataSet";
            this.dabAgencyDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTA
            // 
            this.customerTA.ClearBeforeFill = true;
            // 
            // tam
            // 
            this.tam.BackupDataSetBeforeUpdate = false;
            this.tam.BookingTBTableAdapter = null;
            this.tam.CustomerTBTableAdapter = this.customerTA;
            this.tam.HolidayTBTableAdapter = null;
            this.tam.UpdateOrder = DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(15, 242);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // CustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 317);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(nRICLabel);
            this.Controls.Add(this.nRICTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthDateTimePicker);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.customerBN);
            this.Name = "CustForm";
            this.Text = "CustForm";
            this.Load += new System.EventHandler(this.CustForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBN)).EndInit();
            this.customerBN.ResumeLayout(false);
            this.customerBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabAgencyDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DabAgencyDataSet dabAgencyDS;
        private System.Windows.Forms.BindingSource customerBS;
        private DabAgencyDataSetTableAdapters.CustomerTBTableAdapter customerTA;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.BindingNavigator customerBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerTBBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nRICTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
    }
}