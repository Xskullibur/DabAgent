namespace DabAgent
{
    partial class EditBooking
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
            System.Windows.Forms.Label travelDateLabel;
            System.Windows.Forms.Label paxLabel;
            System.Windows.Forms.Label costPxLabel;
            System.Windows.Forms.Label departureLabel;
            System.Windows.Forms.Label arrivalLabel;
            System.Windows.Forms.Label nRICLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBooking));
            this.bookingTBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsBooking = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new DabAgent.DabAgencyDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookingTBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.travelDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paxTextBox = new System.Windows.Forms.TextBox();
            this.costPxTextBox = new System.Windows.Forms.TextBox();
            this.departureComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalComboBox = new System.Windows.Forms.ComboBox();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.taBooking = new DabAgent.DabAgencyDataSetTableAdapters.BookingTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            travelDateLabel = new System.Windows.Forms.Label();
            paxLabel = new System.Windows.Forms.Label();
            costPxLabel = new System.Windows.Forms.Label();
            departureLabel = new System.Windows.Forms.Label();
            arrivalLabel = new System.Windows.Forms.Label();
            nRICLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBBindingNavigator)).BeginInit();
            this.bookingTBBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // travelDateLabel
            // 
            travelDateLabel.AutoSize = true;
            travelDateLabel.BackColor = System.Drawing.Color.Transparent;
            travelDateLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            travelDateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            travelDateLabel.Location = new System.Drawing.Point(28, 179);
            travelDateLabel.Name = "travelDateLabel";
            travelDateLabel.Size = new System.Drawing.Size(112, 21);
            travelDateLabel.TabIndex = 5;
            travelDateLabel.Text = "Travel Date:";
            // 
            // paxLabel
            // 
            paxLabel.AutoSize = true;
            paxLabel.BackColor = System.Drawing.Color.Transparent;
            paxLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paxLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            paxLabel.Location = new System.Drawing.Point(28, 246);
            paxLabel.Name = "paxLabel";
            paxLabel.Size = new System.Drawing.Size(45, 21);
            paxLabel.TabIndex = 7;
            paxLabel.Text = "Pax:";
            // 
            // costPxLabel
            // 
            costPxLabel.AutoSize = true;
            costPxLabel.BackColor = System.Drawing.Color.Transparent;
            costPxLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costPxLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            costPxLabel.Location = new System.Drawing.Point(28, 451);
            costPxLabel.Name = "costPxLabel";
            costPxLabel.Size = new System.Drawing.Size(74, 21);
            costPxLabel.TabIndex = 9;
            costPxLabel.Text = "Cost Px:";
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.BackColor = System.Drawing.Color.Transparent;
            departureLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departureLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            departureLabel.Location = new System.Drawing.Point(28, 313);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new System.Drawing.Size(103, 21);
            departureLabel.TabIndex = 11;
            departureLabel.Text = "Departure:";
            // 
            // arrivalLabel
            // 
            arrivalLabel.AutoSize = true;
            arrivalLabel.BackColor = System.Drawing.Color.Transparent;
            arrivalLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            arrivalLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            arrivalLabel.Location = new System.Drawing.Point(28, 382);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new System.Drawing.Size(75, 21);
            arrivalLabel.TabIndex = 13;
            arrivalLabel.Text = "Arrival:";
            // 
            // nRICLabel
            // 
            nRICLabel.AutoSize = true;
            nRICLabel.BackColor = System.Drawing.Color.Transparent;
            nRICLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nRICLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            nRICLabel.Location = new System.Drawing.Point(28, 112);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(55, 21);
            nRICLabel.TabIndex = 14;
            nRICLabel.Text = "NRIC:";
            // 
            // bookingTBBindingNavigator
            // 
            this.bookingTBBindingNavigator.AddNewItem = null;
            this.bookingTBBindingNavigator.BackgroundImage = global::DabAgent.Properties.Resources.addBG;
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
            this.bindingNavigatorSeparator2,
            this.bookingTBBindingNavigatorSaveItem});
            this.bookingTBBindingNavigator.Location = new System.Drawing.Point(0, 55);
            this.bookingTBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookingTBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookingTBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookingTBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookingTBBindingNavigator.Name = "bookingTBBindingNavigator";
            this.bookingTBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookingTBBindingNavigator.Size = new System.Drawing.Size(370, 31);
            this.bookingTBBindingNavigator.TabIndex = 0;
            this.bookingTBBindingNavigator.Text = "bindingNavigator1";
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
            // bookingTBBindingNavigatorSaveItem
            // 
            this.bookingTBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingTBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingTBBindingNavigatorSaveItem.Image")));
            this.bookingTBBindingNavigatorSaveItem.Name = "bookingTBBindingNavigatorSaveItem";
            this.bookingTBBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.bookingTBBindingNavigatorSaveItem.Text = "Save Data";
            this.bookingTBBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookingTBBindingNavigatorSaveItem_Click_2);
            // 
            // travelDateDateTimePicker
            // 
            this.travelDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBooking, "TravelDate", true));
            this.travelDateDateTimePicker.Location = new System.Drawing.Point(32, 203);
            this.travelDateDateTimePicker.Name = "travelDateDateTimePicker";
            this.travelDateDateTimePicker.Size = new System.Drawing.Size(304, 26);
            this.travelDateDateTimePicker.TabIndex = 2;
            // 
            // paxTextBox
            // 
            this.paxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Pax", true));
            this.paxTextBox.Location = new System.Drawing.Point(32, 270);
            this.paxTextBox.Name = "paxTextBox";
            this.paxTextBox.Size = new System.Drawing.Size(304, 26);
            this.paxTextBox.TabIndex = 3;
            // 
            // costPxTextBox
            // 
            this.costPxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "CostPx", true));
            this.costPxTextBox.Location = new System.Drawing.Point(32, 475);
            this.costPxTextBox.Name = "costPxTextBox";
            this.costPxTextBox.Size = new System.Drawing.Size(304, 26);
            this.costPxTextBox.TabIndex = 6;
            // 
            // departureComboBox
            // 
            this.departureComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Departure", true));
            this.departureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureComboBox.FormattingEnabled = true;
            this.departureComboBox.Items.AddRange(new object[] {
            "",
            "Singapore",
            "Italy",
            "France",
            "Spain",
            "America",
            "Greece",
            "Australia",
            "New Zealand",
            "Thailand",
            "Turkey",
            "India",
            "South Africa",
            "Vietnam",
            "Sri Lanka",
            "Netherlands",
            "Mexico",
            "Portugal",
            "Ireland",
            "Japan",
            "Canada",
            "Morocco"});
            this.departureComboBox.Location = new System.Drawing.Point(32, 337);
            this.departureComboBox.Name = "departureComboBox";
            this.departureComboBox.Size = new System.Drawing.Size(304, 28);
            this.departureComboBox.TabIndex = 4;
            // 
            // arrivalComboBox
            // 
            this.arrivalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Arrival", true));
            this.arrivalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrivalComboBox.FormattingEnabled = true;
            this.arrivalComboBox.Items.AddRange(new object[] {
            "",
            "Singapore",
            "Italy",
            "France",
            "Spain",
            "America",
            "Greece",
            "Australia",
            "New Zealand",
            "Thailand",
            "Turkey",
            "India",
            "South Africa",
            "Vietnam",
            "Sri Lanka",
            "Netherlands",
            "Mexico",
            "Portugal",
            "Ireland",
            "Japan",
            "Canada",
            "Morocco"});
            this.arrivalComboBox.Location = new System.Drawing.Point(32, 406);
            this.arrivalComboBox.Name = "arrivalComboBox";
            this.arrivalComboBox.Size = new System.Drawing.Size(304, 28);
            this.arrivalComboBox.TabIndex = 5;
            // 
            // nRICTextBox
            // 
            this.nRICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "NRIC", true));
            this.nRICTextBox.Location = new System.Drawing.Point(32, 136);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.Size = new System.Drawing.Size(304, 26);
            this.nRICTextBox.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SaveBtn.Location = new System.Drawing.Point(0, 569);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(186, 53);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Location = new System.Drawing.Point(184, 570);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(186, 53);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit Booking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DabAgent.Properties.Resources.addBG;
            this.ClientSize = new System.Drawing.Size(370, 622);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(nRICLabel);
            this.Controls.Add(this.nRICTextBox);
            this.Controls.Add(travelDateLabel);
            this.Controls.Add(this.travelDateDateTimePicker);
            this.Controls.Add(paxLabel);
            this.Controls.Add(this.paxTextBox);
            this.Controls.Add(costPxLabel);
            this.Controls.Add(this.costPxTextBox);
            this.Controls.Add(departureLabel);
            this.Controls.Add(this.departureComboBox);
            this.Controls.Add(arrivalLabel);
            this.Controls.Add(this.arrivalComboBox);
            this.Controls.Add(this.bookingTBBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBooking";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBBindingNavigator)).EndInit();
            this.bookingTBBindingNavigator.ResumeLayout(false);
            this.bookingTBBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bookingTBBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker travelDateDateTimePicker;
        private System.Windows.Forms.TextBox paxTextBox;
        private System.Windows.Forms.TextBox costPxTextBox;
        private System.Windows.Forms.ComboBox departureComboBox;
        private System.Windows.Forms.ComboBox arrivalComboBox;
        private System.Windows.Forms.TextBox nRICTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
    }
}