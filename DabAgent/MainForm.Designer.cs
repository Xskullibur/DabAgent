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
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewCustomer.BackColor = System.Drawing.Color.SkyBlue;
            this.btnViewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewCustomer.FlatAppearance.BorderSize = 0;
            this.btnViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewCustomer.Location = new System.Drawing.Point(87, 117);
            this.btnViewCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(215, 81);
            this.btnViewCustomer.TabIndex = 1;
            this.btnViewCustomer.Text = "View Customer Details";
            this.btnViewCustomer.UseVisualStyleBackColor = false;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewBooking.BackColor = System.Drawing.Color.SkyBlue;
            this.btnViewBooking.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewBooking.FlatAppearance.BorderSize = 0;
            this.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBooking.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.Location = new System.Drawing.Point(87, 258);
            this.btnViewBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(215, 81);
            this.btnViewBooking.TabIndex = 2;
            this.btnViewBooking.Text = "View Booking Details";
            this.btnViewBooking.UseVisualStyleBackColor = false;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 64);
            this.panel1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(87, 399);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(215, 81);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(12, 10);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DabAgent.Properties.Resources.background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 567);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewBooking);
            this.Controls.Add(this.btnViewCustomer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button btnViewBooking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button1;
    }
}