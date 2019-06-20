namespace E_Class
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.FadeOuttimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.LoginAdmin = new System.Windows.Forms.Button();
            this.LoginProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(300, 112);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(225, 22);
            this.UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(300, 183);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(225, 22);
            this.PasswordBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(373, 88);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(81, 21);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Username";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.PassLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(373, 159);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(77, 21);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Password";
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Container.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Container.Location = new System.Drawing.Point(239, 55);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(340, 286);
            this.Container.TabIndex = 5;
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogInBtn.FlatAppearance.BorderSize = 0;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.Location = new System.Drawing.Point(300, 276);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(225, 36);
            this.LogInBtn.TabIndex = 6;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            this.LogInBtn.MouseEnter += new System.EventHandler(this.LogInBtn_Enter);
            this.LogInBtn.MouseLeave += new System.EventHandler(this.LogInBtn_Leave);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(190)))), ((int)(((byte)(221)))));
            this.WelcomeLabel.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(-2, -114);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(826, 580);
            this.WelcomeLabel.TabIndex = 7;
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FadeOuttimer
            // 
            this.FadeOuttimer.Tick += new System.EventHandler(this.FadeOuttimer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 456);
            this.progressBar.Maximum = 255;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(825, 10);
            this.progressBar.TabIndex = 8;
            // 
            // LoginAdmin
            // 
            this.LoginAdmin.BackColor = System.Drawing.Color.LightSalmon;
            this.LoginAdmin.FlatAppearance.BorderSize = 0;
            this.LoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginAdmin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAdmin.Location = new System.Drawing.Point(75, 358);
            this.LoginAdmin.Name = "LoginAdmin";
            this.LoginAdmin.Size = new System.Drawing.Size(153, 55);
            this.LoginAdmin.TabIndex = 9;
            this.LoginAdmin.Text = "Admin";
            this.LoginAdmin.UseVisualStyleBackColor = false;
            this.LoginAdmin.Click += new System.EventHandler(this.LoginAdmin_Click);
            // 
            // LoginProf
            // 
            this.LoginProf.BackColor = System.Drawing.Color.LightSalmon;
            this.LoginProf.FlatAppearance.BorderSize = 0;
            this.LoginProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginProf.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginProf.Location = new System.Drawing.Point(332, 358);
            this.LoginProf.Name = "LoginProf";
            this.LoginProf.Size = new System.Drawing.Size(153, 55);
            this.LoginProf.TabIndex = 10;
            this.LoginProf.Text = "Professor";
            this.LoginProf.UseVisualStyleBackColor = false;
            this.LoginProf.Click += new System.EventHandler(this.LoginProf_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 463);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.LoginAdmin);
            this.Controls.Add(this.LoginProf);
            this.MaximumSize = new System.Drawing.Size(837, 508);
            this.MinimumSize = new System.Drawing.Size(837, 508);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label Container;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Timer FadeOuttimer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button LoginAdmin;
        private System.Windows.Forms.Button LoginProf;
    }
}

