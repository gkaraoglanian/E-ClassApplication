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
    public partial class LoginForm : Form
    {
        private static int gammaA = 255;
        public LoginForm()
        {
            InitializeComponent();
            FadeOuttimer.Interval = 1;
            //FadeOuttimer.Start();
            //WelcomeLabel.Show();
            WelcomeLabel.Hide();
            //ProfessorForm form = new ProfessorForm();
            //form.ShowDialog();
        }

        private void LogInBtn_Enter(object sender, EventArgs e)
        {
            LogInBtn.Font = new Font("Calibri", 11, FontStyle.Regular);
        }

        private void LogInBtn_Leave(object sender, EventArgs e)
        {
            LogInBtn.Font = new Font("Calibri", 10, FontStyle.Regular);
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            //AdminForm form = new AdminForm();
            //form.ShowDialog();
        }
        
        private void FadeOuttimer_Tick(object sender, EventArgs e)
        {
            progressBar.Value = 255 - gammaA;
            WelcomeLabel.BackColor = Color.FromArgb(gammaA, 165, 190, 221);
            if (gammaA <= 0)
            {
                WelcomeLabel.Hide();
                progressBar.Hide();
                FadeOuttimer.Stop();
            }
            gammaA--;
        }

        private void LoginAdmin_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.ShowDialog();
        }

        private void LoginProf_Click(object sender, EventArgs e)
        {
            ProfessorForm form = new ProfessorForm();
            form.ShowDialog();
        }
    }
}
