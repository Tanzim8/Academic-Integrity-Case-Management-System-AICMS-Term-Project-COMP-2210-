namespace AICMS_GUI
{
    partial class StudentDashboard
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
            btnLogout = new Button();
            aicmsTitle = new Label();
            stdDash = new Label();
            lblWelcome = new Label();
            lblTitle = new Label();
            dvgCases = new DataGridView();
            btnRefresh = new Button();
            btnViewDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgCases).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(661, 46);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // aicmsTitle
            // 
            aicmsTitle.AutoSize = true;
            aicmsTitle.Location = new Point(32, 30);
            aicmsTitle.Name = "aicmsTitle";
            aicmsTitle.Size = new Size(43, 15);
            aicmsTitle.TabIndex = 1;
            aicmsTitle.Text = "AICMS";
            // 
            // stdDash
            // 
            stdDash.AutoSize = true;
            stdDash.Location = new Point(32, 65);
            stdDash.Name = "stdDash";
            stdDash.Size = new Size(108, 15);
            stdDash.TabIndex = 2;
            stdDash.Text = "Student Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(32, 110);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(107, 15);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome, Student!";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(32, 137);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "My Academic Integrity Cases";
            // 
            // dvgCases
            // 
            dvgCases.AllowUserToAddRows = false;
            dvgCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCases.Location = new Point(32, 197);
            dvgCases.MultiSelect = false;
            dvgCases.Name = "dvgCases";
            dvgCases.ReadOnly = true;
            dvgCases.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dvgCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCases.Size = new Size(704, 220);
            dvgCases.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(661, 129);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(661, 445);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(75, 43);
            btnViewDetails.TabIndex = 7;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 561);
            Controls.Add(btnViewDetails);
            Controls.Add(btnRefresh);
            Controls.Add(dvgCases);
            Controls.Add(lblTitle);
            Controls.Add(lblWelcome);
            Controls.Add(stdDash);
            Controls.Add(aicmsTitle);
            Controls.Add(btnLogout);
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AICMS - Student Dashboard";
            Load += StudentDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dvgCases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Label aicmsTitle;
        private Label stdDash;
        private Label lblWelcome;
        private Label lblTitle;
        private DataGridView dvgCases;
        private Button btnRefresh;
        private Button btnViewDetails;
    }
}