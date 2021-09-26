
namespace MonitorVersion1
{
    partial class Alarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel3 = new MonitorVersion1.CustemItems.CustomPanel();
            this.txbFromUser = new MonitorVersion1.CustemItems.customTextBox();
            this.txbFromPass = new MonitorVersion1.CustemItems.customTextBox();
            this.customPanel2 = new MonitorVersion1.CustemItems.CustomPanel();
            this.txbToUser2 = new MonitorVersion1.CustemItems.customTextBox();
            this.customPanel1 = new MonitorVersion1.CustemItems.CustomPanel();
            this.btnToggle = new MonitorVersion1.CustomItems.customToggleButton();
            this.btnSaveChange = new MonitorVersion1.CustemItems.CustomButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txbToUser = new MonitorVersion1.CustomItems.customTextBox1();
            this.panel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Alarm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 153);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email Sender (From)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(567, 141);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Reciever (To)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customPanel3);
            this.panel1.Controls.Add(this.customPanel2);
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Controls.Add(this.btnSaveChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 850);
            this.panel1.TabIndex = 8;
            // 
            // customPanel3
            // 
            this.customPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.customPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.customPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel3.BorderRadius = 20;
            this.customPanel3.BorderSize = 0;
            this.customPanel3.Controls.Add(this.label3);
            this.customPanel3.Controls.Add(this.txbFromUser);
            this.customPanel3.Controls.Add(this.txbFromPass);
            this.customPanel3.ForeColor = System.Drawing.Color.White;
            this.customPanel3.Location = new System.Drawing.Point(149, 503);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1218, 183);
            this.customPanel3.TabIndex = 9;
            this.customPanel3.TextColor = System.Drawing.Color.White;
            // 
            // txbFromUser
            // 
            this.txbFromUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFromUser.BackColor = System.Drawing.SystemColors.Window;
            this.txbFromUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbFromUser.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbFromUser.BorderSize = 2;
            this.txbFromUser.Font = new System.Drawing.Font("Cambria", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFromUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbFromUser.Location = new System.Drawing.Point(747, 42);
            this.txbFromUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFromUser.Multiline = false;
            this.txbFromUser.Name = "txbFromUser";
            this.txbFromUser.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txbFromUser.PasswordChar = false;
            this.txbFromUser.Size = new System.Drawing.Size(249, 38);
            this.txbFromUser.TabIndex = 5;
            this.txbFromUser.Texts = "vietmapenv.alarm@gmail.com";
            this.txbFromUser.UnderlinedStyle = false;
            // 
            // txbFromPass
            // 
            this.txbFromPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFromPass.BackColor = System.Drawing.SystemColors.Window;
            this.txbFromPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbFromPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbFromPass.BorderSize = 2;
            this.txbFromPass.Font = new System.Drawing.Font("Cambria", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFromPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbFromPass.Location = new System.Drawing.Point(747, 100);
            this.txbFromPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFromPass.Multiline = false;
            this.txbFromPass.Name = "txbFromPass";
            this.txbFromPass.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txbFromPass.PasswordChar = false;
            this.txbFromPass.Size = new System.Drawing.Size(249, 38);
            this.txbFromPass.TabIndex = 6;
            this.txbFromPass.Texts = "**********";
            this.txbFromPass.UnderlinedStyle = false;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.customPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.customPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel2.BorderRadius = 20;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.txbToUser);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Controls.Add(this.txbToUser2);
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(149, 273);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1218, 183);
            this.customPanel2.TabIndex = 9;
            this.customPanel2.TextColor = System.Drawing.Color.White;
            // 
            // txbToUser2
            // 
            this.txbToUser2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbToUser2.BackColor = System.Drawing.SystemColors.Window;
            this.txbToUser2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbToUser2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbToUser2.BorderSize = 2;
            this.txbToUser2.Font = new System.Drawing.Font("Cambria", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbToUser2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbToUser2.Location = new System.Drawing.Point(596, 108);
            this.txbToUser2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbToUser2.Multiline = false;
            this.txbToUser2.Name = "txbToUser2";
            this.txbToUser2.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txbToUser2.PasswordChar = false;
            this.txbToUser2.Size = new System.Drawing.Size(249, 38);
            this.txbToUser2.TabIndex = 7;
            this.txbToUser2.Texts = "User@gmail.com";
            this.txbToUser2.UnderlinedStyle = false;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.customPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.customPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel1.BorderRadius = 20;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.btnToggle);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(149, 36);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1218, 183);
            this.customPanel1.TabIndex = 9;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggle.Location = new System.Drawing.Point(818, 55);
            this.btnToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.OffBackColor = System.Drawing.Color.Gray;
            this.btnToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnToggle.OnBackColor = System.Drawing.Color.Red;
            this.btnToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggle.Size = new System.Drawing.Size(125, 62);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.UseVisualStyleBackColor = true;
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChange.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveChange.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnSaveChange.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaveChange.BorderRadius = 10;
            this.btnSaveChange.BorderSize = 0;
            this.btnSaveChange.FlatAppearance.BorderSize = 0;
            this.btnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChange.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnSaveChange.Location = new System.Drawing.Point(1068, 724);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(299, 73);
            this.btnSaveChange.TabIndex = 8;
            this.btnSaveChange.Text = "Save Change";
            this.btnSaveChange.TextColor = System.Drawing.Color.White;
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txbToUser
            // 
            this.txbToUser.BackColor = System.Drawing.SystemColors.Window;
            this.txbToUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbToUser.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbToUser.BorderRadius = 10;
            this.txbToUser.BorderSize = 2;
            this.txbToUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbToUser.ForeColor = System.Drawing.Color.Black;
            this.txbToUser.Location = new System.Drawing.Point(628, 44);
            this.txbToUser.Multiline = false;
            this.txbToUser.Name = "txbToUser";
            this.txbToUser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbToUser.PasswordChar = false;
            this.txbToUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbToUser.PlaceholderText = "Username@gmail.com";
            this.txbToUser.Size = new System.Drawing.Size(300, 36);
            this.txbToUser.TabIndex = 2;
            this.txbToUser.Texts = "";
            this.txbToUser.UnderlinedStyle = false;
            this.txbToUser.Load += new System.EventHandler(this.customTextBox11_Load);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 850);
            this.Controls.Add(this.panel1);
            this.Name = "Alarm";
            this.Text = "Alarm Setting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.panel1.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomItems.customToggleButton btnToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustemItems.customTextBox txbFromUser;
        private CustemItems.customTextBox txbFromPass;
        private CustemItems.customTextBox txbToUser2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private CustemItems.CustomButton btnSaveChange;
        private CustemItems.CustomPanel customPanel3;
        private CustemItems.CustomPanel customPanel2;
        private CustemItems.CustomPanel customPanel1;
        private CustomItems.customTextBox1 txbToUser;
    }
}