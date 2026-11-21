using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICMS_GUI
{
    public partial class RegistraterForm : Form
    {
        public RegistraterForm()
        {
            InitializeComponent();
        }

        private void userType_Click(object sender, EventArgs e)
        {

        }

        private void confirmPass_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string department = txtDepartment.Text.Trim();
            string userType = cmbUserType.Text;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate input fields
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(department) || string.IsNullOrEmpty(userType) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            if (userType != "Student" && userType != "Faculty")
            {
                MessageBox.Show("Please select a valid user type.");
                return;
            }
            MessageBox.Show("Registration successful!");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
