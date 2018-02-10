namespace DabAgent
{
    partial class EditDest
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
            System.Windows.Forms.Label holidayIDLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label costPxLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDest));
            this.ds = new DabAgent.DabAgencyDataSet();
            this.bsDest = new System.Windows.Forms.BindingSource(this.components);
            this.taDest = new DabAgent.DabAgencyDataSetTableAdapters.HolidayTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.holidayTBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.holidayTBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.holidayIDTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.costPxTextBox = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            holidayIDLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            costPxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayTBBindingNavigator)).BeginInit();
            this.holidayTBBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // holidayIDLabel
            // 
            holidayIDLabel.AutoSize = true;
            holidayIDLabel.BackColor = System.Drawing.Color.Transparent;
            holidayIDLabel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            holidayIDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            holidayIDLabel.Location = new System.Drawing.Point(42, 128);
            holidayIDLabel.Name = "holidayIDLabel";
            holidayIDLabel.Size = new System.Drawing.Size(98, 21);
            holidayIDLabel.TabIndex = 1;
            holidayIDLabel.Text = "Holiday ID:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.BackColor = System.Drawing.Color.Transparent;
            countryLabel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            countryLabel.Location = new System.Drawing.Point(42, 201);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(81, 21);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.Color.Transparent;
            cityLabel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            cityLabel.Location = new System.Drawing.Point(42, 274);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(46, 21);
            cityLabel.TabIndex = 5;
            cityLabel.Text = "City:";
            // 
            // costPxLabel
            // 
            costPxLabel.AutoSize = true;
            costPxLabel.BackColor = System.Drawing.Color.Transparent;
            costPxLabel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costPxLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            costPxLabel.Location = new System.Drawing.Point(42, 347);
            costPxLabel.Name = "costPxLabel";
            costPxLabel.Size = new System.Drawing.Size(74, 21);
            costPxLabel.TabIndex = 7;
            costPxLabel.Text = "Cost Px:";
            // 
            // ds
            // 
            this.ds.DataSetName = "DabAgencyDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsDest
            // 
            this.bsDest.DataMember = "HolidayTB";
            this.bsDest.DataSource = this.ds;
            // 
            // taDest
            // 
            this.taDest.ClearBeforeFill = true;
            // 
            // tam
            // 
            this.tam.BackupDataSetBeforeUpdate = false;
            this.tam.BookingTBTableAdapter = null;
            this.tam.CustomerTBTableAdapter = null;
            this.tam.HolidayTBTableAdapter = this.taDest;
            this.tam.UpdateOrder = DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // holidayTBBindingNavigator
            // 
            this.holidayTBBindingNavigator.AddNewItem = null;
            this.holidayTBBindingNavigator.BindingSource = this.bsDest;
            this.holidayTBBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.holidayTBBindingNavigator.DeleteItem = null;
            this.holidayTBBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.holidayTBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.holidayTBBindingNavigatorSaveItem});
            this.holidayTBBindingNavigator.Location = new System.Drawing.Point(0, 66);
            this.holidayTBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.holidayTBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.holidayTBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.holidayTBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.holidayTBBindingNavigator.Name = "holidayTBBindingNavigator";
            this.holidayTBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.holidayTBBindingNavigator.Size = new System.Drawing.Size(368, 31);
            this.holidayTBBindingNavigator.TabIndex = 0;
            this.holidayTBBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // holidayTBBindingNavigatorSaveItem
            // 
            this.holidayTBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.holidayTBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("holidayTBBindingNavigatorSaveItem.Image")));
            this.holidayTBBindingNavigatorSaveItem.Name = "holidayTBBindingNavigatorSaveItem";
            this.holidayTBBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.holidayTBBindingNavigatorSaveItem.Text = "Save Data";
            this.holidayTBBindingNavigatorSaveItem.Click += new System.EventHandler(this.holidayTBBindingNavigatorSaveItem_Click);
            // 
            // holidayIDTextBox
            // 
            this.holidayIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDest, "HolidayID", true));
            this.holidayIDTextBox.Location = new System.Drawing.Point(46, 152);
            this.holidayIDTextBox.Name = "holidayIDTextBox";
            this.holidayIDTextBox.Size = new System.Drawing.Size(267, 26);
            this.holidayIDTextBox.TabIndex = 2;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDest, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(46, 225);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(267, 26);
            this.countryTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDest, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(46, 298);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(267, 26);
            this.cityTextBox.TabIndex = 6;
            // 
            // costPxTextBox
            // 
            this.costPxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDest, "CostPx", true));
            this.costPxTextBox.Location = new System.Drawing.Point(46, 371);
            this.costPxTextBox.Name = "costPxTextBox";
            this.costPxTextBox.Size = new System.Drawing.Size(267, 26);
            this.costPxTextBox.TabIndex = 8;
            // 
            // TitleLbl
            // 
            this.TitleLbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TitleLbl.Location = new System.Drawing.Point(0, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(368, 66);
            this.TitleLbl.TabIndex = 9;
            this.TitleLbl.Text = "Edit Holiday Destinations";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Location = new System.Drawing.Point(183, 502);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(185, 58);
            this.ExitBtn.TabIndex = 19;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SaveBtn.Location = new System.Drawing.Point(0, 502);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(185, 58);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditDest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DabAgent.Properties.Resources.addBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 560);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(holidayIDLabel);
            this.Controls.Add(this.holidayIDTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(costPxLabel);
            this.Controls.Add(this.costPxTextBox);
            this.Controls.Add(this.holidayTBBindingNavigator);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditDest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayTBBindingNavigator)).EndInit();
            this.holidayTBBindingNavigator.ResumeLayout(false);
            this.holidayTBBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DabAgencyDataSet ds;
        private System.Windows.Forms.BindingSource bsDest;
        private DabAgencyDataSetTableAdapters.HolidayTBTableAdapter taDest;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.BindingNavigator holidayTBBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton holidayTBBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox holidayIDTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox costPxTextBox;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}