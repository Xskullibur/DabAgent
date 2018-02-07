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
            this.bookingDateComboBox = new System.Windows.Forms.ComboBox();
            this.bsBooking = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new DabAgent.DabAgencyDataSet();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.travelDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paxTextBox = new System.Windows.Forms.TextBox();
            this.FlightTab = new System.Windows.Forms.TabPage();
            this.arrivalComboBox = new System.Windows.Forms.ComboBox();
            this.departureComboBox = new System.Windows.Forms.ComboBox();
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
            nRICLabel.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nRICLabel.Location = new System.Drawing.Point(40, 33);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(47, 19);
            nRICLabel.TabIndex = 4;
            nRICLabel.Text = "NRIC:";
            // 
            // travelDateLabel
            // 
            travelDateLabel.AutoSize = true;
            travelDateLabel.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            travelDateLabel.Location = new System.Drawing.Point(40, 83);
            travelDateLabel.Name = "travelDateLabel";
            travelDateLabel.Size = new System.Drawing.Size(89, 19);
            travelDateLabel.TabIndex = 6;
            travelDateLabel.Text = "Travel Date:";
            // 
            // paxLabel
            // 
            paxLabel.AutoSize = true;
            paxLabel.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paxLabel.Location = new System.Drawing.Point(40, 179);
            paxLabel.Name = "paxLabel";
            paxLabel.Size = new System.Drawing.Size(38, 19);
            paxLabel.TabIndex = 8;
            paxLabel.Text = "Pax:";
            // 
            // costPxLabel
            // 
            costPxLabel.AutoSize = true;
            costPxLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costPxLabel.Location = new System.Drawing.Point(42, 152);
            costPxLabel.Name = "costPxLabel";
            costPxLabel.Size = new System.Drawing.Size(66, 19);
            costPxLabel.TabIndex = 16;
            costPxLabel.Text = "Cost Px:";
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departureLabel.Location = new System.Drawing.Point(42, 54);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new System.Drawing.Size(89, 19);
            departureLabel.TabIndex = 25;
            departureLabel.Text = "Departure:";
            // 
            // arrivalLabel
            // 
            arrivalLabel.AutoSize = true;
            arrivalLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            arrivalLabel.Location = new System.Drawing.Point(42, 103);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new System.Drawing.Size(64, 19);
            arrivalLabel.TabIndex = 26;
            arrivalLabel.Text = "Arrival:";
            // 
            // bookingDateLabel
            // 
            bookingDateLabel.AutoSize = true;
            bookingDateLabel.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bookingDateLabel.Location = new System.Drawing.Point(40, 129);
            bookingDateLabel.Name = "bookingDateLabel";
            bookingDateLabel.Size = new System.Drawing.Size(106, 19);
            bookingDateLabel.TabIndex = 9;
            bookingDateLabel.Text = "Booking Date:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PersonalTab);
            this.TabControl.Controls.Add(this.FlightTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(534, 276);
            this.TabControl.TabIndex = 0;
            // 
            // PersonalTab
            // 
            this.PersonalTab.AutoScroll = true;
            this.PersonalTab.Controls.Add(bookingDateLabel);
            this.PersonalTab.Controls.Add(this.bookingDateComboBox);
            this.PersonalTab.Controls.Add(nRICLabel);
            this.PersonalTab.Controls.Add(this.nRICTextBox);
            this.PersonalTab.Controls.Add(travelDateLabel);
            this.PersonalTab.Controls.Add(this.travelDateDateTimePicker);
            this.PersonalTab.Controls.Add(paxLabel);
            this.PersonalTab.Controls.Add(this.paxTextBox);
            this.PersonalTab.Location = new System.Drawing.Point(4, 29);
            this.PersonalTab.Name = "PersonalTab";
            this.PersonalTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalTab.Size = new System.Drawing.Size(526, 243);
            this.PersonalTab.TabIndex = 0;
            this.PersonalTab.Text = "Personal Details";
            this.PersonalTab.UseVisualStyleBackColor = true;
            // 
            // bookingDateComboBox
            // 
            this.bookingDateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "BookingDate", true));
            this.bookingDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookingDateComboBox.FormattingEnabled = true;
            this.bookingDateComboBox.Location = new System.Drawing.Point(152, 125);
            this.bookingDateComboBox.Name = "bookingDateComboBox";
            this.bookingDateComboBox.Size = new System.Drawing.Size(247, 28);
            this.bookingDateComboBox.TabIndex = 10;
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
            this.nRICTextBox.Location = new System.Drawing.Point(152, 29);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.Size = new System.Drawing.Size(247, 26);
            this.nRICTextBox.TabIndex = 5;
            // 
            // travelDateDateTimePicker
            // 
            this.travelDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBooking, "TravelDate", true));
            this.travelDateDateTimePicker.Location = new System.Drawing.Point(152, 77);
            this.travelDateDateTimePicker.Name = "travelDateDateTimePicker";
            this.travelDateDateTimePicker.Size = new System.Drawing.Size(247, 26);
            this.travelDateDateTimePicker.TabIndex = 7;
            this.travelDateDateTimePicker.ValueChanged += new System.EventHandler(this.travelDateDateTimePicker_ValueChanged);
            // 
            // paxTextBox
            // 
            this.paxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "Pax", true));
            this.paxTextBox.Location = new System.Drawing.Point(152, 175);
            this.paxTextBox.Name = "paxTextBox";
            this.paxTextBox.Size = new System.Drawing.Size(247, 26);
            this.paxTextBox.TabIndex = 9;
            // 
            // FlightTab
            // 
            this.FlightTab.Controls.Add(arrivalLabel);
            this.FlightTab.Controls.Add(this.arrivalComboBox);
            this.FlightTab.Controls.Add(departureLabel);
            this.FlightTab.Controls.Add(this.departureComboBox);
            this.FlightTab.Controls.Add(costPxLabel);
            this.FlightTab.Controls.Add(this.costPxTextBox);
            this.FlightTab.Location = new System.Drawing.Point(4, 29);
            this.FlightTab.Name = "FlightTab";
            this.FlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.FlightTab.Size = new System.Drawing.Size(526, 243);
            this.FlightTab.TabIndex = 1;
            this.FlightTab.Text = "Flight Details";
            this.FlightTab.UseVisualStyleBackColor = true;
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
            this.arrivalComboBox.Location = new System.Drawing.Point(162, 99);
            this.arrivalComboBox.Name = "arrivalComboBox";
            this.arrivalComboBox.Size = new System.Drawing.Size(199, 28);
            this.arrivalComboBox.TabIndex = 27;
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
            this.departureComboBox.Location = new System.Drawing.Point(162, 50);
            this.departureComboBox.Name = "departureComboBox";
            this.departureComboBox.Size = new System.Drawing.Size(199, 28);
            this.departureComboBox.TabIndex = 26;
            // 
            // costPxTextBox
            // 
            this.costPxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBooking, "CostPx", true));
            this.costPxTextBox.Location = new System.Drawing.Point(162, 148);
            this.costPxTextBox.Name = "costPxTextBox";
            this.costPxTextBox.Size = new System.Drawing.Size(200, 26);
            this.costPxTextBox.TabIndex = 17;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(442, 294);
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
            this.BackgroundImage = global::DabAgent.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 348);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Booking";
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
        private System.Windows.Forms.ComboBox arrivalComboBox;
        private System.Windows.Forms.ComboBox departureComboBox;
        private System.Windows.Forms.ComboBox bookingDateComboBox;
    }
}