namespace DabAgent
{
    partial class BookingDisplay
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
            System.Windows.Forms.Label bookingIDLabel;
            System.Windows.Forms.Label nRICLabel;
            System.Windows.Forms.Label paxLabel;
            System.Windows.Forms.Label costPxLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDisplay));
            System.Windows.Forms.Label travelDateLabel;
            System.Windows.Forms.Label departureLabel;
            System.Windows.Forms.Label arrivalLabel;
            System.Windows.Forms.Label nameLabel;
            this.bookingTBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookingIDTextBox = new System.Windows.Forms.TextBox();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.paxTextBox = new System.Windows.Forms.TextBox();
            this.costPxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.travelDateTextBox = new System.Windows.Forms.TextBox();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTextBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ds = new DabAgent.DabAgencyDataSet();
            this.bsBooking = new System.Windows.Forms.BindingSource(this.components);
            this.taBooking = new DabAgent.DabAgencyDataSetTableAdapters.BookingTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.customerTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTBTableAdapter = new DabAgent.DabAgencyDataSetTableAdapters.CustomerTBTableAdapter();
            bookingIDLabel = new System.Windows.Forms.Label();
            nRICLabel = new System.Windows.Forms.Label();
            paxLabel = new System.Windows.Forms.Label();
            costPxLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            travelDateLabel = new System.Windows.Forms.Label();
            departureLabel = new System.Windows.Forms.Label();
            arrivalLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBBindingNavigator)).BeginInit();
            this.bookingTBBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingIDLabel
            // 
            bookingIDLabel.AutoSize = true;
            bookingIDLabel.Location = new System.Drawing.Point(33, 92);
            bookingIDLabel.Name = "bookingIDLabel";
            bookingIDLabel.Size = new System.Drawing.Size(92, 20);
            bookingIDLabel.TabIndex = 1;
            bookingIDLabel.Text = "Booking ID:";
            // 
            // nRICLabel
            // 
            nRICLabel.AutoSize = true;
            nRICLabel.Location = new System.Drawing.Point(33, 156);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(52, 20);
            nRICLabel.TabIndex = 3;
            nRICLabel.Text = "NRIC:";
            // 
            // paxLabel
            // 
            paxLabel.AutoSize = true;
            paxLabel.Location = new System.Drawing.Point(33, 216);
            paxLabel.Name = "paxLabel";
            paxLabel.Size = new System.Drawing.Size(39, 20);
            paxLabel.TabIndex = 7;
            paxLabel.Text = "Pax:";
            // 
            // costPxLabel
            // 
            costPxLabel.AutoSize = true;
            costPxLabel.Location = new System.Drawing.Point(33, 252);
            costPxLabel.Name = "costPxLabel";
            costPxLabel.Size = new System.Drawing.Size(67, 20);
            costPxLabel.TabIndex = 9;
            costPxLabel.Text = "Cost Px:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 352);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 20);
            label1.TabIndex = 15;
            label1.Text = "Total Cost:";
            // 
            // bookingTBBindingNavigator
            // 
            this.bookingTBBindingNavigator.AddNewItem = null;
            this.bookingTBBindingNavigator.BindingSource = this.bsBooking;
            this.bookingTBBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookingTBBindingNavigator.DeleteItem = null;
            this.bookingTBBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bookingTBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bookingTBBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookingTBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookingTBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookingTBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookingTBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookingTBBindingNavigator.Name = "bookingTBBindingNavigator";
            this.bookingTBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookingTBBindingNavigator.Size = new System.Drawing.Size(367, 31);
            this.bookingTBBindingNavigator.TabIndex = 0;
            this.bookingTBBindingNavigator.Text = "bindingNavigator1";
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
            // bookingIDTextBox
            // 
            this.bookingIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "BookingID", true));
            this.bookingIDTextBox.Location = new System.Drawing.Point(133, 89);
            this.bookingIDTextBox.Name = "bookingIDTextBox";
            this.bookingIDTextBox.ReadOnly = true;
            this.bookingIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.bookingIDTextBox.TabIndex = 2;
            // 
            // nRICTextBox
            // 
            this.nRICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "NRIC", true));
            this.nRICTextBox.Location = new System.Drawing.Point(133, 153);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.ReadOnly = true;
            this.nRICTextBox.Size = new System.Drawing.Size(200, 26);
            this.nRICTextBox.TabIndex = 4;
            // 
            // paxTextBox
            // 
            this.paxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Pax", true));
            this.paxTextBox.Location = new System.Drawing.Point(133, 217);
            this.paxTextBox.Name = "paxTextBox";
            this.paxTextBox.ReadOnly = true;
            this.paxTextBox.Size = new System.Drawing.Size(200, 26);
            this.paxTextBox.TabIndex = 8;
            // 
            // costPxTextBox
            // 
            this.costPxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "CostPx", true));
            this.costPxTextBox.Location = new System.Drawing.Point(133, 249);
            this.costPxTextBox.Name = "costPxTextBox";
            this.costPxTextBox.ReadOnly = true;
            this.costPxTextBox.Size = new System.Drawing.Size(200, 26);
            this.costPxTextBox.TabIndex = 10;
            // 
            // TotalTxt
            // 
            this.TotalTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "CostPx", true));
            this.TotalTxt.Location = new System.Drawing.Point(133, 349);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(200, 26);
            this.TotalTxt.TabIndex = 16;
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.NameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLbl.Location = new System.Drawing.Point(0, 31);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(367, 38);
            this.NameLbl.TabIndex = 17;
            this.NameLbl.Text = "Customer Name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // travelDateLabel
            // 
            travelDateLabel.AutoSize = true;
            travelDateLabel.Location = new System.Drawing.Point(33, 188);
            travelDateLabel.Name = "travelDateLabel";
            travelDateLabel.Size = new System.Drawing.Size(94, 20);
            travelDateLabel.TabIndex = 17;
            travelDateLabel.Text = "Travel Date:";
            // 
            // travelDateTextBox
            // 
            this.travelDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "TravelDate", true));
            this.travelDateTextBox.Location = new System.Drawing.Point(133, 185);
            this.travelDateTextBox.Name = "travelDateTextBox";
            this.travelDateTextBox.ReadOnly = true;
            this.travelDateTextBox.Size = new System.Drawing.Size(200, 26);
            this.travelDateTextBox.TabIndex = 18;
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Location = new System.Drawing.Point(33, 284);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new System.Drawing.Size(85, 20);
            departureLabel.TabIndex = 18;
            departureLabel.Text = "Departure:";
            // 
            // departureTextBox
            // 
            this.departureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Departure", true));
            this.departureTextBox.Location = new System.Drawing.Point(133, 281);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.ReadOnly = true;
            this.departureTextBox.Size = new System.Drawing.Size(200, 26);
            this.departureTextBox.TabIndex = 19;
            // 
            // arrivalLabel
            // 
            arrivalLabel.AutoSize = true;
            arrivalLabel.Location = new System.Drawing.Point(33, 320);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new System.Drawing.Size(56, 20);
            arrivalLabel.TabIndex = 19;
            arrivalLabel.Text = "Arrival:";
            // 
            // arrivalTextBox
            // 
            this.arrivalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Arrival", true));
            this.arrivalTextBox.Location = new System.Drawing.Point(133, 317);
            this.arrivalTextBox.Name = "arrivalTextBox";
            this.arrivalTextBox.ReadOnly = true;
            this.arrivalTextBox.Size = new System.Drawing.Size(200, 26);
            this.arrivalTextBox.TabIndex = 20;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Location = new System.Drawing.Point(0, 440);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(367, 52);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(34, 124);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(133, 121);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 22;
            // 
            // ds
            // 
            this.ds.DataSetName = "DabAgencyDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsBooking
            // 
            this.bsBooking.DataMember = "BookingTB";
            this.bsBooking.DataSource = this.ds;
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // tam
            // 
            this.tam.BackupDataSetBeforeUpdate = false;
            this.tam.BookingTBTableAdapter = this.taBooking;
            this.tam.CustomerTBTableAdapter = null;
            this.tam.HolidayTBTableAdapter = null;
            this.tam.UpdateOrder = DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTBBindingSource
            // 
            this.customerTBBindingSource.DataMember = "CustomerTB";
            this.customerTBBindingSource.DataSource = this.ds;
            // 
            // customerTBTableAdapter
            // 
            this.customerTBTableAdapter.ClearBeforeFill = true;
            // 
            // BookingDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 492);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(arrivalLabel);
            this.Controls.Add(this.arrivalTextBox);
            this.Controls.Add(departureLabel);
            this.Controls.Add(this.departureTextBox);
            this.Controls.Add(travelDateLabel);
            this.Controls.Add(this.travelDateTextBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(label1);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(bookingIDLabel);
            this.Controls.Add(this.bookingIDTextBox);
            this.Controls.Add(nRICLabel);
            this.Controls.Add(this.nRICTextBox);
            this.Controls.Add(paxLabel);
            this.Controls.Add(this.paxTextBox);
            this.Controls.Add(costPxLabel);
            this.Controls.Add(this.costPxTextBox);
            this.Controls.Add(this.bookingTBBindingNavigator);
            this.Name = "BookingDisplay";
            this.Text = "BookingDisplay";
            this.Load += new System.EventHandler(this.BookingDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBBindingNavigator)).EndInit();
            this.bookingTBBindingNavigator.ResumeLayout(false);
            this.bookingTBBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DabAgencyDataSet ds;
        private System.Windows.Forms.BindingSource bsBooking;
        private DabAgencyDataSetTableAdapters.BookingTBTableAdapter taBooking;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.BindingNavigator bookingTBBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox bookingIDTextBox;
        private System.Windows.Forms.TextBox nRICTextBox;
        private System.Windows.Forms.TextBox paxTextBox;
        private System.Windows.Forms.TextBox costPxTextBox;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox travelDateTextBox;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.TextBox arrivalTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource customerTBBindingSource;
        private DabAgencyDataSetTableAdapters.CustomerTBTableAdapter customerTBTableAdapter;
    }
}