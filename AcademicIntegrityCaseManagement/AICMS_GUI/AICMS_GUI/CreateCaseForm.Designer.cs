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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblStudentEmail = new Label();
            txtStudentEmail = new TextBox();
            lblFacultyName = new Label();
            txtFacultyName = new TextBox();
            lblReportDate = new Label();
            dtpReportDate = new DateTimePicker();
            lblCourse = new Label();
            txtCourse = new TextBox();
            lblAssignment = new Label();
            txtAssignment = new TextBox();
            lblDepartment = new Label();
            txtDepartment = new TextBox();
            lblTerm = new Label();
            txtTerm = new TextBox();
            lblViolation = new Label();
            txtViolation = new TextBox();
            chkSupportPerson = new CheckBox();
            chkWrittenStatement = new CheckBox();
            lblFacultySignature = new Label();
            txtFacultySignature = new TextBox();
            lblSignatureDate = new Label();
            dtpSignatureDate = new DateTimePicker();
            tabStudent = new TabPage();
            lblStudentSection = new Label();
            lblStudentAckName = new Label();
            txtStudentAckName = new TextBox();
            chkEvidenceReviewed = new CheckBox();
            lblMyTruEmail = new Label();
            txtMyTruEmail = new TextBox();
            lblStudentSignature = new Label();
            txtStudentSignature = new TextBox();
            lblStudentSignatureDate = new Label();
            dtpStudentSignatureDate = new DateTimePicker();
            lblFacultySection = new Label();
            lblFacultyFollowupName = new Label();
            txtFacultyFollowupName = new TextBox();
            lblFacultyFollowupSignature = new Label();
            txtFacultyFollowupSignature = new TextBox();
            lblFacultyFollowupDate = new Label();
            dtpFacultyFollowupDate = new DateTimePicker();
            tabReview = new TabPage();
            lblChairSection = new Label();
            chkChairAgrees = new CheckBox();
            lblChairComments = new Label();
            txtChairComments = new TextBox();
            lblChairName = new Label();
            txtChairName = new TextBox();
            lblChairSignature = new Label();
            txtChairSignature = new TextBox();
            lblChairDate = new Label();
            dtpChairDate = new DateTimePicker();
            lblDeanSection = new Label();
            chkDeanAgrees = new CheckBox();
            lblDeanComments = new Label();
            txtDeanComments = new TextBox();
            lblDeanName = new Label();
            txtDeanName = new TextBox();
            lblDeanSignature = new Label();
            txtDeanSignature = new TextBox();
            lblDeanDate = new Label();
            dtpDeanDate = new DateTimePicker();
            tabFacultyComments = new TabPage();
            lblFacultyCommentsTitle = new Label();
            lblFacultyCommentsInstruction = new Label();
            txtFacultyComments = new TextBox();
            tabStudentComments = new TabPage();
            lblStudentCommentsTitle = new Label();
            lblStudentCommentsInstruction = new Label();
            txtStudentComments = new TextBox();
            btnSaveCase = new Button();
            btnCancel = new Button();
            tabControl1.SuspendLayout();
            tabFaculty.SuspendLayout();
            tabStudent.SuspendLayout();
            tabReview.SuspendLayout();
            tabFacultyComments.SuspendLayout();
            tabStudentComments.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabFaculty);
            tabControl1.Controls.Add(tabStudent);
            tabControl1.Controls.Add(tabReview);
            tabControl1.Controls.Add(tabFacultyComments);
            tabControl1.Controls.Add(tabStudentComments);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(940, 720);
            tabControl1.TabIndex = 0;
            // 
            // tabFaculty
            // 
            tabFaculty.AutoScroll = true;
            tabFaculty.BackColor = Color.White;
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
            tabFaculty.Location = new Point(4, 24);
            tabFaculty.Name = "tabFaculty";
            tabFaculty.Size = new Size(932, 692);
            tabFaculty.TabIndex = 0;
            tabFaculty.Text = "Faculty Report";
            tabFaculty.Click += tabFaculty_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(353, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Academic Integrity Policy ED 5-0";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.Location = new Point(25, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(326, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Step One - To be completed by Faculty Member";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(25, 105);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(83, 15);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(25, 130);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(260, 23);
            txtStudentName.TabIndex = 3;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(320, 105);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(95, 15);
            lblStudentId.TabIndex = 4;
            lblStudentId.Text = "Student Number";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(320, 130);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(260, 23);
            txtStudentId.TabIndex = 5;
            // 
            // lblStudentEmail
            // 
            lblStudentEmail.AutoSize = true;
            lblStudentEmail.Location = new Point(615, 105);
            lblStudentEmail.Name = "lblStudentEmail";
            lblStudentEmail.Size = new Size(80, 15);
            lblStudentEmail.TabIndex = 6;
            lblStudentEmail.Text = "Student Email";
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Location = new Point(615, 130);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(260, 23);
            txtStudentEmail.TabIndex = 7;
            // 
            // lblFacultyName
            // 
            lblFacultyName.AutoSize = true;
            lblFacultyName.Location = new Point(25, 175);
            lblFacultyName.Name = "lblFacultyName";
            lblFacultyName.Size = new Size(128, 15);
            lblFacultyName.TabIndex = 8;
            lblFacultyName.Text = "Faculty Member Name";
            // 
            // txtFacultyName
            // 
            txtFacultyName.Location = new Point(25, 200);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Size = new Size(260, 23);
            txtFacultyName.TabIndex = 9;
            // 
            // lblReportDate
            // 
            lblReportDate.AutoSize = true;
            lblReportDate.Location = new Point(320, 175);
            lblReportDate.Name = "lblReportDate";
            lblReportDate.Size = new Size(69, 15);
            lblReportDate.TabIndex = 10;
            lblReportDate.Text = "Report Date";
            // 
            // dtpReportDate
            // 
            dtpReportDate.Format = DateTimePickerFormat.Short;
            dtpReportDate.Location = new Point(320, 200);
            dtpReportDate.Name = "dtpReportDate";
            dtpReportDate.Size = new Size(260, 23);
            dtpReportDate.TabIndex = 11;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(615, 175);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(149, 15);
            lblCourse.TabIndex = 12;
            lblCourse.Text = "Course Name and Number";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(615, 200);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(260, 23);
            txtCourse.TabIndex = 13;
            // 
            // lblAssignment
            // 
            lblAssignment.AutoSize = true;
            lblAssignment.Location = new Point(25, 245);
            lblAssignment.Name = "lblAssignment";
            lblAssignment.Size = new Size(163, 15);
            lblAssignment.TabIndex = 14;
            lblAssignment.Text = "Assignment Number or Exam";
            // 
            // txtAssignment
            // 
            txtAssignment.Location = new Point(25, 270);
            txtAssignment.Name = "txtAssignment";
            txtAssignment.Size = new Size(260, 23);
            txtAssignment.TabIndex = 15;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(320, 245);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(70, 15);
            lblDepartment.TabIndex = 16;
            lblDepartment.Text = "Department";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(320, 270);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(260, 23);
            txtDepartment.TabIndex = 17;
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Location = new Point(615, 245);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(98, 15);
            lblTerm.TabIndex = 18;
            lblTerm.Text = "Term or Semester";
            // 
            // txtTerm
            // 
            txtTerm.Location = new Point(615, 270);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(260, 23);
            txtTerm.TabIndex = 19;
            // 
            // lblViolation
            // 
            lblViolation.AutoSize = true;
            lblViolation.Location = new Point(25, 320);
            lblViolation.Name = "lblViolation";
            lblViolation.Size = new Size(234, 15);
            lblViolation.TabIndex = 20;
            lblViolation.Text = "Description of Academic Integrity Violation";
            // 
            // txtViolation
            // 
            txtViolation.Location = new Point(25, 350);
            txtViolation.Multiline = true;
            txtViolation.Name = "txtViolation";
            txtViolation.ScrollBars = ScrollBars.Vertical;
            txtViolation.Size = new Size(850, 130);
            txtViolation.TabIndex = 21;
            // 
            // chkSupportPerson
            // 
            chkSupportPerson.AutoSize = true;
            chkSupportPerson.Location = new Point(25, 500);
            chkSupportPerson.Name = "chkSupportPerson";
            chkSupportPerson.Size = new Size(312, 19);
            chkSupportPerson.TabIndex = 22;
            chkSupportPerson.Text = "Student advised that they may bring a support person.";
            // 
            // chkWrittenStatement
            // 
            chkWrittenStatement.AutoSize = true;
            chkWrittenStatement.Location = new Point(25, 535);
            chkWrittenStatement.Name = "chkWrittenStatement";
            chkWrittenStatement.Size = new Size(334, 19);
            chkWrittenStatement.TabIndex = 23;
            chkWrittenStatement.Text = "Student advised that they may submit a written statement.";
            // 
            // lblFacultySignature
            // 
            lblFacultySignature.AutoSize = true;
            lblFacultySignature.Location = new Point(25, 580);
            lblFacultySignature.Name = "lblFacultySignature";
            lblFacultySignature.Size = new Size(98, 15);
            lblFacultySignature.TabIndex = 24;
            lblFacultySignature.Text = "Faculty Signature";
            // 
            // txtFacultySignature
            // 
            txtFacultySignature.Location = new Point(25, 605);
            txtFacultySignature.Name = "txtFacultySignature";
            txtFacultySignature.Size = new Size(400, 23);
            txtFacultySignature.TabIndex = 25;
            // 
            // lblSignatureDate
            // 
            lblSignatureDate.AutoSize = true;
            lblSignatureDate.Location = new Point(475, 580);
            lblSignatureDate.Name = "lblSignatureDate";
            lblSignatureDate.Size = new Size(84, 15);
            lblSignatureDate.TabIndex = 26;
            lblSignatureDate.Text = "Signature Date";
            // 
            // dtpSignatureDate
            // 
            dtpSignatureDate.Format = DateTimePickerFormat.Short;
            dtpSignatureDate.Location = new Point(475, 605);
            dtpSignatureDate.Name = "dtpSignatureDate";
            dtpSignatureDate.Size = new Size(260, 23);
            dtpSignatureDate.TabIndex = 27;
            // 
            // tabStudent
            // 
            tabStudent.AutoScroll = true;
            tabStudent.BackColor = Color.White;
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
            tabStudent.Controls.Add(lblFacultySection);
            tabStudent.Controls.Add(lblFacultyFollowupName);
            tabStudent.Controls.Add(txtFacultyFollowupName);
            tabStudent.Controls.Add(lblFacultyFollowupSignature);
            tabStudent.Controls.Add(txtFacultyFollowupSignature);
            tabStudent.Controls.Add(lblFacultyFollowupDate);
            tabStudent.Controls.Add(dtpFacultyFollowupDate);
            tabStudent.Location = new Point(4, 24);
            tabStudent.Name = "tabStudent";
            tabStudent.Size = new Size(192, 72);
            tabStudent.TabIndex = 1;
            tabStudent.Text = "Student & Faculty";
            // 
            // lblStudentSection
            // 
            lblStudentSection.AutoSize = true;
            lblStudentSection.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStudentSection.Location = new Point(25, 20);
            lblStudentSection.Name = "lblStudentSection";
            lblStudentSection.Size = new Size(410, 30);
            lblStudentSection.TabIndex = 0;
            lblStudentSection.Text = "Step Two - Student Acknowledgement";
            // 
            // lblStudentAckName
            // 
            lblStudentAckName.AutoSize = true;
            lblStudentAckName.Location = new Point(25, 85);
            lblStudentAckName.Name = "lblStudentAckName";
            lblStudentAckName.Size = new Size(83, 15);
            lblStudentAckName.TabIndex = 1;
            lblStudentAckName.Text = "Student Name";
            // 
            // txtStudentAckName
            // 
            txtStudentAckName.Location = new Point(25, 110);
            txtStudentAckName.Name = "txtStudentAckName";
            txtStudentAckName.Size = new Size(400, 23);
            txtStudentAckName.TabIndex = 2;
            // 
            // chkEvidenceReviewed
            // 
            chkEvidenceReviewed.AutoSize = true;
            chkEvidenceReviewed.Location = new Point(25, 160);
            chkEvidenceReviewed.Name = "chkEvidenceReviewed";
            chkEvidenceReviewed.Size = new Size(283, 19);
            chkEvidenceReviewed.TabIndex = 3;
            chkEvidenceReviewed.Text = "I acknowledge that I have reviewed the evidence.";
            // 
            // lblMyTruEmail
            // 
            lblMyTruEmail.AutoSize = true;
            lblMyTruEmail.Location = new Point(25, 205);
            lblMyTruEmail.Name = "lblMyTruEmail";
            lblMyTruEmail.Size = new Size(122, 15);
            lblMyTruEmail.TabIndex = 4;
            lblMyTruEmail.Text = "myTRU Email Address";
            // 
            // txtMyTruEmail
            // 
            txtMyTruEmail.Location = new Point(25, 230);
            txtMyTruEmail.Name = "txtMyTruEmail";
            txtMyTruEmail.Size = new Size(400, 23);
            txtMyTruEmail.TabIndex = 5;
            // 
            // lblStudentSignature
            // 
            lblStudentSignature.AutoSize = true;
            lblStudentSignature.Location = new Point(25, 285);
            lblStudentSignature.Name = "lblStudentSignature";
            lblStudentSignature.Size = new Size(101, 15);
            lblStudentSignature.TabIndex = 6;
            lblStudentSignature.Text = "Student Signature";
            // 
            // txtStudentSignature
            // 
            txtStudentSignature.Location = new Point(25, 310);
            txtStudentSignature.Name = "txtStudentSignature";
            txtStudentSignature.Size = new Size(400, 23);
            txtStudentSignature.TabIndex = 7;
            // 
            // lblStudentSignatureDate
            // 
            lblStudentSignatureDate.AutoSize = true;
            lblStudentSignatureDate.Location = new Point(475, 285);
            lblStudentSignatureDate.Name = "lblStudentSignatureDate";
            lblStudentSignatureDate.Size = new Size(31, 15);
            lblStudentSignatureDate.TabIndex = 8;
            lblStudentSignatureDate.Text = "Date";
            // 
            // dtpStudentSignatureDate
            // 
            dtpStudentSignatureDate.Checked = false;
            dtpStudentSignatureDate.Format = DateTimePickerFormat.Short;
            dtpStudentSignatureDate.Location = new Point(475, 310);
            dtpStudentSignatureDate.Name = "dtpStudentSignatureDate";
            dtpStudentSignatureDate.ShowCheckBox = true;
            dtpStudentSignatureDate.Size = new Size(260, 23);
            dtpStudentSignatureDate.TabIndex = 9;
            // 
            // lblFacultySection
            // 
            lblFacultySection.AutoSize = true;
            lblFacultySection.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFacultySection.Location = new Point(25, 380);
            lblFacultySection.Name = "lblFacultySection";
            lblFacultySection.Size = new Size(289, 30);
            lblFacultySection.TabIndex = 10;
            lblFacultySection.Text = "Faculty Member Follow-up";
            // 
            // lblFacultyFollowupName
            // 
            lblFacultyFollowupName.AutoSize = true;
            lblFacultyFollowupName.Location = new Point(25, 440);
            lblFacultyFollowupName.Name = "lblFacultyFollowupName";
            lblFacultyFollowupName.Size = new Size(128, 15);
            lblFacultyFollowupName.TabIndex = 11;
            lblFacultyFollowupName.Text = "Faculty Member Name";
            // 
            // txtFacultyFollowupName
            // 
            txtFacultyFollowupName.Location = new Point(25, 465);
            txtFacultyFollowupName.Name = "txtFacultyFollowupName";
            txtFacultyFollowupName.Size = new Size(400, 23);
            txtFacultyFollowupName.TabIndex = 12;
            // 
            // lblFacultyFollowupSignature
            // 
            lblFacultyFollowupSignature.AutoSize = true;
            lblFacultyFollowupSignature.Location = new Point(25, 520);
            lblFacultyFollowupSignature.Name = "lblFacultyFollowupSignature";
            lblFacultyFollowupSignature.Size = new Size(98, 15);
            lblFacultyFollowupSignature.TabIndex = 13;
            lblFacultyFollowupSignature.Text = "Faculty Signature";
            // 
            // txtFacultyFollowupSignature
            // 
            txtFacultyFollowupSignature.Location = new Point(25, 545);
            txtFacultyFollowupSignature.Name = "txtFacultyFollowupSignature";
            txtFacultyFollowupSignature.Size = new Size(400, 23);
            txtFacultyFollowupSignature.TabIndex = 14;
            // 
            // lblFacultyFollowupDate
            // 
            lblFacultyFollowupDate.AutoSize = true;
            lblFacultyFollowupDate.Location = new Point(475, 520);
            lblFacultyFollowupDate.Name = "lblFacultyFollowupDate";
            lblFacultyFollowupDate.Size = new Size(31, 15);
            lblFacultyFollowupDate.TabIndex = 15;
            lblFacultyFollowupDate.Text = "Date";
            // 
            // dtpFacultyFollowupDate
            // 
            dtpFacultyFollowupDate.Checked = false;
            dtpFacultyFollowupDate.Format = DateTimePickerFormat.Short;
            dtpFacultyFollowupDate.Location = new Point(475, 545);
            dtpFacultyFollowupDate.Name = "dtpFacultyFollowupDate";
            dtpFacultyFollowupDate.ShowCheckBox = true;
            dtpFacultyFollowupDate.Size = new Size(260, 23);
            dtpFacultyFollowupDate.TabIndex = 16;
            // 
            // tabReview
            // 
            tabReview.AutoScroll = true;
            tabReview.BackColor = Color.White;
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
            tabReview.Location = new Point(4, 24);
            tabReview.Name = "tabReview";
            tabReview.Size = new Size(192, 72);
            tabReview.TabIndex = 2;
            tabReview.Text = "Chair & Dean";
            // 
            // lblChairSection
            // 
            lblChairSection.AutoSize = true;
            lblChairSection.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblChairSection.Location = new Point(25, 20);
            lblChairSection.Name = "lblChairSection";
            lblChairSection.Size = new Size(411, 30);
            lblChairSection.TabIndex = 0;
            lblChairSection.Text = "Step Three - Department Chair Review";
            // 
            // chkChairAgrees
            // 
            chkChairAgrees.AutoSize = true;
            chkChairAgrees.Checked = true;
            chkChairAgrees.CheckState = CheckState.Indeterminate;
            chkChairAgrees.Location = new Point(25, 75);
            chkChairAgrees.Name = "chkChairAgrees";
            chkChairAgrees.Size = new Size(252, 19);
            chkChairAgrees.TabIndex = 1;
            chkChairAgrees.Text = "I agree with the faculty member's decision.";
            chkChairAgrees.ThreeState = true;
            // 
            // lblChairComments
            // 
            lblChairComments.AutoSize = true;
            lblChairComments.Location = new Point(25, 115);
            lblChairComments.Name = "lblChairComments";
            lblChairComments.Size = new Size(163, 15);
            lblChairComments.TabIndex = 2;
            lblChairComments.Text = "Department Chair Comments";
            // 
            // txtChairComments
            // 
            txtChairComments.Location = new Point(25, 140);
            txtChairComments.Multiline = true;
            txtChairComments.Name = "txtChairComments";
            txtChairComments.ScrollBars = ScrollBars.Vertical;
            txtChairComments.Size = new Size(850, 120);
            txtChairComments.TabIndex = 3;
            // 
            // lblChairName
            // 
            lblChairName.AutoSize = true;
            lblChairName.Location = new Point(25, 285);
            lblChairName.Name = "lblChairName";
            lblChairName.Size = new Size(136, 15);
            lblChairName.TabIndex = 4;
            lblChairName.Text = "Department Chair Name";
            // 
            // txtChairName
            // 
            txtChairName.Location = new Point(25, 310);
            txtChairName.Name = "txtChairName";
            txtChairName.Size = new Size(260, 23);
            txtChairName.TabIndex = 5;
            // 
            // lblChairSignature
            // 
            lblChairSignature.AutoSize = true;
            lblChairSignature.Location = new Point(320, 285);
            lblChairSignature.Name = "lblChairSignature";
            lblChairSignature.Size = new Size(154, 15);
            lblChairSignature.TabIndex = 6;
            lblChairSignature.Text = "Department Chair Signature";
            // 
            // txtChairSignature
            // 
            txtChairSignature.Location = new Point(320, 310);
            txtChairSignature.Name = "txtChairSignature";
            txtChairSignature.Size = new Size(260, 23);
            txtChairSignature.TabIndex = 7;
            // 
            // lblChairDate
            // 
            lblChairDate.AutoSize = true;
            lblChairDate.Location = new Point(615, 285);
            lblChairDate.Name = "lblChairDate";
            lblChairDate.Size = new Size(31, 15);
            lblChairDate.TabIndex = 8;
            lblChairDate.Text = "Date";
            // 
            // dtpChairDate
            // 
            dtpChairDate.Checked = false;
            dtpChairDate.Format = DateTimePickerFormat.Short;
            dtpChairDate.Location = new Point(615, 310);
            dtpChairDate.Name = "dtpChairDate";
            dtpChairDate.ShowCheckBox = true;
            dtpChairDate.Size = new Size(260, 23);
            dtpChairDate.TabIndex = 9;
            // 
            // lblDeanSection
            // 
            lblDeanSection.AutoSize = true;
            lblDeanSection.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDeanSection.Location = new Point(25, 385);
            lblDeanSection.Name = "lblDeanSection";
            lblDeanSection.Size = new Size(145, 30);
            lblDeanSection.TabIndex = 10;
            lblDeanSection.Text = "Dean Review";
            // 
            // chkDeanAgrees
            // 
            chkDeanAgrees.AutoSize = true;
            chkDeanAgrees.Checked = true;
            chkDeanAgrees.CheckState = CheckState.Indeterminate;
            chkDeanAgrees.Location = new Point(25, 440);
            chkDeanAgrees.Name = "chkDeanAgrees";
            chkDeanAgrees.Size = new Size(157, 19);
            chkDeanAgrees.TabIndex = 11;
            chkDeanAgrees.Text = "I agree with the decision.";
            chkDeanAgrees.ThreeState = true;
            // 
            // lblDeanComments
            // 
            lblDeanComments.AutoSize = true;
            lblDeanComments.Location = new Point(25, 480);
            lblDeanComments.Name = "lblDeanComments";
            lblDeanComments.Size = new Size(96, 15);
            lblDeanComments.TabIndex = 12;
            lblDeanComments.Text = "Dean Comments";
            // 
            // txtDeanComments
            // 
            txtDeanComments.Location = new Point(25, 505);
            txtDeanComments.Multiline = true;
            txtDeanComments.Name = "txtDeanComments";
            txtDeanComments.ScrollBars = ScrollBars.Vertical;
            txtDeanComments.Size = new Size(850, 120);
            txtDeanComments.TabIndex = 13;
            // 
            // lblDeanName
            // 
            lblDeanName.AutoSize = true;
            lblDeanName.Location = new Point(25, 650);
            lblDeanName.Name = "lblDeanName";
            lblDeanName.Size = new Size(69, 15);
            lblDeanName.TabIndex = 14;
            lblDeanName.Text = "Dean Name";
            // 
            // txtDeanName
            // 
            txtDeanName.Location = new Point(25, 675);
            txtDeanName.Name = "txtDeanName";
            txtDeanName.Size = new Size(260, 23);
            txtDeanName.TabIndex = 15;
            // 
            // lblDeanSignature
            // 
            lblDeanSignature.AutoSize = true;
            lblDeanSignature.Location = new Point(320, 650);
            lblDeanSignature.Name = "lblDeanSignature";
            lblDeanSignature.Size = new Size(87, 15);
            lblDeanSignature.TabIndex = 16;
            lblDeanSignature.Text = "Dean Signature";
            // 
            // txtDeanSignature
            // 
            txtDeanSignature.Location = new Point(320, 675);
            txtDeanSignature.Name = "txtDeanSignature";
            txtDeanSignature.Size = new Size(260, 23);
            txtDeanSignature.TabIndex = 17;
            // 
            // lblDeanDate
            // 
            lblDeanDate.AutoSize = true;
            lblDeanDate.Location = new Point(615, 650);
            lblDeanDate.Name = "lblDeanDate";
            lblDeanDate.Size = new Size(31, 15);
            lblDeanDate.TabIndex = 18;
            lblDeanDate.Text = "Date";
            // 
            // dtpDeanDate
            // 
            dtpDeanDate.Checked = false;
            dtpDeanDate.Format = DateTimePickerFormat.Short;
            dtpDeanDate.Location = new Point(615, 675);
            dtpDeanDate.Name = "dtpDeanDate";
            dtpDeanDate.ShowCheckBox = true;
            dtpDeanDate.Size = new Size(260, 23);
            dtpDeanDate.TabIndex = 19;
            // 
            // tabFacultyComments
            // 
            tabFacultyComments.AutoScroll = true;
            tabFacultyComments.BackColor = Color.White;
            tabFacultyComments.Controls.Add(lblFacultyCommentsTitle);
            tabFacultyComments.Controls.Add(lblFacultyCommentsInstruction);
            tabFacultyComments.Controls.Add(txtFacultyComments);
            tabFacultyComments.Location = new Point(4, 24);
            tabFacultyComments.Name = "tabFacultyComments";
            tabFacultyComments.Size = new Size(192, 72);
            tabFacultyComments.TabIndex = 3;
            tabFacultyComments.Text = "Faculty Comments";
            // 
            // lblFacultyCommentsTitle
            // 
            lblFacultyCommentsTitle.AutoSize = true;
            lblFacultyCommentsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFacultyCommentsTitle.Location = new Point(25, 20);
            lblFacultyCommentsTitle.Name = "lblFacultyCommentsTitle";
            lblFacultyCommentsTitle.Size = new Size(317, 30);
            lblFacultyCommentsTitle.TabIndex = 0;
            lblFacultyCommentsTitle.Text = "Additional Faculty Comments";
            // 
            // lblFacultyCommentsInstruction
            // 
            lblFacultyCommentsInstruction.AutoSize = true;
            lblFacultyCommentsInstruction.Location = new Point(25, 70);
            lblFacultyCommentsInstruction.Name = "lblFacultyCommentsInstruction";
            lblFacultyCommentsInstruction.Size = new Size(376, 15);
            lblFacultyCommentsInstruction.TabIndex = 1;
            lblFacultyCommentsInstruction.Text = "Enter any additional comments regarding the academic integrity case.";
            // 
            // txtFacultyComments
            // 
            txtFacultyComments.Location = new Point(25, 110);
            txtFacultyComments.Multiline = true;
            txtFacultyComments.Name = "txtFacultyComments";
            txtFacultyComments.ScrollBars = ScrollBars.Vertical;
            txtFacultyComments.Size = new Size(850, 450);
            txtFacultyComments.TabIndex = 2;
            // 
            // tabStudentComments
            // 
            tabStudentComments.AutoScroll = true;
            tabStudentComments.BackColor = Color.White;
            tabStudentComments.Controls.Add(lblStudentCommentsTitle);
            tabStudentComments.Controls.Add(lblStudentCommentsInstruction);
            tabStudentComments.Controls.Add(txtStudentComments);
            tabStudentComments.Controls.Add(btnSaveCase);
            tabStudentComments.Controls.Add(btnCancel);
            tabStudentComments.Location = new Point(4, 24);
            tabStudentComments.Name = "tabStudentComments";
            tabStudentComments.Size = new Size(192, 72);
            tabStudentComments.TabIndex = 4;
            tabStudentComments.Text = "Student Comments";
            // 
            // lblStudentCommentsTitle
            // 
            lblStudentCommentsTitle.AutoSize = true;
            lblStudentCommentsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStudentCommentsTitle.Location = new Point(25, 20);
            lblStudentCommentsTitle.Name = "lblStudentCommentsTitle";
            lblStudentCommentsTitle.Size = new Size(325, 30);
            lblStudentCommentsTitle.TabIndex = 0;
            lblStudentCommentsTitle.Text = "Additional Student Comments";
            // 
            // lblStudentCommentsInstruction
            // 
            lblStudentCommentsInstruction.AutoSize = true;
            lblStudentCommentsInstruction.Location = new Point(25, 70);
            lblStudentCommentsInstruction.Name = "lblStudentCommentsInstruction";
            lblStudentCommentsInstruction.Size = new Size(379, 15);
            lblStudentCommentsInstruction.TabIndex = 1;
            lblStudentCommentsInstruction.Text = "Enter any additional comments or statements provided by the student.";
            // 
            // txtStudentComments
            // 
            txtStudentComments.Location = new Point(25, 110);
            txtStudentComments.Multiline = true;
            txtStudentComments.Name = "txtStudentComments";
            txtStudentComments.ScrollBars = ScrollBars.Vertical;
            txtStudentComments.Size = new Size(850, 450);
            txtStudentComments.TabIndex = 2;
            // 
            // btnSaveCase
            // 
            btnSaveCase.Location = new Point(625, 590);
            btnSaveCase.Name = "btnSaveCase";
            btnSaveCase.Size = new Size(120, 35);
            btnSaveCase.TabIndex = 3;
            btnSaveCase.Text = "Save Case";
            btnSaveCase.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(755, 590);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CreateCaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 720);
            Controls.Add(tabControl1);
            Name = "CreateCaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AICMS - Create Case";
            tabControl1.ResumeLayout(false);
            tabFaculty.ResumeLayout(false);
            tabFaculty.PerformLayout();
            tabStudent.ResumeLayout(false);
            tabStudent.PerformLayout();
            tabReview.ResumeLayout(false);
            tabReview.PerformLayout();
            tabFacultyComments.ResumeLayout(false);
            tabFacultyComments.PerformLayout();
            tabStudentComments.ResumeLayout(false);
            tabStudentComments.PerformLayout();
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