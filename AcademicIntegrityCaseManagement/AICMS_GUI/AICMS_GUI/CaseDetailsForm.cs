using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICMS_GUI
{
    public partial class CaseDetailsForm : Form
    {
        public CaseDetailsForm(string caseId, string term, string assignment, string date, string violation)
        {
            InitializeComponent();

            lblCaseId.Text = "Case ID: " + caseId;
            lblTerm.Text = "Term: " + term;
            lblAssignment.Text = "Assignment: " + assignment;
            lblDate.Text = "Date: " + date;
            txtViolation.Text = "Violation: " + violation;
        }
        private void CaseDetilsForm_Load(object sender, EventArgs e)
        {
            // Set the form's title
            //this.Text = "Case Details";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
