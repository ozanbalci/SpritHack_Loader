namespace Spirthack_loader
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.usernameTXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Panel();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.load.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTXT
            // 
            this.usernameTXT.Animated = true;
            this.usernameTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.usernameTXT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.usernameTXT.BorderRadius = 5;
            this.usernameTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTXT.DefaultText = "";
            this.usernameTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTXT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.usernameTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.usernameTXT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameTXT.ForeColor = System.Drawing.Color.White;
            this.usernameTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.usernameTXT.Location = new System.Drawing.Point(37, 271);
            this.usernameTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.PasswordChar = '\0';
            this.usernameTXT.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(189)))));
            this.usernameTXT.PlaceholderText = "Username";
            this.usernameTXT.SelectedText = "";
            this.usernameTXT.Size = new System.Drawing.Size(390, 44);
            this.usernameTXT.TabIndex = 1;
            this.usernameTXT.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // passwordTXT
            // 
            this.passwordTXT.Animated = true;
            this.passwordTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.passwordTXT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.passwordTXT.BorderRadius = 5;
            this.passwordTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTXT.DefaultText = "";
            this.passwordTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTXT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.passwordTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.passwordTXT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTXT.ForeColor = System.Drawing.Color.White;
            this.passwordTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.passwordTXT.Location = new System.Drawing.Point(37, 338);
            this.passwordTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(189)))));
            this.passwordTXT.PlaceholderText = "Password";
            this.passwordTXT.SelectedText = "";
            this.passwordTXT.Size = new System.Drawing.Size(390, 42);
            this.passwordTXT.TabIndex = 2;
            this.passwordTXT.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Spirthack_loader.Properties.Resources.ezgif_com_gif_maker;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(112, 64);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(224, 49);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = global::Spirthack_loader.Properties.Resources.in_new_close;
            this.guna2ImageButton1.Image = global::Spirthack_loader.Properties.Resources.close_512px;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.Location = new System.Drawing.Point(407, 27);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::Spirthack_loader.Properties.Resources.in_new_close;
            this.guna2ImageButton1.Size = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.TabStop = false;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(89)))), ((int)(((byte)(222)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(245)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(148, 528);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(147, 54);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Login";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Invalid login or passsword.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Invalid License.";
            // 
            // load
            // 
            this.load.Controls.Add(this.guna2WinProgressIndicator1);
            this.load.Location = new System.Drawing.Point(12, 12);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(425, 624);
            this.load.TabIndex = 8;
            this.load.Visible = false;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(181, 279);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(89)))), ((int)(((byte)(222)))));
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(86, 71);
            this.guna2WinProgressIndicator1.TabIndex = 0;
            this.guna2WinProgressIndicator1.UseTransparentBackground = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(449, 648);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.usernameTXT);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.load.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox usernameTXT;
        private Guna.UI2.WinForms.Guna2TextBox passwordTXT;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel load;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

