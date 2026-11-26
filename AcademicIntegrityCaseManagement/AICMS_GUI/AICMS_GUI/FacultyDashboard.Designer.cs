namespace AICMS_GUI
{
    partial class FacultyDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblWelcome = new Label();
            lblCases = new Label();
            dvgCases = new DataGridView();
            btnCreateCase = new Button();
            btnViewDetails = new Button();
            btnUpdateCase = new Button();
            btnDeleteCase = new Button();
            btnRefresh = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgCases).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(38, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Faculty Dashboard";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(38, 82);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(57, 15);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // lblCases
            // 
            lblCases.AutoSize = true;
            lblCases.Location = new Point(38, 120);
            lblCases.Name = "lblCases";
            lblCases.Size = new Size(140, 15);
            lblCases.TabIndex = 2;
            lblCases.Text = "Academic Integrity Cases";
            // 
            // dvgCases
            // 
            dvgCases.AllowUserToAddRows = false;
            dvgCases.AllowUserToDeleteRows = false;
            dvgCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCases.Location = new Point(38, 171);
            dvgCases.MultiSelect = false;
            dvgCases.Name = "dvgCases";
            dvgCases.ReadOnly = true;
            dvgCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCases.Size = new Size(697, 179);
            dvgCases.TabIndex = 3;
            // 
            // btnCreateCase
            // 
            btnCreateCase.Location = new Point(38, 383);
            btnCreateCase.Name = "btnCreateCase";
            btnCreateCase.Size = new Size(100, 31);
            btnCreateCase.TabIndex = 4;
            btnCreateCase.Text = "Create Case";
            btnCreateCase.UseVisualStyleBackColor = true;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(237, 383);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(100, 31);
            btnViewDetails.TabIndex = 5;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += button2_Click;
            // 
            // btnUpdateCase
            // 
            btnUpdateCase.Location = new Point(436, 383);
            btnUpdateCase.Name = "btnUpdateCase";
            btnUpdateCase.Size = new Size(100, 31);
            btnUpdateCase.TabIndex = 6;
            btnUpdateCase.Text = "Update Case";
            btnUpdateCase.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCase
            // 
            btnDeleteCase.Location = new Point(635, 383);
            btnDeleteCase.Name = "btnDeleteCase";
            btnDeleteCase.Size = new Size(100, 31);
            btnDeleteCase.TabIndex = 7;
            btnDeleteCase.Text = "Delete Case";
            btnDeleteCase.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(660, 112);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(660, 39);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // FacultyDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteCase);
            Controls.Add(btnUpdateCase);
            Controls.Add(btnViewDetails);
            Controls.Add(btnCreateCase);
            Controls.Add(dvgCases);
            Controls.Add(lblCases);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Name = "FacultyDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AICMS - Faculty Dashboard";
            Load += FacultyDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dvgCases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Label lblCases;
        private DataGridView dvgCases;

        private Button btnCreateCase;
        private Button btnViewDetails;
        private Button btnUpdateCase;
        private Button btnDeleteCase;
        private Button btnRefresh;
        private Button btnLogout;
    }
}