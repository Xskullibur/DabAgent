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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.HolidayBtn = new System.Windows.Forms.Button();
            this.AbtBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(701, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Location = new System.Drawing.Point(413, 195);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(197, 180);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnViewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewCustomer.FlatAppearance.BorderSize = 0;
            this.btnViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewCustomer.Location = new System.Drawing.Point(209, 193);
            this.btnViewCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(197, 180);
            this.btnViewCustomer.TabIndex = 3;
            this.btnViewCustomer.Text = "View Customer Details";
            this.btnViewCustomer.UseVisualStyleBackColor = false;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnViewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewBooking.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewBooking.FlatAppearance.BorderSize = 0;
            this.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewBooking.Font = new System.Drawing.Font("Monotype Corsiva", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewBooking.Location = new System.Drawing.Point(4, 193);
            this.btnViewBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(197, 180);
            this.btnViewBooking.TabIndex = 4;
            this.btnViewBooking.Text = "View Booking Details";
            this.btnViewBooking.UseVisualStyleBackColor = false;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // HolidayBtn
            // 
            this.HolidayBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HolidayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HolidayBtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.HolidayBtn.FlatAppearance.BorderSize = 0;
            this.HolidayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HolidayBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolidayBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HolidayBtn.Location = new System.Drawing.Point(411, 5);
            this.HolidayBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HolidayBtn.Name = "HolidayBtn";
            this.HolidayBtn.Size = new System.Drawing.Size(197, 178);
            this.HolidayBtn.TabIndex = 5;
            this.HolidayBtn.Text = "Holiday Destinations";
            this.HolidayBtn.UseVisualStyleBackColor = false;
            this.HolidayBtn.Click += new System.EventHandler(this.HolidayBtn_Click);
            // 
            // AbtBtn
            // 
            this.AbtBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AbtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbtBtn.BackgroundImage = global::DabAgent.Properties.Resources.abt;
            this.AbtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AbtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AbtBtn.Location = new System.Drawing.Point(3, 5);
            this.AbtBtn.Name = "AbtBtn";
            this.AbtBtn.Size = new System.Drawing.Size(401, 180);
            this.AbtBtn.TabIndex = 0;
            this.AbtBtn.UseVisualStyleBackColor = false;
            this.AbtBtn.Click += new System.EventHandler(this.AbtBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.AbtBtn);
            this.flowLayoutPanel1.Controls.Add(this.HolidayBtn);
            this.flowLayoutPanel1.Controls.Add(this.btnViewBooking);
            this.flowLayoutPanel1.Controls.Add(this.btnViewCustomer);
            this.flowLayoutPanel1.Controls.Add(this.ExitBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(616, 380);
            this.flowLayoutPanel1.TabIndex = 90;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DabAgent.Properties.Resources.background_rakyat_travel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(701, 505);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button btnViewBooking;
        private System.Windows.Forms.Button HolidayBtn;
        private System.Windows.Forms.Button AbtBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}