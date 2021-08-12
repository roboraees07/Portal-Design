using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Portal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string UserName = "comsats";
       string User_Password = "comsats123";

        

        private void LoginCon()
        {
            if (User_Name_txt.Text == UserName && Password_txt.Text == User_Password)
            {
                 Home homePage = new Home();
                 this.Hide();
                 homePage.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please enter Correct User Name OR Password", "Invalid User Name Or Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        //********** Changing the cursor when pressing Enter Key **********

        private void Login_Button_Click(object sender, EventArgs e)
        {
            LoginCon();
        }

        private void User_Name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password_txt.Focus();
            }
        }

        private void Password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginCon();
            }

        }



        // *****  Adding Show and Hide Password Option
        private void ShowPic_Click(object sender, EventArgs e)
        {
            ShowPic.Hide();
            HidePic.Show();
            Password_txt.PasswordChar = '\0';
        }

        private void HidePic_Click(object sender, EventArgs e)
        {
            ShowPic.Show();
            HidePic.Hide();
            Password_txt.PasswordChar = '*';

        }
    }
}
