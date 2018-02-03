namespace DabAgent
{
    partial class BookingMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ds = new DabAgent.DabAgencyDataSet();
            this.taBooking = new DabAgent.DabAgencyDataSetTableAdapters.BookingTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.bsBooking = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ds
            // 
            this.ds.DataSetName = "DabAgencyDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bsBooking
            // 
            this.bsBooking.DataMember = "BookingTB";
            this.bsBooking.DataSource = this.ds;
            // 
            // bookingTBDataGridView
            // 
            this.bookingTBDataGridView.AutoGenerateColumns = false;
            this.bookingTBDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingTBDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingTBDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookingTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingTBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bookingTBDataGridView.DataSource = this.bsBooking;
            this.bookingTBDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingTBDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bookingTBDataGridView.Name = "bookingTBDataGridView";
            this.bookingTBDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookingTBDataGridView.RowTemplate.Height = 28;
            this.bookingTBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingTBDataGridView.Size = new System.Drawing.Size(1067, 220);
            this.bookingTBDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookingID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NRIC";
            this.dataGridViewTextBoxColumn3.HeaderText = "NRIC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TravelDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "TravelDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pax";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pax";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CostPx";
            this.dataGridViewTextBoxColumn6.HeaderText = "CostPx";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Departure";
            this.dataGridViewTextBoxColumn7.HeaderText = "Departure";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Arrival";
            this.dataGridViewTextBoxColumn8.HeaderText = "Arrival";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.AutoSize = true;
            this.RemoveBtn.Location = new System.Drawing.Point(781, 226);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(134, 43);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.AutoSize = true;
            this.AddBtn.Location = new System.Drawing.Point(641, 226);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(134, 43);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.AutoSize = true;
            this.EditBtn.Location = new System.Drawing.Point(921, 226);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(134, 43);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // BookingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 281);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.bookingTBDataGridView);
            this.Name = "BookingMain";
            this.Text = "BookingMain";
            this.Load += new System.EventHandler(this.BookingMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DabAgencyDataSet ds;
        private DabAgencyDataSetTableAdapters.BookingTBTableAdapter taBooking;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.BindingSource bsBooking;
        private System.Windows.Forms.DataGridView bookingTBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}