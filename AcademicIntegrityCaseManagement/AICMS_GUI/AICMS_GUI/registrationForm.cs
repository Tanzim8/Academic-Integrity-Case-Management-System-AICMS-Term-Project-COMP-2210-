using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.Json;

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

        private async void btnRegister_Click(object sender, EventArgs e)
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
            //MessageBox.Show("Registration successful!");
            var registrationData = new
            {
                action = "register",
                user_id = userId,
                name = fullName,
                email = email,
                department = department,
                user_type = userType,
                username = username,
                password = password
            };

            string request = System.Text.Json.JsonSerializer.Serialize(registrationData);
            btnRegister.Enabled = false;

            try
            {
                string backendPath =
                    @"C:\Users\user\source\repos\Academic-Integrity-Case-Management-System-AICMS-Term-Project-COMP-2210-\AcademicIntegrityCaseManagement";

                ProcessStartInfo psi = new ProcessStartInfo();

                psi.FileName = @"C:\Python314\python.exe";
                psi.Arguments = "bridge.py";
                psi.WorkingDirectory = backendPath;

                psi.UseShellExecute = false;
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.CreateNoWindow = true;

                using Process process = Process.Start(psi)!;

                await process.StandardInput.WriteLineAsync(request);
                process.StandardInput.Close();

                var outputTask = process.StandardOutput.ReadToEndAsync();
                var errorTask = process.StandardError.ReadToEndAsync();

                await process.WaitForExitAsync();

                string response = await outputTask;
                string error = await errorTask;

                if (process.ExitCode != 0)
                {
                    MessageBox.Show("Python error: " + error);
                    return;
                }

                using JsonDocument result = JsonDocument.Parse(response);

                bool success = result.RootElement
                    .GetProperty("success").GetBoolean();

                string message = result.RootElement
                    .GetProperty("message").GetString() ?? "";

                MessageBox.Show(message);

                if (success)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnRegister.Enabled = true;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
