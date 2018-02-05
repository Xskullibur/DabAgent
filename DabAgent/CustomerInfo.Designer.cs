namespace DabAgent
{
    partial class CustomerInfo
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
            this.ds = new DabAgent.DabAgencyDataSet();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.taCustomer = new DabAgent.DabAgencyDataSetTableAdapters.CustomerTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.nRICTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            nRICLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // nRICLabel
            // 
            nRICLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            nRICLabel.AutoSize = true;
            nRICLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nRICLabel.Location = new System.Drawing.Point(27, 91);
            nRICLabel.Name = "nRICLabel";
            nRICLabel.Size = new System.Drawing.Size(59, 23);
            nRICLabel.TabIndex = 1;
            nRICLabel.Text = "NRIC:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(27, 142);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 23);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // contactLabel
            // 
            contactLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            contactLabel.AutoSize = true;
            contactLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactLabel.Location = new System.Drawing.Point(27, 193);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(76, 23);
            contactLabel.TabIndex = 5;
            contactLabel.Text = "Contact:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(27, 244);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(80, 23);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_of_BirthLabel.Location = new System.Drawing.Point(27, 295);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(124, 23);
            date_of_BirthLabel.TabIndex = 9;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // countryLabel
            // 
            countryLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.Location = new System.Drawing.Point(27, 346);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(76, 23);
            countryLabel.TabIndex = 11;
            countryLabel.Text = "Country:";
            // 
            // ds
            // 
            this.ds.DataSetName = "DabAgencyDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataMember = "CustomerTB";
            this.bsCustomer.DataSource = this.ds;
            // 
            // taCustomer
            // 
            this.taCustomer.ClearBeforeFill = true;
            // 
            // tam
            // 
            this.tam.BackupDataSetBeforeUpdate = false;
            this.tam.BookingTBTableAdapter = null;
            this.tam.CustomerTBTableAdapter = this.taCustomer;
            this.tam.HolidayTBTableAdapter = null;
            this.tam.UpdateOrder = DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nRICTextBox
            // 
            this.nRICTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nRICTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nRICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "NRIC", true));
            this.nRICTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRICTextBox.Location = new System.Drawing.Point(157, 91);
            this.nRICTextBox.Name = "nRICTextBox";
            this.nRICTextBox.ReadOnly = true;
            this.nRICTextBox.Size = new System.Drawing.Size(200, 26);
            this.nRICTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(157, 142);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.contactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Contact", true));
            this.contactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.Location = new System.Drawing.Point(157, 193);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.ReadOnly = true;
            this.contactTextBox.Size = new System.Drawing.Size(200, 26);
            this.contactTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(157, 244);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(200, 26);
            this.addressTextBox.TabIndex = 8;
            // 
            // date_of_BirthTextBox
            // 
            this.date_of_BirthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.date_of_BirthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date_of_BirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Date of Birth", true));
            this.date_of_BirthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_of_BirthTextBox.Location = new System.Drawing.Point(157, 295);
            this.date_of_BirthTextBox.Name = "date_of_BirthTextBox";
            this.date_of_BirthTextBox.ReadOnly = true;
            this.date_of_BirthTextBox.Size = new System.Drawing.Size(200, 26);
            this.date_of_BirthTextBox.TabIndex = 10;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.countryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Country", true));
            this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.Location = new System.Drawing.Point(157, 346);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(200, 26);
            this.countryTextBox.TabIndex = 12;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(0, 407);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(384, 60);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.Text = "Close";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customer Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(384, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(nRICLabel);
            this.Controls.Add(this.nRICTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInfo";
            this.Text = "CustomerInfo";
            this.Load += new System.EventHandler(this.CustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DabAgencyDataSet ds;
        private System.Windows.Forms.BindingSource bsCustomer;
        private DabAgencyDataSetTableAdapters.CustomerTBTableAdapter taCustomer;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.TextBox nRICTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox date_of_BirthTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
    }
}