namespace AICMS_GUI
{
    partial class RegistraterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            createLabel = new Label();
            aicmsLabel = new Label();
            userID = new Label();
            fullName = new Label();
            userEmail = new Label();
            userDept = new Label();
            userType = new Label();
            userName = new Label();
            userPass = new Label();
            confirmPass = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtUserId = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtDepartment = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            cmbUserType = new ComboBox();
            SuspendLayout();
            // 
            // createLabel
            // 
            createLabel.AutoSize = true;
            createLabel.Location = new Point(199, 37);
            createLabel.Name = "createLabel";
            createLabel.Size = new Size(105, 15);
            createLabel.TabIndex = 0;
            createLabel.Text = "Create an Account";
            // 
            // aicmsLabel
            // 
            aicmsLabel.AutoSize = true;
            aicmsLabel.Location = new Point(148, 66);
            aicmsLabel.Name = "aicmsLabel";
            aicmsLabel.Size = new Size(250, 15);
            aicmsLabel.TabIndex = 1;
            aicmsLabel.Text = "Academic Integrity Case Management System";
            // 
            // userID
            // 
            userID.AutoSize = true;
            userID.Location = new Point(33, 122);
            userID.Name = "userID";
            userID.Size = new Size(44, 15);
            userID.TabIndex = 2;
            userID.Text = "User ID";
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Location = new Point(33, 156);
            fullName.Name = "fullName";
            fullName.Size = new Size(61, 15);
            fullName.TabIndex = 3;
            fullName.Text = "Full Name";
            // 
            // userEmail
            // 
            userEmail.AutoSize = true;
            userEmail.Location = new Point(33, 186);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(36, 15);
            userEmail.TabIndex = 4;
            userEmail.Text = "Email";
            // 
            // userDept
            // 
            userDept.AutoSize = true;
            userDept.Location = new Point(33, 218);
            userDept.Name = "userDept";
            userDept.Size = new Size(70, 15);
            userDept.TabIndex = 5;
            userDept.Text = "Department";
            // 
            // userType
            // 
            userType.AutoSize = true;
            userType.Location = new Point(33, 255);
            userType.Name = "userType";
            userType.Size = new Size(57, 15);
            userType.TabIndex = 6;
            userType.Text = "User Type";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(33, 287);
            userName.Name = "userName";
            userName.Size = new Size(60, 15);
            userName.TabIndex = 7;
            userName.Text = "Username";
            // 
            // userPass
            // 
            userPass.AutoSize = true;
            userPass.Location = new Point(33, 317);
            userPass.Name = "userPass";
            userPass.Size = new Size(57, 15);
            userPass.TabIndex = 8;
            userPass.Text = "Password";
            // 
            // confirmPass
            // 
            confirmPass.AutoSize = true;
            confirmPass.Location = new Point(12, 353);
            confirmPass.Name = "confirmPass";
            confirmPass.Size = new Size(104, 15);
            confirmPass.TabIndex = 9;
            confirmPass.Text = "Confirm Password";
            confirmPass.Click += confirmPass_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(121, 119);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(421, 23);
            txtUserId.TabIndex = 11;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(122, 156);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(420, 23);
            txtFullName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(122, 222);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(420, 23);
            txtDepartment.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(122, 284);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(420, 23);
            txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 316);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(421, 23);
            txtPassword.TabIndex = 17;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(122, 350);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(420, 23);
            txtConfirmPassword.TabIndex = 18;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(199, 405);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(305, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbUserType
            // 
            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "Student", "Faculty" });
            cmbUserType.Location = new Point(122, 255);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(420, 23);
            cmbUserType.TabIndex = 21;
            // 
            // RegistraterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbUserType);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtDepartment);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtUserId);
            Controls.Add(confirmPass);
            Controls.Add(userPass);
            Controls.Add(userName);
            Controls.Add(userType);
            Controls.Add(userDept);
            Controls.Add(userEmail);
            Controls.Add(fullName);
            Controls.Add(userID);
            Controls.Add(aicmsLabel);
            Controls.Add(createLabel);
            Name = "RegistraterForm";
            Text = "AICMS-userRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createLabel;
        private Label aicmsLabel;
        private Label userID;
        private Label fullName;
        private Label userEmail;
        private Label userDept;
        private Label userType;
        private Label userName;
        private Label userPass;
        private Label confirmPass;

        private ContextMenuStrip contextMenuStrip1;

        private TextBox txtUserId;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtDepartment;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;

        private Button btnRegister;
        private Button btnCancel;
        private ComboBox cmbUserType;
    }
}