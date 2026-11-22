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

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            // Load student cases when the dashboard loads
            //LoadStudentCases();
        }
    }
}
