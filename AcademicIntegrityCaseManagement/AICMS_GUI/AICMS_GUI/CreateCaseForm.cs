
using System;
using System.IO;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace AICMS_GUI
{
    public partial class CreateCaseForm : Form
    {
        private string facultyId = "";
        private string facultyName = "";

        public CreateCaseForm()
        {
            InitializeComponent();

            btnSaveCase.Click += btnSaveCase_Click;
            btnCancel.Click += btnCancel_Click;
        }

        public CreateCaseForm(string userId, string name)
            : this()
        {
            facultyId = userId;
            facultyName = name;

            txtFacultyName.Text = facultyName;
            txtFacultyName.ReadOnly = true;
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private string? GetOptionalDate(DateTimePicker picker)
        {
            return picker.Checked
                ? picker.Value.ToString("yyyy-MM-dd")
                : null;
        }

        private int? GetAgreement(CheckBox checkbox)
        {
            if (checkbox.CheckState == CheckState.Indeterminate)
                return null;

            return checkbox.Checked ? 1 : 0;
        }

        private async void btnSaveCase_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text) ||
                string.IsNullOrWhiteSpace(txtTerm.Text) ||
                string.IsNullOrWhiteSpace(txtAssignment.Text) ||
                string.IsNullOrWhiteSpace(txtViolation.Text))
            {
                MessageBox.Show("Please complete the required faculty report fields.");
                tabControl1.SelectedTab = tabFaculty;
                return;
            }

            if (string.IsNullOrWhiteSpace(facultyId))
            {
                MessageBox.Show("Faculty account was not identified.");
                return;
            }

            var caseInfo = new
            {
                // Tab 1 - Faculty Report
                student_id = txtStudentId.Text.Trim(),
                faculty_id = facultyId,
                student_name = txtStudentName.Text.Trim(),
                student_email = txtStudentEmail.Text.Trim(),
                faculty_name = facultyName,

                course = txtCourse.Text.Trim(),
                term = txtTerm.Text.Trim(),
                assignment_number = txtAssignment.Text.Trim(),
                case_department = txtDepartment.Text.Trim(),

                report_date = dtpReportDate.Value.ToString("yyyy-MM-dd"),
                violation_date = dtpReportDate.Value.ToString("yyyy-MM-dd"),

                ed_violation_description = txtViolation.Text.Trim(),

                support_person_advised = chkSupportPerson.Checked ? 1 : 0,
                written_statement_advised = chkWrittenStatement.Checked ? 1 : 0,

                faculty_signature = txtFacultySignature.Text.Trim(),
                faculty_signature_date = string.IsNullOrWhiteSpace(
                    txtFacultySignature.Text)
                    ? null
                    : dtpSignatureDate.Value.ToString("yyyy-MM-dd"),

                // Tab 2 - Student Acknowledgement
                student_acknowledgement_name = txtStudentAckName.Text.Trim(),
                evidence_reviewed = chkEvidenceReviewed.Checked ? 1 : 0,
                mytru_email = txtMyTruEmail.Text.Trim(),
                student_signature = txtStudentSignature.Text.Trim(),

                student_signature_date =
                    GetOptionalDate(dtpStudentSignatureDate),

                // Faculty Follow-up
                faculty_followup_name = txtFacultyFollowupName.Text.Trim(),
                faculty_followup_signature = txtFacultyFollowupSignature.Text.Trim(),

                faculty_followup_date =
                    GetOptionalDate(dtpFacultyFollowupDate),

                // Tab 3 - Chair Review
                chair_agrees = GetAgreement(chkChairAgrees),
                chair_name = txtChairName.Text.Trim(),
                chair_comments = txtChairComments.Text.Trim(),
                chair_signature = txtChairSignature.Text.Trim(),
                chair_date = GetOptionalDate(dtpChairDate),

                // Dean Review
                dean_agrees = GetAgreement(chkDeanAgrees),
                dean_name = txtDeanName.Text.Trim(),
                dean_comments = txtDeanComments.Text.Trim(),
                dean_signature = txtDeanSignature.Text.Trim(),
                dean_date = GetOptionalDate(dtpDeanDate),

                // Tab 4 - Faculty Comments
                faculty_comments = txtFacultyComments.Text.Trim(),

                // Tab 5 - Student Comments
                student_comments = txtStudentComments.Text.Trim()
            };

            string request = JsonSerializer.Serialize(new
            {
                action = "create_case",
                case_info = caseInfo
            });

            btnSaveCase.Enabled = false;
            btnCancel.Enabled = false;

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

                if (!File.Exists(Path.Combine(backendPath, "bridge.py")))
                {
                    MessageBox.Show("bridge.py was not found.");
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

                var outputTask = process.StandardOutput.ReadToEndAsync();
                var errorTask = process.StandardError.ReadToEndAsync();

                await process.StandardInput.WriteLineAsync(request);
                process.StandardInput.Close();

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

                if (success)
                {
                    int caseId = result.RootElement
                        .GetProperty("case_id").GetInt32();

                    MessageBox.Show(
                        "Case created successfully!\nCase ID: " + caseId
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                btnSaveCase.Enabled = true;
                btnCancel.Enabled = true;
            }
        }
    }
}
