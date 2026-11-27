namespace AICMS_GUI
{
    partial class CreateCaseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();

            tabFaculty = new TabPage();
            tabStudent = new TabPage();
            tabReview = new TabPage();
            tabFacultyComments = new TabPage();
            tabStudentComments = new TabPage();

            lblTitle = new Label();
            lblSubtitle = new Label();

            lblStudentName = new Label();
            lblStudentId = new Label();
            lblStudentEmail = new Label();
            lblFacultyName = new Label();
            lblReportDate = new Label();
            lblCourse = new Label();
            lblAssignment = new Label();
            lblDepartment = new Label();
            lblTerm = new Label();
            lblViolation = new Label();
            lblFacultySignature = new Label();
            lblSignatureDate = new Label();

            txtStudentName = new TextBox();
            txtStudentId = new TextBox();
            txtStudentEmail = new TextBox();
            txtFacultyName = new TextBox();
            txtCourse = new TextBox();
            txtAssignment = new TextBox();
            txtDepartment = new TextBox();
            txtTerm = new TextBox();
            txtViolation = new TextBox();
            txtFacultySignature = new TextBox();

            dtpReportDate = new DateTimePicker();
            dtpSignatureDate = new DateTimePicker();

            chkSupportPerson = new CheckBox();
            chkWrittenStatement = new CheckBox();

            tabControl1.SuspendLayout();
            tabFaculty.SuspendLayout();
            SuspendLayout();

            // Tab Control
            tabControl1.Name = "tabControl1";
            tabControl1.Dock = DockStyle.Fill;

            tabControl1.Controls.Add(tabFaculty);
            tabControl1.Controls.Add(tabStudent);
            tabControl1.Controls.Add(tabReview);
            tabControl1.Controls.Add(tabFacultyComments);
            tabControl1.Controls.Add(tabStudentComments);

            // Tab 1
            tabFaculty.Name = "tabFaculty";
            tabFaculty.Text = "Faculty Report";
            tabFaculty.BackColor = Color.White;
            tabFaculty.AutoScroll = true;

            // Tab 2
            tabStudent.Name = "tabStudent";
            tabStudent.Text = "Student & Faculty";
            tabStudent.BackColor = Color.White;

            // Tab 3
            tabReview.Name = "tabReview";
            tabReview.Text = "Chair & Dean";
            tabReview.BackColor = Color.White;

            // Tab 4
            tabFacultyComments.Name = "tabFacultyComments";
            tabFacultyComments.Text = "Faculty Comments";
            tabFacultyComments.BackColor = Color.White;

            // Tab 5
            tabStudentComments.Name = "tabStudentComments";
            tabStudentComments.Text = "Student Comments";
            tabStudentComments.BackColor = Color.White;

            // Title
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Academic Integrity Policy ED 5-0";
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(25, 20);
            lblTitle.AutoSize = true;

            // Subtitle
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "Step One - To be completed by Faculty Member";
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.Location = new Point(25, 60);
            lblSubtitle.AutoSize = true;

            // Student Name
            lblStudentName.Text = "Student Name";
            lblStudentName.Location = new Point(25, 105);
            lblStudentName.AutoSize = true;

            txtStudentName.Name = "txtStudentName";
            txtStudentName.Location = new Point(25, 130);
            txtStudentName.Size = new Size(260, 25);

            // Student Number
            lblStudentId.Text = "Student Number";
            lblStudentId.Location = new Point(320, 105);
            lblStudentId.AutoSize = true;

            txtStudentId.Name = "txtStudentId";
            txtStudentId.Location = new Point(320, 130);
            txtStudentId.Size = new Size(260, 25);

            // Student Email
            lblStudentEmail.Text = "Student Email";
            lblStudentEmail.Location = new Point(615, 105);
            lblStudentEmail.AutoSize = true;

            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Location = new Point(615, 130);
            txtStudentEmail.Size = new Size(260, 25);

            // Faculty Name
            lblFacultyName.Text = "Faculty Member Name";
            lblFacultyName.Location = new Point(25, 175);
            lblFacultyName.AutoSize = true;

            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Location = new Point(25, 200);
            txtFacultyName.Size = new Size(260, 25);

            // Report Date
            lblReportDate.Text = "Report Date";
            lblReportDate.Location = new Point(320, 175);
            lblReportDate.AutoSize = true;

            dtpReportDate.Name = "dtpReportDate";
            dtpReportDate.Location = new Point(320, 200);
            dtpReportDate.Size = new Size(260, 25);
            dtpReportDate.Format = DateTimePickerFormat.Short;

            // Course
            lblCourse.Text = "Course Name and Number";
            lblCourse.Location = new Point(615, 175);
            lblCourse.AutoSize = true;

            txtCourse.Name = "txtCourse";
            txtCourse.Location = new Point(615, 200);
            txtCourse.Size = new Size(260, 25);

            // Assignment
            lblAssignment.Text = "Assignment Number or Exam";
            lblAssignment.Location = new Point(25, 245);
            lblAssignment.AutoSize = true;

            txtAssignment.Name = "txtAssignment";
            txtAssignment.Location = new Point(25, 270);
            txtAssignment.Size = new Size(260, 25);

            // Department
            lblDepartment.Text = "Department";
            lblDepartment.Location = new Point(320, 245);
            lblDepartment.AutoSize = true;

            txtDepartment.Name = "txtDepartment";
            txtDepartment.Location = new Point(320, 270);
            txtDepartment.Size = new Size(260, 25);

            // Term
            lblTerm.Text = "Term or Semester";
            lblTerm.Location = new Point(615, 245);
            lblTerm.AutoSize = true;

            txtTerm.Name = "txtTerm";
            txtTerm.Location = new Point(615, 270);
            txtTerm.Size = new Size(260, 25);

            // Violation Description
            lblViolation.Text = "Description of Academic Integrity Violation";
            lblViolation.Location = new Point(25, 320);
            lblViolation.AutoSize = true;

            txtViolation.Name = "txtViolation";
            txtViolation.Location = new Point(25, 350);
            txtViolation.Size = new Size(850, 130);
            txtViolation.Multiline = true;
            txtViolation.ScrollBars = ScrollBars.Vertical;

            // Support Person
            chkSupportPerson.Name = "chkSupportPerson";
            chkSupportPerson.Text =
                "Student advised that they may bring a support person.";
            chkSupportPerson.Location = new Point(25, 500);
            chkSupportPerson.AutoSize = true;

            // Written Statement
            chkWrittenStatement.Name = "chkWrittenStatement";
            chkWrittenStatement.Text =
                "Student advised that they may submit a written statement.";
            chkWrittenStatement.Location = new Point(25, 535);
            chkWrittenStatement.AutoSize = true;

            // Faculty Signature
            lblFacultySignature.Text = "Faculty Signature";
            lblFacultySignature.Location = new Point(25, 580);
            lblFacultySignature.AutoSize = true;

            txtFacultySignature.Name = "txtFacultySignature";
            txtFacultySignature.Location = new Point(25, 605);
            txtFacultySignature.Size = new Size(400, 25);

            // Signature Date
            lblSignatureDate.Text = "Signature Date";
            lblSignatureDate.Location = new Point(475, 580);
            lblSignatureDate.AutoSize = true;

            dtpSignatureDate.Name = "dtpSignatureDate";
            dtpSignatureDate.Location = new Point(475, 605);
            dtpSignatureDate.Size = new Size(260, 25);
            dtpSignatureDate.Format = DateTimePickerFormat.Short;

            // Add controls to Faculty Report tab
            tabFaculty.Controls.Add(lblTitle);
            tabFaculty.Controls.Add(lblSubtitle);

            tabFaculty.Controls.Add(lblStudentName);
            tabFaculty.Controls.Add(txtStudentName);

            tabFaculty.Controls.Add(lblStudentId);
            tabFaculty.Controls.Add(txtStudentId);

            tabFaculty.Controls.Add(lblStudentEmail);
            tabFaculty.Controls.Add(txtStudentEmail);

            tabFaculty.Controls.Add(lblFacultyName);
            tabFaculty.Controls.Add(txtFacultyName);

            tabFaculty.Controls.Add(lblReportDate);
            tabFaculty.Controls.Add(dtpReportDate);

            tabFaculty.Controls.Add(lblCourse);
            tabFaculty.Controls.Add(txtCourse);

            tabFaculty.Controls.Add(lblAssignment);
            tabFaculty.Controls.Add(txtAssignment);

            tabFaculty.Controls.Add(lblDepartment);
            tabFaculty.Controls.Add(txtDepartment);

            tabFaculty.Controls.Add(lblTerm);
            tabFaculty.Controls.Add(txtTerm);

            tabFaculty.Controls.Add(lblViolation);
            tabFaculty.Controls.Add(txtViolation);

            tabFaculty.Controls.Add(chkSupportPerson);
            tabFaculty.Controls.Add(chkWrittenStatement);

            tabFaculty.Controls.Add(lblFacultySignature);
            tabFaculty.Controls.Add(txtFacultySignature);

            tabFaculty.Controls.Add(lblSignatureDate);
            tabFaculty.Controls.Add(dtpSignatureDate);

            // ==========================================
            // TAB 2 - STUDENT & FACULTY
            // ==========================================

            lblStudentSection = new Label();
            lblStudentAckName = new Label();
            lblMyTruEmail = new Label();
            lblStudentSignature = new Label();
            lblStudentSignatureDate = new Label();

            txtStudentAckName = new TextBox();
            txtMyTruEmail = new TextBox();
            txtStudentSignature = new TextBox();

            chkEvidenceReviewed = new CheckBox();
            dtpStudentSignatureDate = new DateTimePicker();

            lblFacultySection = new Label();
            lblFacultyFollowupName = new Label();
            lblFacultyFollowupSignature = new Label();
            lblFacultyFollowupDate = new Label();

            txtFacultyFollowupName = new TextBox();
            txtFacultyFollowupSignature = new TextBox();
            dtpFacultyFollowupDate = new DateTimePicker();

            tabStudent.SuspendLayout();
            tabStudent.AutoScroll = true;

            // Student Section Title
            lblStudentSection.Name = "lblStudentSection";
            lblStudentSection.Text = "Step Two - Student Acknowledgement";
            lblStudentSection.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStudentSection.Location = new Point(25, 20);
            lblStudentSection.AutoSize = true;

            // Student Name
            lblStudentAckName.Name = "lblStudentAckName";
            lblStudentAckName.Text = "Student Name";
            lblStudentAckName.Location = new Point(25, 85);
            lblStudentAckName.AutoSize = true;

            txtStudentAckName.Name = "txtStudentAckName";
            txtStudentAckName.Location = new Point(25, 110);
            txtStudentAckName.Size = new Size(400, 25);

            // Evidence Reviewed
            chkEvidenceReviewed.Name = "chkEvidenceReviewed";
            chkEvidenceReviewed.Text = "I acknowledge that I have reviewed the evidence.";
            chkEvidenceReviewed.Location = new Point(25, 160);
            chkEvidenceReviewed.AutoSize = true;

            // myTRU Email
            lblMyTruEmail.Name = "lblMyTruEmail";
            lblMyTruEmail.Text = "myTRU Email Address";
            lblMyTruEmail.Location = new Point(25, 205);
            lblMyTruEmail.AutoSize = true;

            txtMyTruEmail.Name = "txtMyTruEmail";
            txtMyTruEmail.Location = new Point(25, 230);
            txtMyTruEmail.Size = new Size(400, 25);

            // Student Signature
            lblStudentSignature.Name = "lblStudentSignature";
            lblStudentSignature.Text = "Student Signature";
            lblStudentSignature.Location = new Point(25, 285);
            lblStudentSignature.AutoSize = true;

            txtStudentSignature.Name = "txtStudentSignature";
            txtStudentSignature.Location = new Point(25, 310);
            txtStudentSignature.Size = new Size(400, 25);

            // Student Signature Date
            lblStudentSignatureDate.Name = "lblStudentSignatureDate";
            lblStudentSignatureDate.Text = "Date";
            lblStudentSignatureDate.Location = new Point(475, 285);
            lblStudentSignatureDate.AutoSize = true;

            dtpStudentSignatureDate.Name = "dtpStudentSignatureDate";
            dtpStudentSignatureDate.Location = new Point(475, 310);
            dtpStudentSignatureDate.Size = new Size(260, 25);
            dtpStudentSignatureDate.Format = DateTimePickerFormat.Short;
            dtpStudentSignatureDate.ShowCheckBox = true;
            dtpStudentSignatureDate.Checked = false;

            // ==========================================
            // FACULTY FOLLOW-UP SECTION
            // ==========================================

            lblFacultySection.Name = "lblFacultySection";
            lblFacultySection.Text = "Faculty Member Follow-up";
            lblFacultySection.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFacultySection.Location = new Point(25, 380);
            lblFacultySection.AutoSize = true;

            // Faculty Name
            lblFacultyFollowupName.Name = "lblFacultyFollowupName";
            lblFacultyFollowupName.Text = "Faculty Member Name";
            lblFacultyFollowupName.Location = new Point(25, 440);
            lblFacultyFollowupName.AutoSize = true;

            txtFacultyFollowupName.Name = "txtFacultyFollowupName";
            txtFacultyFollowupName.Location = new Point(25, 465);
            txtFacultyFollowupName.Size = new Size(400, 25);

            // Faculty Signature
            lblFacultyFollowupSignature.Name = "lblFacultyFollowupSignature";
            lblFacultyFollowupSignature.Text = "Faculty Signature";
            lblFacultyFollowupSignature.Location = new Point(25, 520);
            lblFacultyFollowupSignature.AutoSize = true;

            txtFacultyFollowupSignature.Name = "txtFacultyFollowupSignature";
            txtFacultyFollowupSignature.Location = new Point(25, 545);
            txtFacultyFollowupSignature.Size = new Size(400, 25);

            // Faculty Signature Date
            lblFacultyFollowupDate.Name = "lblFacultyFollowupDate";
            lblFacultyFollowupDate.Text = "Date";
            lblFacultyFollowupDate.Location = new Point(475, 520);
            lblFacultyFollowupDate.AutoSize = true;

            dtpFacultyFollowupDate.Name = "dtpFacultyFollowupDate";
            dtpFacultyFollowupDate.Location = new Point(475, 545);
            dtpFacultyFollowupDate.Size = new Size(260, 25);
            dtpFacultyFollowupDate.Format = DateTimePickerFormat.Short;
            dtpFacultyFollowupDate.ShowCheckBox = true;
            dtpFacultyFollowupDate.Checked = false;

            // Add Student Controls
            tabStudent.Controls.Add(lblStudentSection);
            tabStudent.Controls.Add(lblStudentAckName);
            tabStudent.Controls.Add(txtStudentAckName);
            tabStudent.Controls.Add(chkEvidenceReviewed);
            tabStudent.Controls.Add(lblMyTruEmail);
            tabStudent.Controls.Add(txtMyTruEmail);
            tabStudent.Controls.Add(lblStudentSignature);
            tabStudent.Controls.Add(txtStudentSignature);
            tabStudent.Controls.Add(lblStudentSignatureDate);
            tabStudent.Controls.Add(dtpStudentSignatureDate);

            // Add Faculty Controls
            tabStudent.Controls.Add(lblFacultySection);
            tabStudent.Controls.Add(lblFacultyFollowupName);
            tabStudent.Controls.Add(txtFacultyFollowupName);
            tabStudent.Controls.Add(lblFacultyFollowupSignature);
            tabStudent.Controls.Add(txtFacultyFollowupSignature);
            tabStudent.Controls.Add(lblFacultyFollowupDate);
            tabStudent.Controls.Add(dtpFacultyFollowupDate);

            tabStudent.ResumeLayout(false);
            tabStudent.PerformLayout();


            // ==========================================
            // TAB 3 - CHAIR & DEAN
            // ==========================================

            lblChairSection = new Label();
            lblChairComments = new Label();
            lblChairName = new Label();
            lblChairSignature = new Label();
            lblChairDate = new Label();

            chkChairAgrees = new CheckBox();
            txtChairComments = new TextBox();
            txtChairName = new TextBox();
            txtChairSignature = new TextBox();
            dtpChairDate = new DateTimePicker();

            lblDeanSection = new Label();
            lblDeanComments = new Label();
            lblDeanName = new Label();
            lblDeanSignature = new Label();
            lblDeanDate = new Label();

            chkDeanAgrees = new CheckBox();
            txtDeanComments = new TextBox();
            txtDeanName = new TextBox();
            txtDeanSignature = new TextBox();
            dtpDeanDate = new DateTimePicker();

            tabReview.SuspendLayout();
            tabReview.AutoScroll = true;

            // ==========================================
            // DEPARTMENT CHAIR SECTION
            // ==========================================

            lblChairSection.Name = "lblChairSection";
            lblChairSection.Text = "Step Three - Department Chair Review";
            lblChairSection.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblChairSection.Location = new Point(25, 20);
            lblChairSection.AutoSize = true;

            // Chair Agreement
            chkChairAgrees.Name = "chkChairAgrees";
            chkChairAgrees.Text = "I agree with the faculty member's decision.";
            chkChairAgrees.Location = new Point(25, 75);
            chkChairAgrees.AutoSize = true;
            chkChairAgrees.ThreeState = true;
            chkChairAgrees.CheckState = CheckState.Indeterminate;

            // Chair Comments
            lblChairComments.Name = "lblChairComments";
            lblChairComments.Text = "Department Chair Comments";
            lblChairComments.Location = new Point(25, 115);
            lblChairComments.AutoSize = true;

            txtChairComments.Name = "txtChairComments";
            txtChairComments.Location = new Point(25, 140);
            txtChairComments.Size = new Size(850, 120);
            txtChairComments.Multiline = true;
            txtChairComments.ScrollBars = ScrollBars.Vertical;

            // Chair Name
            lblChairName.Name = "lblChairName";
            lblChairName.Text = "Department Chair Name";
            lblChairName.Location = new Point(25, 285);
            lblChairName.AutoSize = true;

            txtChairName.Name = "txtChairName";
            txtChairName.Location = new Point(25, 310);
            txtChairName.Size = new Size(260, 25);

            // Chair Signature
            lblChairSignature.Name = "lblChairSignature";
            lblChairSignature.Text = "Department Chair Signature";
            lblChairSignature.Location = new Point(320, 285);
            lblChairSignature.AutoSize = true;

            txtChairSignature.Name = "txtChairSignature";
            txtChairSignature.Location = new Point(320, 310);
            txtChairSignature.Size = new Size(260, 25);

            // Chair Date
            lblChairDate.Name = "lblChairDate";
            lblChairDate.Text = "Date";
            lblChairDate.Location = new Point(615, 285);
            lblChairDate.AutoSize = true;

            dtpChairDate.Name = "dtpChairDate";
            dtpChairDate.Location = new Point(615, 310);
            dtpChairDate.Size = new Size(260, 25);
            dtpChairDate.Format = DateTimePickerFormat.Short;
            dtpChairDate.ShowCheckBox = true;
            dtpChairDate.Checked = false;

            // ==========================================
            // DEAN SECTION
            // ==========================================

            lblDeanSection.Name = "lblDeanSection";
            lblDeanSection.Text = "Dean Review";
            lblDeanSection.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDeanSection.Location = new Point(25, 385);
            lblDeanSection.AutoSize = true;

            // Dean Agreement
            chkDeanAgrees.Name = "chkDeanAgrees";
            chkDeanAgrees.Text = "I agree with the decision.";
            chkDeanAgrees.Location = new Point(25, 440);
            chkDeanAgrees.AutoSize = true;
            chkDeanAgrees.ThreeState = true;
            chkDeanAgrees.CheckState = CheckState.Indeterminate;

            // Dean Comments
            lblDeanComments.Name = "lblDeanComments";
            lblDeanComments.Text = "Dean Comments";
            lblDeanComments.Location = new Point(25, 480);
            lblDeanComments.AutoSize = true;

            txtDeanComments.Name = "txtDeanComments";
            txtDeanComments.Location = new Point(25, 505);
            txtDeanComments.Size = new Size(850, 120);
            txtDeanComments.Multiline = true;
            txtDeanComments.ScrollBars = ScrollBars.Vertical;

            // Dean Name
            lblDeanName.Name = "lblDeanName";
            lblDeanName.Text = "Dean Name";
            lblDeanName.Location = new Point(25, 650);
            lblDeanName.AutoSize = true;

            txtDeanName.Name = "txtDeanName";
            txtDeanName.Location = new Point(25, 675);
            txtDeanName.Size = new Size(260, 25);

            // Dean Signature
            lblDeanSignature.Name = "lblDeanSignature";
            lblDeanSignature.Text = "Dean Signature";
            lblDeanSignature.Location = new Point(320, 650);
            lblDeanSignature.AutoSize = true;

            txtDeanSignature.Name = "txtDeanSignature";
            txtDeanSignature.Location = new Point(320, 675);
            txtDeanSignature.Size = new Size(260, 25);

            // Dean Date
            lblDeanDate.Name = "lblDeanDate";
            lblDeanDate.Text = "Date";
            lblDeanDate.Location = new Point(615, 650);
            lblDeanDate.AutoSize = true;

            dtpDeanDate.Name = "dtpDeanDate";
            dtpDeanDate.Location = new Point(615, 675);
            dtpDeanDate.Size = new Size(260, 25);
            dtpDeanDate.Format = DateTimePickerFormat.Short;
            dtpDeanDate.ShowCheckBox = true;
            dtpDeanDate.Checked = false;

            // Add Chair Controls
            tabReview.Controls.Add(lblChairSection);
            tabReview.Controls.Add(chkChairAgrees);
            tabReview.Controls.Add(lblChairComments);
            tabReview.Controls.Add(txtChairComments);
            tabReview.Controls.Add(lblChairName);
            tabReview.Controls.Add(txtChairName);
            tabReview.Controls.Add(lblChairSignature);
            tabReview.Controls.Add(txtChairSignature);
            tabReview.Controls.Add(lblChairDate);
            tabReview.Controls.Add(dtpChairDate);

            // Add Dean Controls
            tabReview.Controls.Add(lblDeanSection);
            tabReview.Controls.Add(chkDeanAgrees);
            tabReview.Controls.Add(lblDeanComments);
            tabReview.Controls.Add(txtDeanComments);
            tabReview.Controls.Add(lblDeanName);
            tabReview.Controls.Add(txtDeanName);
            tabReview.Controls.Add(lblDeanSignature);
            tabReview.Controls.Add(txtDeanSignature);
            tabReview.Controls.Add(lblDeanDate);
            tabReview.Controls.Add(dtpDeanDate);

            tabReview.ResumeLayout(false);
            tabReview.PerformLayout();

            // ==========================================
            // TAB 4 - FACULTY COMMENTS
            // ==========================================

            lblFacultyCommentsTitle = new Label();
            lblFacultyCommentsInstruction = new Label();
            txtFacultyComments = new TextBox();

            tabFacultyComments.SuspendLayout();
            tabFacultyComments.AutoScroll = true;

            // Faculty Comments Title
            lblFacultyCommentsTitle.Name = "lblFacultyCommentsTitle";
            lblFacultyCommentsTitle.Text = "Additional Faculty Comments";
            lblFacultyCommentsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFacultyCommentsTitle.Location = new Point(25, 20);
            lblFacultyCommentsTitle.AutoSize = true;

            // Instructions
            lblFacultyCommentsInstruction.Name = "lblFacultyCommentsInstruction";
            lblFacultyCommentsInstruction.Text = "Enter any additional comments regarding the academic integrity case.";
            lblFacultyCommentsInstruction.Location = new Point(25, 70);
            lblFacultyCommentsInstruction.AutoSize = true;

            // Faculty Comments TextBox
            txtFacultyComments.Name = "txtFacultyComments";
            txtFacultyComments.Location = new Point(25, 110);
            txtFacultyComments.Size = new Size(850, 450);
            txtFacultyComments.Multiline = true;
            txtFacultyComments.ScrollBars = ScrollBars.Vertical;

            tabFacultyComments.Controls.Add(lblFacultyCommentsTitle);
            tabFacultyComments.Controls.Add(lblFacultyCommentsInstruction);
            tabFacultyComments.Controls.Add(txtFacultyComments);

            tabFacultyComments.ResumeLayout(false);
            tabFacultyComments.PerformLayout();

            // ==========================================
            // TAB 5 - STUDENT COMMENTS
            // ==========================================

            lblStudentCommentsTitle = new Label();
            lblStudentCommentsInstruction = new Label();
            txtStudentComments = new TextBox();

            btnSaveCase = new Button();
            btnCancel = new Button();

            tabStudentComments.SuspendLayout();
            tabStudentComments.AutoScroll = true;

            // Student Comments Title
            lblStudentCommentsTitle.Name = "lblStudentCommentsTitle";
            lblStudentCommentsTitle.Text = "Additional Student Comments";
            lblStudentCommentsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStudentCommentsTitle.Location = new Point(25, 20);
            lblStudentCommentsTitle.AutoSize = true;

            // Instructions
            lblStudentCommentsInstruction.Name = "lblStudentCommentsInstruction";
            lblStudentCommentsInstruction.Text = "Enter any additional comments or statements provided by the student.";
            lblStudentCommentsInstruction.Location = new Point(25, 70);
            lblStudentCommentsInstruction.AutoSize = true;

            // Student Comments TextBox
            txtStudentComments.Name = "txtStudentComments";
            txtStudentComments.Location = new Point(25, 110);
            txtStudentComments.Size = new Size(850, 450);
            txtStudentComments.Multiline = true;
            txtStudentComments.ScrollBars = ScrollBars.Vertical;

            // Save Case Button
            btnSaveCase.Name = "btnSaveCase";
            btnSaveCase.Text = "Save Case";
            btnSaveCase.Location = new Point(625, 590);
            btnSaveCase.Size = new Size(120, 35);
            btnSaveCase.UseVisualStyleBackColor = true;

            // Cancel Button
            btnCancel.Name = "btnCancel";
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(755, 590);
            btnCancel.Size = new Size(120, 35);
            btnCancel.UseVisualStyleBackColor = true;

            // Add Controls
            tabStudentComments.Controls.Add(lblStudentCommentsTitle);
            tabStudentComments.Controls.Add(lblStudentCommentsInstruction);
            tabStudentComments.Controls.Add(txtStudentComments);
            tabStudentComments.Controls.Add(btnSaveCase);
            tabStudentComments.Controls.Add(btnCancel);

            tabStudentComments.ResumeLayout(false);
            tabStudentComments.PerformLayout();


            // CreateCaseForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 720);

            Controls.Add(tabControl1);

            Name = "CreateCaseForm";
            Text = "AICMS - Create Case";
            StartPosition = FormStartPosition.CenterScreen;

            tabControl1.ResumeLayout(false);
            tabFaculty.ResumeLayout(false);
            tabFaculty.PerformLayout();

            ResumeLayout(false);
        }

        // Tab controls
        private TabControl tabControl1;
        private TabPage tabFaculty;
        private TabPage tabStudent;
        private TabPage tabReview;
        private TabPage tabFacultyComments;
        private TabPage tabStudentComments;

        // Labels
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblStudentName;
        private Label lblStudentId;
        private Label lblStudentEmail;
        private Label lblFacultyName;
        private Label lblReportDate;
        private Label lblCourse;
        private Label lblAssignment;
        private Label lblDepartment;
        private Label lblTerm;
        private Label lblViolation;
        private Label lblFacultySignature;
        private Label lblSignatureDate;

        // TextBoxes
        private TextBox txtStudentName;
        private TextBox txtStudentId;
        private TextBox txtStudentEmail;
        private TextBox txtFacultyName;
        private TextBox txtCourse;
        private TextBox txtAssignment;
        private TextBox txtDepartment;
        private TextBox txtTerm;
        private TextBox txtViolation;
        private TextBox txtFacultySignature;

        // DateTimePickers
        private DateTimePicker dtpReportDate;
        private DateTimePicker dtpSignatureDate;

        // CheckBoxes
        private CheckBox chkSupportPerson;
        private CheckBox chkWrittenStatement;

        // Tab 2 - Student & Faculty
        private Label lblStudentSection;
        private Label lblStudentAckName;
        private Label lblMyTruEmail;
        private Label lblStudentSignature;
        private Label lblStudentSignatureDate;

        private TextBox txtStudentAckName;
        private TextBox txtMyTruEmail;
        private TextBox txtStudentSignature;

        private CheckBox chkEvidenceReviewed;
        private DateTimePicker dtpStudentSignatureDate;

        // Faculty Follow-up
        private Label lblFacultySection;
        private Label lblFacultyFollowupName;
        private Label lblFacultyFollowupSignature;
        private Label lblFacultyFollowupDate;

        private TextBox txtFacultyFollowupName;
        private TextBox txtFacultyFollowupSignature;
        private DateTimePicker dtpFacultyFollowupDate;

        // Tab 3 - Chair & Dean

        private Label lblChairSection;
        private Label lblChairComments;
        private Label lblChairName;
        private Label lblChairSignature;
        private Label lblChairDate;

        private CheckBox chkChairAgrees;
        private TextBox txtChairComments;
        private TextBox txtChairName;
        private TextBox txtChairSignature;
        private DateTimePicker dtpChairDate;

        private Label lblDeanSection;
        private Label lblDeanComments;
        private Label lblDeanName;
        private Label lblDeanSignature;
        private Label lblDeanDate;

        private CheckBox chkDeanAgrees;
        private TextBox txtDeanComments;
        private TextBox txtDeanName;
        private TextBox txtDeanSignature;
        private DateTimePicker dtpDeanDate;

        // Tab 4 - Faculty Comments
        private Label lblFacultyCommentsTitle;
        private Label lblFacultyCommentsInstruction;
        private TextBox txtFacultyComments;

        // Tab 5 - Student Comments
        private Label lblStudentCommentsTitle;
        private Label lblStudentCommentsInstruction;
        private TextBox txtStudentComments;

        private Button btnSaveCase;
        private Button btnCancel;
    }
}