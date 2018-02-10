namespace DabAgent
{
    partial class AddDest
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
            this.label1 = new System.Windows.Forms.Label();
            this.ds = new DabAgent.DabAgencyDataSet();
            this.bsDest = new System.Windows.Forms.BindingSource(this.components);
            this.taDest = new DabAgent.DabAgencyDataSetTableAdapters.HolidayTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.holidayIDTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.costPxTextBox = new System.Windows.Forms.TextBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            holidayIDLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            costPxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDest)).BeginInit();
            this.SuspendLayout();
            // 
            // holidayIDLabel
            // 
            holidayIDLabel.AutoSize = true;
            holidayIDLabel.BackColor = System.Drawing.Color.Transparent;
            holidayIDLabel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            holidayIDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            holidayIDLabel.Location = new System.Drawing.Point(29, 65);
            holidayIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            holidayIDLabel.Name = "holidayIDLabel";
            holidayIDLabel.Size = new System.Drawing.Size(67, 14);
            holidayIDLabel.TabIndex = 2;
            holidayIDLabel.Text = "Holiday ID:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.BackColor = System.Drawing.Color.Transparent;
            countryLabel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            countryLabel.Location = new System.Drawing.Point(29, 114);
            countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(52, 14);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.Color.Transparent;
            cityLabel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            cityLabel.Location = new System.Drawing.Point(29, 162);
            cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(31, 14);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City:";
            // 
            // costPxLabel
            // 
            costPxLabel.AutoSize = true;
            costPxLabel.BackColor = System.Drawing.Color.Transparent;
            costPxLabel.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costPxLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            costPxLabel.Location = new System.Drawing.Point(29, 211);
            costPxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            costPxLabel.Name = "costPxLabel";
            costPxLabel.Size = new System.Drawing.Size(48, 14);
            costPxLabel.TabIndex = 8;
            costPxLabel.Text = "Cost Px:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Holiday Destination";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // holidayIDTextBox
            // 
            this.holidayIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDest, "HolidayID", true));
            this.holidayIDTextBox.Location = new System.Drawing.Point(31, 81);
            this.holidayIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.holidayIDTextBox.Name = "holidayIDTextBox";
            this.holidayIDTextBox.Size = new System.Drawing.Size(187, 20);
            this.holidayIDTextBox.TabIndex = 3;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDest, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(31, 129);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(187, 20);
            this.countryTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDest, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(31, 178);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(187, 20);
            this.cityTextBox.TabIndex = 7;
            // 
            // costPxTextBox
            // 
            this.costPxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDest, "CostPx", true));
            this.costPxTextBox.Location = new System.Drawing.Point(31, 227);
            this.costPxTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.costPxTextBox.Name = "costPxTextBox";
            this.costPxTextBox.Size = new System.Drawing.Size(187, 20);
            this.costPxTextBox.TabIndex = 9;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCust.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddCust.FlatAppearance.BorderSize = 0;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCust.Location = new System.Drawing.Point(0, 326);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(127, 32);
            this.btnAddCust.TabIndex = 16;
            this.btnAddCust.Text = "Add Destination";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(125, 326);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(127, 32);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddDest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DabAgent.Properties.Resources.addBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(252, 360);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(holidayIDLabel);
            this.Controls.Add(this.holidayIDTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(costPxLabel);
            this.Controls.Add(this.costPxTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddDest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddDest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DabAgencyDataSet ds;
        private System.Windows.Forms.BindingSource bsDest;
        private DabAgencyDataSetTableAdapters.HolidayTBTableAdapter taDest;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.TextBox holidayIDTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox costPxTextBox;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button CancelBtn;
    }
}