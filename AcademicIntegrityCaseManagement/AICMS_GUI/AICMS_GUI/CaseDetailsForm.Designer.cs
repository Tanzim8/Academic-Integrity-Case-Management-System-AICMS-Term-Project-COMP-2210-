namespace AICMS_GUI
{
    partial class CaseDetailsForm
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
            lblCaseId = new Label();
            lblTerm = new Label();
            lblAssignment = new Label();
            lblDate = new Label();
            lblViolation = new Label();
            txtViolation = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblCaseId
            // 
            lblCaseId.AutoSize = true;
            lblCaseId.Location = new Point(40, 42);
            lblCaseId.Name = "lblCaseId";
            lblCaseId.Size = new Size(49, 15);
            lblCaseId.TabIndex = 0;
            lblCaseId.Text = "Case ID:";
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Location = new Point(40, 79);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(37, 15);
            lblTerm.TabIndex = 1;
            lblTerm.Text = "Term:";
            // 
            // lblAssignment
            // 
            lblAssignment.AutoSize = true;
            lblAssignment.Location = new Point(40, 108);
            lblAssignment.Name = "lblAssignment";
            lblAssignment.Size = new Size(76, 15);
            lblAssignment.TabIndex = 2;
            lblAssignment.Text = "Assignment: ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(40, 136);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date:";
            // 
            // lblViolation
            // 
            lblViolation.AutoSize = true;
            lblViolation.Location = new Point(40, 165);
            lblViolation.Name = "lblViolation";
            lblViolation.Size = new Size(117, 15);
            lblViolation.TabIndex = 4;
            lblViolation.Text = "Violation Description";
            // 
            // txtViolation
            // 
            txtViolation.Location = new Point(40, 195);
            txtViolation.Multiline = true;
            txtViolation.Name = "txtViolation";
            txtViolation.ReadOnly = true;
            txtViolation.ScrollBars = ScrollBars.Vertical;
            txtViolation.Size = new Size(450, 120);
            txtViolation.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(40, 335);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // CaseDetilsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 561);
            Controls.Add(btnClose);
            Controls.Add(txtViolation);
            Controls.Add(lblViolation);
            Controls.Add(lblDate);
            Controls.Add(lblAssignment);
            Controls.Add(lblTerm);
            Controls.Add(lblCaseId);
            Name = "CaseDetilsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AICMS - Case Details";
            Load += CaseDetilsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCaseId;
        private Label lblTerm;
        private Label lblAssignment;
        private Label lblDate;
        private Label lblViolation;
        private TextBox txtViolation;
        private Button btnClose;
    }
}