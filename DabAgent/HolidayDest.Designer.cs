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
            this.dabAgencyDataSet = new DabAgent.DabAgencyDataSet();
            this.holidayTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holidayTBTableAdapter = new DabAgent.DabAgencyDataSetTableAdapters.HolidayTBTableAdapter();
            this.tableAdapterManager = new DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager();
            this.holidayTBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dabAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayTBDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dabAgencyDataSet
            // 
            this.dabAgencyDataSet.DataSetName = "DabAgencyDataSet";
            this.dabAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // holidayTBBindingSource
            // 
            this.holidayTBBindingSource.DataMember = "HolidayTB";
            this.holidayTBBindingSource.DataSource = this.dabAgencyDataSet;
            // 
            // holidayTBTableAdapter
            // 
            this.holidayTBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTBTableAdapter = null;
            this.tableAdapterManager.CustomerTBTableAdapter = null;
            this.tableAdapterManager.HolidayTBTableAdapter = this.holidayTBTableAdapter;
            this.tableAdapterManager.UpdateOrder = DabAgent.DabAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // holidayTBDataGridView
            // 
            this.holidayTBDataGridView.AutoGenerateColumns = false;
            this.holidayTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidayTBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.holidayTBDataGridView.DataSource = this.holidayTBBindingSource;
            this.holidayTBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holidayTBDataGridView.Location = new System.Drawing.Point(0, 72);
            this.holidayTBDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.holidayTBDataGridView.Name = "holidayTBDataGridView";
            this.holidayTBDataGridView.Size = new System.Drawing.Size(663, 353);
            this.holidayTBDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HolidayID";
            this.dataGridViewTextBoxColumn1.HeaderText = "HolidayID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn2.HeaderText = "Country";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CostPx";
            this.dataGridViewTextBoxColumn4.HeaderText = "CostPx";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Holiday Destination";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HolidayDest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 425);
            this.Controls.Add(this.holidayTBDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HolidayDest";
            this.Load += new System.EventHandler(this.HolidayDest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dabAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayTBDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DabAgencyDataSet dabAgencyDataSet;
        private System.Windows.Forms.BindingSource holidayTBBindingSource;
        private DabAgencyDataSetTableAdapters.HolidayTBTableAdapter holidayTBTableAdapter;
        private DabAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView holidayTBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
    }
}