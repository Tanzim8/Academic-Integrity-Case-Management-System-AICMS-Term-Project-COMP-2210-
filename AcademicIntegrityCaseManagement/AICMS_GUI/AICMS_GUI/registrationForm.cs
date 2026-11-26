using System;
using System.IO;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICMS_GUI
{
    public partial class RegistraterForm : Form
    {
        public RegistraterForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
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
            if (string.IsNullOrWhiteSpace(userId) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(department) ||
                string.IsNullOrWhiteSpace(userType) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
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

            string request = JsonSerializer.Serialize(registrationData);

            btnRegister.Enabled = false;

            try
            {
                // Dynamically locate the backend folder
                string backendPath = Path.GetFullPath(
                    Path.Combine(
                        AppContext.BaseDirectory,
                        "..", "..", "..", "..", ".."
                    )
                );

                // Locate Python on the university computer
                string pythonPath = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData),
                    "Programs", "Python", "Python314", "python.exe"
                );

                // Alternative path for personal desktop
                if (!File.Exists(pythonPath))
                {
                    pythonPath = @"C:\Python314\python.exe";
                }

                if (!File.Exists(pythonPath))
                {
                    MessageBox.Show("Python executable was not found.");
                    return;
                }

                if (!File.Exists(Path.Combine(backendPath, "bridge.py")))
                {
                    MessageBox.Show("bridge.py was not found in the backend folder.");
                    return;
                }

                ProcessStartInfo psi = new ProcessStartInfo();

                psi.FileName = pythonPath;
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