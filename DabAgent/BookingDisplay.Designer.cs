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
            System.Windows.Forms.Label arrivalLabel;
            System.Windows.Forms.Label departureLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label travelDateLabel;
            System.Windows.Forms.Label bookingIDLabel;
            System.Windows.Forms.Label nRICLabel;
            System.Windows.Forms.Label paxLabel;
            System.Windows.Forms.Label costPxLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDisplay));
            System.Windows.Forms.Label nRICLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label countryLabel;
            this.bsBooking = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new DabAgent.DabAgencyDataSet();
            this.customerTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taBooking = new DabAgent.DabAgencyDataSetTableAdapters.BookingTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.customerTBTableAdapter = new DabAgent.DabAgencyDataSetTableAdapters.CustomerTBTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.arrivalTextBox = new System.Windows.Forms.TextBox();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.travelDateTextBox = new System.Windows.Forms.TextBox();
            this.bookingIDTextBox = new System.Windows.Forms.TextBox();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.paxTextBox = new System.Windows.Forms.TextBox();
            this.costPxTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bookingTBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.nRICTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.CustomerbindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.DOBtxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            arrivalLabel = new System.Windows.Forms.Label();
            departureLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            travelDateLabel = new System.Windows.Forms.Label();
            bookingIDLabel = new System.Windows.Forms.Label();
            nRICLabel = new System.Windows.Forms.Label();
            paxLabel = new System.Windows.Forms.Label();
            costPxLabel = new System.Windows.Forms.Label();
            nRICLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBBindingNavigator)).BeginInit();
            this.bookingTBBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerbindingNavigator1)).BeginInit();
            this.CustomerbindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsBooking
            // 
            this.bsBooking.DataMember = "BookingTB";
            this.bsBooking.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DabAgencyDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTBBindingSource
            // 
            this.customerTBBindingSource.DataMember = "CustomerTB";
            this.customerTBBindingSource.DataSource = this.ds;
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
            // customerTBTableAdapter
            // 
            this.customerTBTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(arrivalLabel);
            this.tabPage1.Controls.Add(this.arrivalTextBox);
            this.tabPage1.Controls.Add(departureLabel);
            this.tabPage1.Controls.Add(this.departureTextBox);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.TotalTxt);
            this.tabPage1.Controls.Add(travelDateLabel);
            this.tabPage1.Controls.Add(this.travelDateTextBox);
            this.tabPage1.Controls.Add(bookingIDLabel);
            this.tabPage1.Controls.Add(this.bookingIDTextBox);
            this.tabPage1.Controls.Add(nRICLabel);
            this.tabPage1.Controls.Add(this.nRICTextBox);
            this.tabPage1.Controls.Add(paxLabel);
            this.tabPage1.Controls.Add(this.paxTextBox);
            this.tabPage1.Controls.Add(costPxLabel);
            this.tabPage1.Controls.Add(this.costPxTextBox);
            this.tabPage1.Controls.Add(this.bookingTBBindingNavigator);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Booking Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.DOBtxt);
            this.tabPage2.Controls.Add(this.CustomerbindingNavigator1);
            this.tabPage2.Controls.Add(nRICLabel1);
            this.tabPage2.Controls.Add(this.nRICTextBox1);
            this.tabPage2.Controls.Add(nameLabel);
            this.tabPage2.Controls.Add(this.nameTextBox);
            this.tabPage2.Controls.Add(contactLabel);
            this.tabPage2.Controls.Add(this.contactTextBox);
            this.tabPage2.Controls.Add(addressLabel);
            this.tabPage2.Controls.Add(this.addressTextBox);
            this.tabPage2.Controls.Add(date_of_BirthLabel);
            this.tabPage2.Controls.Add(countryLabel);
            this.tabPage2.Controls.Add(this.countryTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(360, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // arrivalLabel
            // 
            arrivalLabel.AutoSize = true;
            arrivalLabel.Location = new System.Drawing.Point(23, 327);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new System.Drawing.Size(56, 20);
            arrivalLabel.TabIndex = 38;
            arrivalLabel.Text = "Arrival:";
            // 
            // arrivalTextBox
            // 
            this.arrivalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Arrival", true));
            this.arrivalTextBox.Location = new System.Drawing.Point(123, 324);
            this.arrivalTextBox.Name = "arrivalTextBox";
            this.arrivalTextBox.ReadOnly = true;
            this.arrivalTextBox.Size = new System.Drawing.Size(200, 26);
            this.arrivalTextBox.TabIndex = 39;
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Location = new System.Drawing.Point(23, 282);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new System.Drawing.Size(85, 20);
            departureLabel.TabIndex = 35;
            departureLabel.Text = "Departure:";
            // 
            // departureTextBox
            // 
            this.departureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Departure", true));
            this.departureTextBox.Location = new System.Drawing.Point(123, 279);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.ReadOnly = true;
            this.departureTextBox.Size = new System.Drawing.Size(200, 26);
            this.departureTextBox.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 372);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 20);
            label1.TabIndex = 31;
            label1.Text = "Total Cost:";
            // 
            // TotalTxt
            // 
            this.TotalTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "CostPx", true));
            this.TotalTxt.Location = new System.Drawing.Point(123, 369);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(200, 26);
            this.TotalTxt.TabIndex = 32;
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
            // travelDateLabel
            // 
            travelDateLabel.AutoSize = true;
            travelDateLabel.Location = new System.Drawing.Point(23, 147);
            travelDateLabel.Name = "travelDateLabel";
            travelDateLabel.Size = new System.Drawing.Size(94, 20);
            travelDateLabel.TabIndex = 34;
            travelDateLabel.Text = "Travel Date:";
            // 
            // travelDateTextBox
            // 
            this.travelDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "TravelDate", true));
            this.travelDateTextBox.Location = new System.Drawing.Point(123, 144);
            this.travelDateTextBox.Name = "travelDateTextBox";
            this.travelDateTextBox.ReadOnly = true;
            this.travelDateTextBox.Size = new System.Drawing.Size(200, 26);
            this.travelDateTextBox.TabIndex = 36;
            // 
            // bookingIDLabel
            // 
            bookingIDLabel.AutoSize = true;
            bookingIDLabel.Location = new System.Drawing.Point(23, 57);
            bookingIDLabel.Name = "bookingIDLabel";
            bookingIDLabel.Size = new System.Drawing.Size(92, 20);
            bookingIDLabel.TabIndex = 23;
            bookingIDLabel.Text = "Booking ID:";
            // 
            // bookingIDTextBox
            // 
            this.bookingIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "BookingID", true));
            this.bookingIDTextBox.Location = new System.Drawing.Point(123, 54);
            this.bookingIDTextBox.Name = "bookingIDTextBox";
            this.bookingIDTextBox.ReadOnly = true;
            this.bookingIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.bookingIDTextBox.TabIndex = 24;
            // 
            // nRICLabel
            // 
            nRICLabel.AutoSize = true;
            nRICLabel.Location = new System.Drawing.Point(23, 102);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(52, 20);
            nRICLabel.TabIndex = 25;
            nRICLabel.Text = "NRIC:";
            // 
            // nRICTextBox
            // 
            this.nRICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "NRIC", true));
            this.nRICTextBox.Location = new System.Drawing.Point(123, 99);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.ReadOnly = true;
            this.nRICTextBox.Size = new System.Drawing.Size(200, 26);
            this.nRICTextBox.TabIndex = 26;
            // 
            // paxLabel
            // 
            paxLabel.AutoSize = true;
            paxLabel.Location = new System.Drawing.Point(23, 192);
            paxLabel.Name = "paxLabel";
            paxLabel.Size = new System.Drawing.Size(39, 20);
            paxLabel.TabIndex = 27;
            paxLabel.Text = "Pax:";
            // 
            // paxTextBox
            // 
            this.paxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Pax", true));
            this.paxTextBox.Location = new System.Drawing.Point(123, 189);
            this.paxTextBox.Name = "paxTextBox";
            this.paxTextBox.ReadOnly = true;
            this.paxTextBox.Size = new System.Drawing.Size(200, 26);
            this.paxTextBox.TabIndex = 28;
            // 
            // costPxLabel
            // 
            costPxLabel.AutoSize = true;
            costPxLabel.Location = new System.Drawing.Point(23, 237);
            costPxLabel.Name = "costPxLabel";
            costPxLabel.Size = new System.Drawing.Size(67, 20);
            costPxLabel.TabIndex = 29;
            costPxLabel.Text = "Cost Px:";
            // 
            // costPxTextBox
            // 
            this.costPxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "CostPx", true));
            this.costPxTextBox.Location = new System.Drawing.Point(123, 234);
            this.costPxTextBox.Name = "costPxTextBox";
            this.costPxTextBox.ReadOnly = true;
            this.costPxTextBox.Size = new System.Drawing.Size(200, 26);
            this.costPxTextBox.TabIndex = 30;
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
            this.bookingTBBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.bookingTBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookingTBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookingTBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookingTBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookingTBBindingNavigator.Name = "bookingTBBindingNavigator";
            this.bookingTBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookingTBBindingNavigator.Size = new System.Drawing.Size(354, 31);
            this.bookingTBBindingNavigator.TabIndex = 22;
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
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
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Location = new System.Drawing.Point(0, 544);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(368, 52);
            this.ExitBtn.TabIndex = 41;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // nRICLabel1
            // 
            nRICLabel1.AutoSize = true;
            nRICLabel1.Location = new System.Drawing.Point(22, 61);
            nRICLabel1.Name = "nRICLabel1";
            nRICLabel1.Size = new System.Drawing.Size(52, 20);
            nRICLabel1.TabIndex = 0;
            nRICLabel1.Text = "NRIC:";
            // 
            // nRICTextBox1
            // 
            this.nRICTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBBindingSource, "NRIC", true));
            this.nRICTextBox1.Location = new System.Drawing.Point(131, 58);
            this.nRICTextBox1.Name = "nRICTextBox1";
            this.nRICTextBox1.ReadOnly = true;
            this.nRICTextBox1.Size = new System.Drawing.Size(200, 26);
            this.nRICTextBox1.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 113);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(131, 110);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(22, 165);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(69, 20);
            contactLabel.TabIndex = 4;
            contactLabel.Text = "Contact:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(131, 162);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.ReadOnly = true;
            this.contactTextBox.Size = new System.Drawing.Size(200, 26);
            this.contactTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(22, 217);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(131, 214);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(200, 26);
            this.addressTextBox.TabIndex = 7;
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(22, 271);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(103, 20);
            date_of_BirthLabel.TabIndex = 8;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(22, 321);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(68, 20);
            countryLabel.TabIndex = 10;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(131, 318);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(200, 26);
            this.countryTextBox.TabIndex = 11;
            // 
            // CustomerbindingNavigator1
            // 
            this.CustomerbindingNavigator1.AddNewItem = null;
            this.CustomerbindingNavigator1.BindingSource = this.customerTBBindingSource;
            this.CustomerbindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.CustomerbindingNavigator1.DeleteItem = null;
            this.CustomerbindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CustomerbindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.CustomerbindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.CustomerbindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.CustomerbindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.CustomerbindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.CustomerbindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.CustomerbindingNavigator1.Name = "CustomerbindingNavigator1";
            this.CustomerbindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.CustomerbindingNavigator1.Size = new System.Drawing.Size(354, 31);
            this.CustomerbindingNavigator1.TabIndex = 12;
            this.CustomerbindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // DOBtxt
            // 
            this.DOBtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTBBindingSource, "Date of Birth", true));
            this.DOBtxt.Location = new System.Drawing.Point(131, 268);
            this.DOBtxt.Name = "DOBtxt";
            this.DOBtxt.ReadOnly = true;
            this.DOBtxt.Size = new System.Drawing.Size(200, 26);
            this.DOBtxt.TabIndex = 13;
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.NameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLbl.Location = new System.Drawing.Point(0, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(368, 46);
            this.NameLbl.TabIndex = 42;
            this.NameLbl.Text = "Results of [NRIC]";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookingDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 596);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BookingDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BookingDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBBindingNavigator)).EndInit();
            this.bookingTBBindingNavigator.ResumeLayout(false);
            this.bookingTBBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerbindingNavigator1)).EndInit();
            this.CustomerbindingNavigator1.ResumeLayout(false);
            this.CustomerbindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DabAgencyDataSet ds;
        private System.Windows.Forms.BindingSource bsBooking;
        private DabAgencyDataSetTableAdapters.BookingTBTableAdapter taBooking;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.BindingSource customerTBBindingSource;
        private DabAgencyDataSetTableAdapters.CustomerTBTableAdapter customerTBTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox arrivalTextBox;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.TextBox travelDateTextBox;
        private System.Windows.Forms.TextBox bookingIDTextBox;
        private System.Windows.Forms.TextBox nRICTextBox;
        private System.Windows.Forms.TextBox paxTextBox;
        private System.Windows.Forms.TextBox costPxTextBox;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingNavigator CustomerbindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.TextBox nRICTextBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox DOBtxt;
        private System.Windows.Forms.Label NameLbl;
    }
}