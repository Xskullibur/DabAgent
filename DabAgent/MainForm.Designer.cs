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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AbtBtn = new System.Windows.Forms.Button();
            this.HolidayBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewCustomer.FlatAppearance.BorderSize = 0;
            this.btnViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewCustomer.Location = new System.Drawing.Point(367, 56);
            this.btnViewCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(170, 170);
            this.btnViewCustomer.TabIndex = 1;
            this.btnViewCustomer.Text = "View Customer Details";
            this.btnViewCustomer.UseVisualStyleBackColor = false;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewBooking.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewBooking.FlatAppearance.BorderSize = 0;
            this.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBooking.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewBooking.Location = new System.Drawing.Point(12, 234);
            this.btnViewBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(170, 170);
            this.btnViewBooking.TabIndex = 2;
            this.btnViewBooking.Text = "View Booking Details";
            this.btnViewBooking.UseVisualStyleBackColor = false;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Location = new System.Drawing.Point(367, 234);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(170, 170);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AbtBtn
            // 
            this.AbtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbtBtn.BackgroundImage = global::DabAgent.Properties.Resources.abt;
            this.AbtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AbtBtn.Location = new System.Drawing.Point(12, 56);
            this.AbtBtn.Name = "AbtBtn";
            this.AbtBtn.Size = new System.Drawing.Size(348, 170);
            this.AbtBtn.TabIndex = 5;
            this.AbtBtn.UseVisualStyleBackColor = false;
            // 
            // HolidayBtn
            // 
            this.HolidayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HolidayBtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.HolidayBtn.FlatAppearance.BorderSize = 0;
            this.HolidayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HolidayBtn.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolidayBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HolidayBtn.Location = new System.Drawing.Point(190, 234);
            this.HolidayBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HolidayBtn.Name = "HolidayBtn";
            this.HolidayBtn.Size = new System.Drawing.Size(170, 170);
            this.HolidayBtn.TabIndex = 6;
            this.HolidayBtn.Text = "Holiday Destinations";
            this.HolidayBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(12, 10);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 421);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HolidayBtn);
            this.Controls.Add(this.AbtBtn);
            this.Controls.Add(this.ExitBtn);
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
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AbtBtn;
        private System.Windows.Forms.Button HolidayBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}