using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class newStudent: Form
    {
        public newStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string studentNo = txtStudenNo.Text.Trim();
            string course = cbCourse.SelectedItem?.ToString() ?? "Not selected";
            string yearLevel = cbYearLevel.SelectedItem?.ToString() ?? "Not selected";
            string email = txtEmail.Text.Trim();
            string gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "Not selected");
            string message = $"Name: {name}\n" +
                             $"Student No.: {studentNo}\n" +
                             $"Course: {course}\n" +
                             $"Year Level: {yearLevel}\n" +
                             $"Gender: {gender}\n" +
                             $"Email: {email}";

            MessageBox.Show(message, "Student Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStudenNo.Clear();
            cbCourse.SelectedIndex = -1;
            cbYearLevel.SelectedIndex = -1;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtEmail.Clear();
        }
    }
}
