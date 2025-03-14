using Bernabe_Allysa_Act_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bernabe_Allysa_Act_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Allysa Marie C. Bernabe";
            StudentAgeLabel.Text = "21";
            StudentAddressLabel.Text = "San Juan, Alcala";
            StudentContactLabel.Text = "09158682440";
            StudentEmailLabel.Text = "email@unique.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Shirley Bernabe";
            ParentContactLabel.Text = "09497885810";
            HobbiesLabel.Text = "Reading, Singing";
            NicknameLabel.Text = "Ally";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}
