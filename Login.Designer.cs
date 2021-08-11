namespace Web_Portal
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.User_Name_txt = new System.Windows.Forms.TextBox();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Forget_Password = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.HidePic = new System.Windows.Forms.PictureBox();
            this.ShowPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Web_Portal.Properties.Resources.Comsats_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // User_Name_txt
            // 
            this.User_Name_txt.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_txt.Location = new System.Drawing.Point(267, 124);
            this.User_Name_txt.Name = "User_Name_txt";
            this.User_Name_txt.Size = new System.Drawing.Size(193, 31);
            this.User_Name_txt.TabIndex = 1;
            this.User_Name_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.User_Name_txt_KeyDown);
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.BackColor = System.Drawing.Color.Transparent;
            this.UserName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.ForeColor = System.Drawing.SystemColors.Info;
            this.UserName_label.Location = new System.Drawing.Point(126, 132);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(135, 25);
            this.UserName_label.TabIndex = 3;
            this.UserName_label.Text = "User Name:";
            // 
            // Forget_Password
            // 
            this.Forget_Password.AutoSize = true;
            this.Forget_Password.BackColor = System.Drawing.Color.Transparent;
            this.Forget_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forget_Password.ForeColor = System.Drawing.Color.Red;
            this.Forget_Password.Location = new System.Drawing.Point(346, 219);
            this.Forget_Password.Name = "Forget_Password";
            this.Forget_Password.Size = new System.Drawing.Size(114, 15);
            this.Forget_Password.TabIndex = 5;
            this.Forget_Password.Text = "Forget Password";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Login_Button.Location = new System.Drawing.Point(267, 246);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(193, 48);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "LOGIN";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.BackColor = System.Drawing.Color.Transparent;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.SystemColors.Info;
            this.Password_label.Location = new System.Drawing.Point(126, 177);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(121, 25);
            this.Password_label.TabIndex = 7;
            this.Password_label.Text = "Password:";
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(267, 177);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(193, 31);
            this.Password_txt.TabIndex = 8;
            this.Password_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_txt_KeyDown);
            // 
            // HidePic
            // 
            this.HidePic.BackColor = System.Drawing.Color.White;
            this.HidePic.Image = global::Web_Portal.Properties.Resources.show_hide_password_10_512;
            this.HidePic.Location = new System.Drawing.Point(437, 187);
            this.HidePic.Name = "HidePic";
            this.HidePic.Size = new System.Drawing.Size(17, 15);
            this.HidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HidePic.TabIndex = 9;
            this.HidePic.TabStop = false;
            this.HidePic.Click += new System.EventHandler(this.HidePic_Click);
            // 
            // ShowPic
            // 
            this.ShowPic.BackColor = System.Drawing.Color.White;
            this.ShowPic.Image = global::Web_Portal.Properties.Resources.show_hide_password_03_512;
            this.ShowPic.Location = new System.Drawing.Point(437, 187);
            this.ShowPic.Name = "ShowPic";
            this.ShowPic.Size = new System.Drawing.Size(17, 15);
            this.ShowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowPic.TabIndex = 10;
            this.ShowPic.TabStop = false;
            this.ShowPic.Click += new System.EventHandler(this.ShowPic_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Web_Portal.Properties.Resources.Comsats_Abbottabad_Campus;
            this.ClientSize = new System.Drawing.Size(600, 321);
            this.Controls.Add(this.ShowPic);
            this.Controls.Add(this.HidePic);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Forget_Password);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.User_Name_txt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox User_Name_txt;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label UserName_label;
        //private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Label Forget_Password;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.PictureBox HidePic;
        private System.Windows.Forms.PictureBox ShowPic;
    }
}

