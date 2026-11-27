using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICMS_GUI
{
    public partial class FacultyDashboard : Form
    {
        private string facultyId;
        private string facultyName;

        public FacultyDashboard(string userId, string name)
        {
            InitializeComponent();

            facultyId = userId;
            facultyName = name;

            lblWelcome.Text = "Welcome, " + facultyName + "!";

            btnLogout.Click += btnLogout_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnCreateCase.Click += btnCreateCase_Click;

            Load += FacultyDashboard_Load;
        }

        private void btnCreateCase_Click(object? sender, EventArgs e)
        {
            using CreateCaseForm form = new CreateCaseForm();
            form.ShowDialog();
        }

        private async Task LoadFacultyCases()
        {
            btnRefresh.Enabled = false;

            try
            {
                string backendPath = Path.GetFullPath(
                    Path.Combine(
                        AppContext.BaseDirectory,
                        "..", "..", "..", "..", ".."
                    )
                );

                string pythonPath = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData),
                    "Programs", "Python", "Python314", "python.exe"
                );

                if (!File.Exists(pythonPath))
                {
                    pythonPath = @"C:\Python314\python.exe";
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

                if (!File.Exists(Path.Combine(backendPath, "bridge.py")))
                {
                    MessageBox.Show("bridge.py was not found.");
                    return;
                }

                using Process process = Process.Start(psi)!;

                string request = JsonSerializer.Serialize(new
                {
                    action = "faculty_cases",
                    faculty_id = facultyId
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
                    MessageBox.Show(
                        result.RootElement
                        .GetProperty("message").GetString()
                    );
                    return;
                }

                dvgCases.Rows.Clear();
                dvgCases.Columns.Clear();

                dvgCases.Columns.Add("Case ID", "Case ID");
                dvgCases.Columns.Add("Student ID", "Student ID");
                dvgCases.Columns.Add("Term", "Term");
                dvgCases.Columns.Add("Assignment", "Assignment");
                dvgCases.Columns.Add("Violation", "Violation");
                dvgCases.Columns.Add("Date", "Date");

                foreach (JsonElement record in result.RootElement
                    .GetProperty("cases").EnumerateArray())
                {
                    dvgCases.Rows.Add(
                        record[0].ToString(),
                        record[1].ToString(),
                        record[2].ToString(),
                        record[3].ToString(),
                        record[4].ToString(),
                        record[5].ToString()
                    );
                }
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

        private async void FacultyDashboard_Load(object sender, EventArgs e)
        {
            await LoadFacultyCases();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadFacultyCases();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}