namespace DabAgent
{
    partial class CustAdd
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
            this.dabAgencyDS = new DabAgent.DabAgencyDataSet();
            this.customerBS = new System.Windows.Forms.BindingSource(this.components);
            this.customerTA = new DabAgent.DabAgencyDataSetTableAdapters.CustomerTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            nRICLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dabAgencyDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBS)).BeginInit();
            this.SuspendLayout();
            // 
            // nRICLabel
            // 
            nRICLabel.AutoSize = true;
            nRICLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            nRICLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nRICLabel.ForeColor = System.Drawing.Color.Black;
            nRICLabel.Location = new System.Drawing.Point(29, 33);
            nRICLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(50, 19);
            nRICLabel.TabIndex = 1;
            nRICLabel.Text = "NRIC:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            nameLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.Black;
            nameLabel.Location = new System.Drawing.Point(29, 78);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            contactLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactLabel.ForeColor = System.Drawing.Color.Black;
            contactLabel.Location = new System.Drawing.Point(29, 124);
            contactLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(70, 19);
            contactLabel.TabIndex = 5;
            contactLabel.Text = "Contact:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            addressLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.ForeColor = System.Drawing.Color.Black;
            addressLabel.Location = new System.Drawing.Point(29, 169);
            addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 19);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            date_of_BirthLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_of_BirthLabel.ForeColor = System.Drawing.Color.Black;
            date_of_BirthLabel.Location = new System.Drawing.Point(29, 216);
            date_of_BirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(107, 19);
            date_of_BirthLabel.TabIndex = 9;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            countryLabel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.ForeColor = System.Drawing.Color.Black;
            countryLabel.Location = new System.Drawing.Point(32, 259);
            countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(72, 19);
            countryLabel.TabIndex = 11;
            countryLabel.Text = "Country:";
            // 
            // dabAgencyDS
            // 
            this.dabAgencyDS.DataSetName = "DabAgencyDataSet";
            this.dabAgencyDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBS
            // 
            this.customerBS.DataMember = "CustomerTB";
            this.customerBS.DataSource = this.dabAgencyDS;
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
            // nRICTextBox
            // 
            this.nRICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "NRIC", true));
            this.nRICTextBox.Location = new System.Drawing.Point(149, 29);
            this.nRICTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.Size = new System.Drawing.Size(295, 26);
            this.nRICTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(149, 75);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(295, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(149, 120);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(295, 26);
            this.contactTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(149, 165);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(295, 26);
            this.addressTextBox.TabIndex = 8;
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBS, "Date of Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(149, 210);
            this.date_of_BirthDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(295, 26);
            this.date_of_BirthDateTimePicker.TabIndex = 10;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBS, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(149, 255);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(295, 26);
            this.countryTextBox.TabIndex = 12;
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddCust.FlatAppearance.BorderSize = 0;
            this.btnAddCust.Location = new System.Drawing.Point(307, 295);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(137, 42);
            this.btnAddCust.TabIndex = 13;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // CustAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DabAgent.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 348);
            this.Controls.Add(this.btnAddCust);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustAdd";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.CustAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dabAgencyDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DabAgencyDataSet dabAgencyDS;
        private System.Windows.Forms.BindingSource customerBS;
        private DabAgencyDataSetTableAdapters.CustomerTBTableAdapter customerTA;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.TextBox nRICTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button btnAddCust;
    }
}