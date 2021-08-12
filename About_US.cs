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
    public partial class About_US : Form
    {
        public About_US()
        {
            InitializeComponent();
        }

        private void Homepg()
        {
            Home homePage = new Home();
            this.Hide();
            homePage.ShowDialog();

        }

        private void Aboutuspg()
        {
            About_US AboutPage = new About_US();
            this.Hide();
            AboutPage.ShowDialog();
        }

        private void Programpg()
        {
            Programs ProgramPage = new Programs();
            this.Hide();
            ProgramPage.ShowDialog();
        }

        private void Scholarship_pg()
        {
            Scholarships Scholarship_Page = new Scholarships();
            this.Hide();
            Scholarship_Page.ShowDialog();
        }

        private void Admissionpg()
        {
            Admission Admission_Page = new Admission();
            this.Hide();
            Admission_Page.ShowDialog();
        }

        private void ContactUspg()
        {
            Contact_Us ContactUs_Page = new Contact_Us();
            this.Hide();
            ContactUs_Page.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homepg();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aboutuspg();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admissionpg();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUspg();
        }
    }
}
