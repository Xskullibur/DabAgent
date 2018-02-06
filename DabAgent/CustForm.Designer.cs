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
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label nRICLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustForm));
            this.customerBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.customerBS = new System.Windows.Forms.BindingSource(this.components);
            this.dabAgencyDS = new DabAgent.DabAgencyDataSet();
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
            this.customerTA = new DabAgent.DabAgencyDataSetTableAdapters.CustomerTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            countryLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            nRICLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBN)).BeginInit();
            this.customerBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabAgencyDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(25, 378);
            countryLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(122, 32);
            countryLabel.TabIndex = 26;
            countryLabel.Text = "Country:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(25, 318);
            date_of_BirthLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(180, 32);
            date_of_BirthLabel.TabIndex = 24;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // nRICLabel
            // 
            nRICLabel.AutoSize = true;
            nRICLabel.Location = new System.Drawing.Point(25, 68);
            nRICLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(90, 32);
            nRICLabel.TabIndex = 16;
            nRICLabel.Text = "NRIC:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(25, 192);
            contactLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(121, 32);
            contactLabel.TabIndex = 20;
            contactLabel.Text = "Contact:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(25, 254);
            addressLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(127, 32);
            addressLabel.TabIndex = 22;
            addressLabel.Text = "Address:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(25, 130);
            nameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(98, 32);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Name:";
            // 
            // customerBN
            // 
            this.customerBN.AddNewItem = null;
            this.customerBN.BackColor = System.Drawing.Color.Transparent;
            this.customerBN.BindingSource = this.customerBS;
            this.customerBN.CountItem = this.bindingNavigatorCountItem;
            this.customerBN.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBN.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.customerBN.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.customerBN.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBN.Size = new System.Drawing.Size(1412, 47);
            this.customerBN.TabIndex = 0;
            this.customerBN.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(87, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.Window;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(127, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // customerTBBindingNavigatorSaveItem
            // 
            this.customerTBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerTBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerTBBindingNavigatorSaveItem.Image")));
            this.customerTBBindingNavigatorSaveItem.Name = "customerTBBindingNavigatorSaveItem";
            this.customerTBBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 44);
            this.customerTBBindingNavigatorSaveItem.Text = "Save Data";
            this.customerTBBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerTBBindingNavigatorSaveItem_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnViewAll);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(780, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(553, 279);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 126);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 54);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(340, 56);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(199, 54);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 62);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 38);
            this.txtSearch.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nRICTextBox);
            this.groupBox2.Controls.Add(this.countryTextBox);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(countryLabel);
            this.groupBox2.Controls.Add(this.date_of_BirthDateTimePicker);
            this.groupBox2.Controls.Add(date_of_BirthLabel);
            this.groupBox2.Controls.Add(nRICLabel);
            this.groupBox2.Controls.Add(contactLabel);
            this.groupBox2.Controls.Add(this.addressTextBox);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(addressLabel);
            this.groupBox2.Controls.Add(this.contactTextBox);
            this.groupBox2.Controls.Add(nameLabel);
            this.groupBox2.Location = new System.Drawing.Point(21, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(748, 507);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Info";
            // 
            // nRICTextBox
            // 
            this.nRICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "NRIC", true));
            this.nRICTextBox.Location = new System.Drawing.Point(224, 60);
            this.nRICTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.Size = new System.Drawing.Size(488, 38);
            this.nRICTextBox.TabIndex = 17;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(224, 370);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(488, 38);
            this.countryTextBox.TabIndex = 27;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(434, 426);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(281, 57);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBS, "Date of Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(224, 308);
            this.date_of_BirthDateTimePicker.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(488, 38);
            this.date_of_BirthDateTimePicker.TabIndex = 25;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(224, 246);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(488, 38);
            this.addressTextBox.TabIndex = 23;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(224, 122);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(488, 38);
            this.nameTextBox.TabIndex = 19;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(224, 184);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(488, 38);
            this.contactTextBox.TabIndex = 21;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(12, 126);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(199, 54);
            this.btnViewAll.TabIndex = 20;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // CustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1412, 626);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerBN);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Main";
            this.Load += new System.EventHandler(this.CustForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBN)).EndInit();
            this.customerBN.ResumeLayout(false);
            this.customerBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabAgencyDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nRICTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Button btnViewAll;
    }
}