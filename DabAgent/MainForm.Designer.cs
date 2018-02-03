namespace DabAgent
{
    partial class MainForm
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
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Location = new System.Drawing.Point(75, 37);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(107, 36);
            this.btnViewCustomer.TabIndex = 0;
            this.btnViewCustomer.Text = "View Customer Details";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Holiday Destinations";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.Location = new System.Drawing.Point(75, 79);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(107, 37);
            this.btnViewBooking.TabIndex = 2;
            this.btnViewBooking.Text = "View Booking Details";
            this.btnViewBooking.UseVisualStyleBackColor = true;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnViewBooking);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnViewCustomer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnViewBooking;
    }
}