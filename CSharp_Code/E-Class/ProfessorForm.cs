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
    public partial class ProfessorForm : Form
    {
        public ProfessorForm()
        {
            InitializeComponent();

            ProjectGroupBox.Hide();
            ProjectList.Hide();
            ProjectList.Bounds = new Rectangle(new Point(150, 12), new Size(250, 500));
            ProjectList.View = View.Details;
            ProjectList.FullRowSelect = true;
            ProjectList.GridLines = true;
            ProjectList.Sorting = SortOrder.Ascending;
            ProjectList.Columns.Add("Project Name", -2, HorizontalAlignment.Left);
            ProjectList.Columns.Add("Max Grade", -2, HorizontalAlignment.Left);


            StudentsList.Bounds = new Rectangle(new Point(150, 12), new Size(375, 500));
            StudentsList.View = View.Details;
            StudentsList.FullRowSelect = true;
            StudentsList.GridLines = true;
            StudentsList.Sorting = SortOrder.Ascending;
            StudentsList.Columns.Add("Registration Number", -2, HorizontalAlignment.Left);
            StudentsList.Columns.Add("Team", -2, HorizontalAlignment.Left);
            StudentsList.Columns.Add("Email", -2, HorizontalAlignment.Left);


            CreateEditTeamGroupBox.Bounds = new Rectangle(new Point(550, 12), new Size(320, 320));
            CreateEditTeamGroupBox.Show();
            StudentsList.Show();
            
        }

        private void ModifyTeamMnBtn_Click(object sender, EventArgs e)
        {
            ProjectGroupBox.Hide();

            CreateEditTeamGroupBox.Show();
            StudentsList.Show();
            this.CreateEditTeamGroupBox.Location = new Point(550, 12);
            this.StudentsList.Location = new Point(150, 12);
        }


        private void ModifyProjectMnBtn_Click(object sender, EventArgs e)
        {
            StudentsList.Hide();
            CreateEditTeamGroupBox.Hide();
            ProjectList.Hide();

            ProjectGroupBox.Show();
            ProjectGroupBox.Left = (this.ClientSize.Width - ProjectGroupBox.Width + 100) / 2;
            ProjectGroupBox.Top = (this.ClientSize.Height - ProjectGroupBox.Height - 100) / 2;


        }


    }
}
