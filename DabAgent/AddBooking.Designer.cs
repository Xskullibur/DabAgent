namespace DabAgent
{
    partial class AddBooking
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
            System.Windows.Forms.Label travelDateLabel;
            System.Windows.Forms.Label paxLabel;
            System.Windows.Forms.Label costPxLabel;
            System.Windows.Forms.Label departureLabel;
            System.Windows.Forms.Label arrivalLabel;
            System.Windows.Forms.Label bookingDateLabel;
            this.TabControl = new System.Windows.Forms.TabControl();
            this.PersonalTab = new System.Windows.Forms.TabPage();
            this.bookingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bsBooking = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new DabAgent.DabAgencyDataSet();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.travelDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paxTextBox = new System.Windows.Forms.TextBox();
            this.FlightTab = new System.Windows.Forms.TabPage();
            this.CalBtn = new System.Windows.Forms.Button();
            this.DistLbl = new System.Windows.Forms.Label();
            this.ArrivalCombo = new System.Windows.Forms.ComboBox();
            this.DepartureCombo = new System.Windows.Forms.ComboBox();
            this.costPxTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.taBooking = new DabAgent.DabAgencyDataSetTableAdapters.BookingTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            nRICLabel = new System.Windows.Forms.Label();
            travelDateLabel = new System.Windows.Forms.Label();
            paxLabel = new System.Windows.Forms.Label();
            costPxLabel = new System.Windows.Forms.Label();
            departureLabel = new System.Windows.Forms.Label();
            arrivalLabel = new System.Windows.Forms.Label();
            bookingDateLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.PersonalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.FlightTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // nRICLabel
            // 
            nRICLabel.AutoSize = true;
            nRICLabel.Location = new System.Drawing.Point(21, 23);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(52, 20);
            nRICLabel.TabIndex = 4;
            nRICLabel.Text = "NRIC:";
            // 
            // travelDateLabel
            // 
            travelDateLabel.AutoSize = true;
            travelDateLabel.Location = new System.Drawing.Point(21, 56);
            travelDateLabel.Name = "travelDateLabel";
            travelDateLabel.Size = new System.Drawing.Size(94, 20);
            travelDateLabel.TabIndex = 6;
            travelDateLabel.Text = "Travel Date:";
            // 
            // paxLabel
            // 
            paxLabel.AutoSize = true;
            paxLabel.Location = new System.Drawing.Point(21, 87);
            paxLabel.Name = "paxLabel";
            paxLabel.Size = new System.Drawing.Size(39, 20);
            paxLabel.TabIndex = 8;
            paxLabel.Text = "Pax:";
            // 
            // costPxLabel
            // 
            costPxLabel.AutoSize = true;
            costPxLabel.Location = new System.Drawing.Point(18, 84);
            costPxLabel.Name = "costPxLabel";
            costPxLabel.Size = new System.Drawing.Size(67, 20);
            costPxLabel.TabIndex = 16;
            costPxLabel.Text = "Cost Px:";
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Location = new System.Drawing.Point(18, 20);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new System.Drawing.Size(85, 20);
            departureLabel.TabIndex = 18;
            departureLabel.Text = "Departure:";
            // 
            // arrivalLabel
            // 
            arrivalLabel.AutoSize = true;
            arrivalLabel.Location = new System.Drawing.Point(18, 52);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new System.Drawing.Size(56, 20);
            arrivalLabel.TabIndex = 20;
            arrivalLabel.Text = "Arrival:";
            // 
            // bookingDateLabel
            // 
            bookingDateLabel.AutoSize = true;
            bookingDateLabel.Location = new System.Drawing.Point(21, 120);
            bookingDateLabel.Name = "bookingDateLabel";
            bookingDateLabel.Size = new System.Drawing.Size(110, 20);
            bookingDateLabel.TabIndex = 9;
            bookingDateLabel.Text = "Booking Date:";
            bookingDateLabel.Visible = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PersonalTab);
            this.TabControl.Controls.Add(this.FlightTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(464, 237);
            this.TabControl.TabIndex = 0;
            // 
            // PersonalTab
            // 
            this.PersonalTab.AutoScroll = true;
            this.PersonalTab.Controls.Add(bookingDateLabel);
            this.PersonalTab.Controls.Add(this.bookingDateDateTimePicker);
            this.PersonalTab.Controls.Add(nRICLabel);
            this.PersonalTab.Controls.Add(this.nRICTextBox);
            this.PersonalTab.Controls.Add(travelDateLabel);
            this.PersonalTab.Controls.Add(this.travelDateDateTimePicker);
            this.PersonalTab.Controls.Add(paxLabel);
            this.PersonalTab.Controls.Add(this.paxTextBox);
            this.PersonalTab.Location = new System.Drawing.Point(4, 29);
            this.PersonalTab.Name = "PersonalTab";
            this.PersonalTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalTab.Size = new System.Drawing.Size(456, 204);
            this.PersonalTab.TabIndex = 0;
            this.PersonalTab.Text = "Personal Details";
            this.PersonalTab.UseVisualStyleBackColor = true;
            // 
            // bookingDateDateTimePicker
            // 
            this.bookingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBooking, "BookingDate", true));
            this.bookingDateDateTimePicker.Enabled = false;
            this.bookingDateDateTimePicker.Location = new System.Drawing.Point(137, 116);
            this.bookingDateDateTimePicker.Name = "bookingDateDateTimePicker";
            this.bookingDateDateTimePicker.Size = new System.Drawing.Size(294, 26);
            this.bookingDateDateTimePicker.TabIndex = 10;
            this.bookingDateDateTimePicker.Value = new System.DateTime(2018, 2, 1, 23, 24, 17, 0);
            this.bookingDateDateTimePicker.Visible = false;
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
            // nRICTextBox
            // 
            this.nRICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "NRIC", true));
            this.nRICTextBox.Location = new System.Drawing.Point(137, 20);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.Size = new System.Drawing.Size(294, 26);
            this.nRICTextBox.TabIndex = 5;
            // 
            // travelDateDateTimePicker
            // 
            this.travelDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBooking, "TravelDate", true));
            this.travelDateDateTimePicker.Location = new System.Drawing.Point(137, 52);
            this.travelDateDateTimePicker.Name = "travelDateDateTimePicker";
            this.travelDateDateTimePicker.Size = new System.Drawing.Size(294, 26);
            this.travelDateDateTimePicker.TabIndex = 7;
            this.travelDateDateTimePicker.ValueChanged += new System.EventHandler(this.travelDateDateTimePicker_ValueChanged);
            // 
            // paxTextBox
            // 
            this.paxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Pax", true));
            this.paxTextBox.Location = new System.Drawing.Point(137, 84);
            this.paxTextBox.Name = "paxTextBox";
            this.paxTextBox.Size = new System.Drawing.Size(294, 26);
            this.paxTextBox.TabIndex = 9;
            // 
            // FlightTab
            // 
            this.FlightTab.Controls.Add(this.CalBtn);
            this.FlightTab.Controls.Add(this.DistLbl);
            this.FlightTab.Controls.Add(this.ArrivalCombo);
            this.FlightTab.Controls.Add(this.DepartureCombo);
            this.FlightTab.Controls.Add(costPxLabel);
            this.FlightTab.Controls.Add(this.costPxTextBox);
            this.FlightTab.Controls.Add(departureLabel);
            this.FlightTab.Controls.Add(arrivalLabel);
            this.FlightTab.Location = new System.Drawing.Point(4, 29);
            this.FlightTab.Name = "FlightTab";
            this.FlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.FlightTab.Size = new System.Drawing.Size(456, 204);
            this.FlightTab.TabIndex = 1;
            this.FlightTab.Text = "Flight Details";
            this.FlightTab.UseVisualStyleBackColor = true;
            // 
            // CalBtn
            // 
            this.CalBtn.Location = new System.Drawing.Point(207, 145);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(126, 30);
            this.CalBtn.TabIndex = 25;
            this.CalBtn.Text = "Calculate Cost";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Visible = false;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // DistLbl
            // 
            this.DistLbl.AutoSize = true;
            this.DistLbl.Location = new System.Drawing.Point(130, 122);
            this.DistLbl.Name = "DistLbl";
            this.DistLbl.Size = new System.Drawing.Size(116, 20);
            this.DistLbl.TabIndex = 23;
            this.DistLbl.Text = "Distance: 0000";
            this.DistLbl.Visible = false;
            // 
            // ArrivalCombo
            // 
            this.ArrivalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArrivalCombo.FormattingEnabled = true;
            this.ArrivalCombo.Items.AddRange(new object[] {
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
            this.ArrivalCombo.Location = new System.Drawing.Point(134, 49);
            this.ArrivalCombo.Name = "ArrivalCombo";
            this.ArrivalCombo.Size = new System.Drawing.Size(200, 28);
            this.ArrivalCombo.TabIndex = 22;
            // 
            // DepartureCombo
            // 
            this.DepartureCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartureCombo.FormattingEnabled = true;
            this.DepartureCombo.Items.AddRange(new object[] {
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
            this.DepartureCombo.Location = new System.Drawing.Point(134, 17);
            this.DepartureCombo.Name = "DepartureCombo";
            this.DepartureCombo.Size = new System.Drawing.Size(200, 28);
            this.DepartureCombo.TabIndex = 21;
            // 
            // costPxTextBox
            // 
            this.costPxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "CostPx", true));
            this.costPxTextBox.Location = new System.Drawing.Point(134, 81);
            this.costPxTextBox.Name = "costPxTextBox";
            this.costPxTextBox.Size = new System.Drawing.Size(200, 26);
            this.costPxTextBox.TabIndex = 17;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(368, 255);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(104, 42);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 305);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TabControl);
            this.Name = "AddBooking";
            this.Text = "AddBooking";
            this.Load += new System.EventHandler(this.AddBooking_Load);
            this.TabControl.ResumeLayout(false);
            this.PersonalTab.ResumeLayout(false);
            this.PersonalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.FlightTab.ResumeLayout(false);
            this.FlightTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage PersonalTab;
        private System.Windows.Forms.TabPage FlightTab;
        private DabAgencyDataSet ds;
        private System.Windows.Forms.BindingSource bsBooking;
        private DabAgencyDataSetTableAdapters.BookingTBTableAdapter taBooking;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.TextBox nRICTextBox;
        private System.Windows.Forms.DateTimePicker travelDateDateTimePicker;
        private System.Windows.Forms.TextBox paxTextBox;
        private System.Windows.Forms.TextBox costPxTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DateTimePicker bookingDateDateTimePicker;
        private System.Windows.Forms.ComboBox ArrivalCombo;
        private System.Windows.Forms.ComboBox DepartureCombo;
        private System.Windows.Forms.Label DistLbl;
        private System.Windows.Forms.Button CalBtn;
    }
}