namespace DabAgent
{
    partial class HolidayDest
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
            this.holidayTBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDest = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new DabAgent.DabAgencyDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AllBtn = new System.Windows.Forms.Button();
            this.taDest = new DabAgent.DabAgencyDataSetTableAdapters.HolidayTBTableAdapter();
            this.tam = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.holidayTBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // holidayTBDataGridView
            // 
            this.holidayTBDataGridView.AllowUserToAddRows = false;
            this.holidayTBDataGridView.AllowUserToDeleteRows = false;
            this.holidayTBDataGridView.AutoGenerateColumns = false;
            this.holidayTBDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.holidayTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidayTBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.holidayTBDataGridView.DataSource = this.bsDest;
            this.holidayTBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holidayTBDataGridView.Location = new System.Drawing.Point(0, 68);
            this.holidayTBDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.holidayTBDataGridView.MultiSelect = false;
            this.holidayTBDataGridView.Name = "holidayTBDataGridView";
            this.holidayTBDataGridView.ReadOnly = true;
            this.holidayTBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.holidayTBDataGridView.Size = new System.Drawing.Size(692, 359);
            this.holidayTBDataGridView.TabIndex = 1;
            this.holidayTBDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.holidayTBDataGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HolidayID";
            this.dataGridViewTextBoxColumn1.HeaderText = "HolidayID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn2.HeaderText = "Country";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CostPx";
            this.dataGridViewTextBoxColumn4.HeaderText = "CostPx";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bsDest
            // 
            this.bsDest.DataMember = "HolidayTB";
            this.bsDest.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DabAgencyDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Holiday Destination";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.SearchTxt);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 65);
            this.panel1.TabIndex = 3;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchTxt.Location = new System.Drawing.Point(12, 19);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(162, 26);
            this.SearchTxt.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.Location = new System.Drawing.Point(178, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(122, 40);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "City Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Location = new System.Drawing.Point(458, 12);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(108, 40);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Location = new System.Drawing.Point(572, 12);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(108, 40);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Location = new System.Drawing.Point(344, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(108, 40);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AllBtn
            // 
            this.AllBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllBtn.Location = new System.Drawing.Point(558, 12);
            this.AllBtn.Name = "AllBtn";
            this.AllBtn.Size = new System.Drawing.Size(122, 40);
            this.AllBtn.TabIndex = 5;
            this.AllBtn.Text = "View All";
            this.AllBtn.UseVisualStyleBackColor = false;
            this.AllBtn.Click += new System.EventHandler(this.AllBtn_Click);
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
            // HolidayDest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 492);
            this.Controls.Add(this.AllBtn);
            this.Controls.Add(this.holidayTBDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HolidayDest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HolidayDest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holidayTBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DabAgencyDataSet ds;
        private System.Windows.Forms.BindingSource bsDest;
        private DabAgencyDataSetTableAdapters.HolidayTBTableAdapter taDest;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tam;
        private System.Windows.Forms.DataGridView holidayTBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button AllBtn;
    }
}