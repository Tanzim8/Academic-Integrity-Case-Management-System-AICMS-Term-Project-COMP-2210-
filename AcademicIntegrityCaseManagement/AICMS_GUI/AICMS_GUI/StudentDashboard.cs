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
    public partial class StudentDashboard : Form
    {
        private readonly string studentId;
        private readonly string studentName;
        public StudentDashboard(string userId, string name)
        {
            InitializeComponent();

            studentId = userId;
            studentName = name;

            //display mssge with std name
            lblWelcome.Text = "Welcome, " + studentName + "!";
        }

        private async void StudentDashboard_Load(object sender, EventArgs e)
        {
            // Load student cases when the dashboard loads
            //LoadStudentCases();
            await LoadStudentCases();
        }


        private async Task LoadStudentCases()
        {
            btnRefresh.Enabled = false;

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
                    action = "student_cases",
                    student_id = studentId
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

                if (!success)
                {
                    string message = result.RootElement
                        .GetProperty("message").GetString() ?? "Unable to load cases.";

                    MessageBox.Show(message);
                    return;
                }

                DataTable table = new DataTable();

                table.Columns.Add("Case ID");
                table.Columns.Add("Term");
                table.Columns.Add("Assignment");
                table.Columns.Add("Violation");
                table.Columns.Add("Date");

                JsonElement cases = result.RootElement.GetProperty("cases");

                foreach (JsonElement record in cases.EnumerateArray())
                {
                    table.Rows.Add(
                        record[0].ToString(),
                        record[5].ToString(),
                        record[6].ToString(),
                        record[7].ToString(),
                        record[8].ToString()
                    );
                }

                dvgCases.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cases: " + ex.Message);
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadStudentCases();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
