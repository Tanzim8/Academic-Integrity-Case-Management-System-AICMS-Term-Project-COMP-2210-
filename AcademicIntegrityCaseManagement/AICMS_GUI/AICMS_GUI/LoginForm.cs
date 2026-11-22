
using System;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace AICMS_GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            btnLogin.Enabled = false;

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

                string request = JsonSerializer.Serialize(new
                {
                    action = "login",
                    username = username,
                    password = password
                });

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

                if (success)
                {
                    string userId = result.RootElement
                        .GetProperty("user_id").GetString() ?? "";

                    string name = result.RootElement
                        .GetProperty("name").GetString() ?? "";

                    string role = result.RootElement
                        .GetProperty("role").GetString() ?? "";

                    if (role == "Student")
                    {
                        StudentDashboard dashboard =
                            new StudentDashboard(userId, name);

                        this.Hide();
                        try
                        {
                            dashboard.ShowDialog();
                        }
                        finally
                        {
                            this.Show();
                            txtPassword.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Welcome " + name +
                            "\nRole: " + role
                        );
                    }
                }
                else
                {
                    string message = result.RootElement
                        .GetProperty("message").GetString()
                        ?? "Invalid username or password.";

                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistraterForm registerForm = new RegistraterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
