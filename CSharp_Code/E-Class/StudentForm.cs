using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Class
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();

            //========================================================================
            ProjectsList.Bounds = new Rectangle(new Point(150, 12), new Size(275, 500));
            ProjectsList.View = View.Details;
            ProjectsList.FullRowSelect = true;
            ProjectsList.GridLines = true;
            ProjectsList.Sorting = SortOrder.Ascending;
            ProjectsList.Columns.Add("Course", -2, HorizontalAlignment.Left);
            ProjectsList.Columns.Add("Project", -2, HorizontalAlignment.Left);
            ProjectsList.Columns.Add("Sent", -2, HorizontalAlignment.Left);
            ProjectsList.Columns.Add("Grade", -2, HorizontalAlignment.Left);
            //==============================================================

            ProjectsList.Show();
            UploadGroupBox.Location = new Point(450, 12);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
