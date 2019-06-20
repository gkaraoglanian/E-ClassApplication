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


            StudentsList.Bounds = new Rectangle(new Point(196, 12), new Size(375, 500));
            ProjectList.Bounds = new Rectangle(new Point(196, 12), new Size(250, 500));
            CreateEditTeamGroupBox.Bounds = new Rectangle(new Point(578, 12), new Size(430, 400));
            CreateEditTeamGroupBox.Show();
            StudentsList.Show();
            
        }

        private void CreateProjectMnBtn_Click(object sender, EventArgs e)
        {
            StudentsList.Hide();
            CreateEditTeamGroupBox.Hide();

            ProjectGroupBox.Show();
            ProjectGroupBox.Left = (this.ClientSize.Width - ProjectGroupBox.Width + 100) / 2;
            ProjectGroupBox.Top = (this.ClientSize.Height - ProjectGroupBox.Height - 100) / 2;
        }

        private void CreateTeamMnBtn_Click(object sender, EventArgs e)
        {
            CreateEditTeamGroupBox.Show();
            StudentsList.Show();
            this.CreateEditTeamGroupBox.Location = new Point(578, 12);
            this.StudentsList.Location = new Point(196, 12);
        }
    }
}
