namespace E_Class
{
    partial class ProfessorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.AssignProjectMnBtn = new System.Windows.Forms.Button();
            this.ModifyProjectMnBtn = new System.Windows.Forms.Button();
            this.ModifyTeamMnBtn = new System.Windows.Forms.Button();
            this.ProjectGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CreateEditUserLabel = new System.Windows.Forms.Label();
            this.CancelUsersBtn = new System.Windows.Forms.Button();
            this.RegMsgLabel = new System.Windows.Forms.Label();
            this.RegNumBox = new System.Windows.Forms.TextBox();
            this.CreateEditUserBtn = new System.Windows.Forms.Button();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.MaxGradeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.RegNumErrorLabel = new System.Windows.Forms.Label();
            this.GradeProjectsMnBtn = new System.Windows.Forms.Button();
            this.CreateEditTeamGroupBox = new System.Windows.Forms.GroupBox();
            this.TeamMembersList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TeamIDBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TeamIDLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentsList = new System.Windows.Forms.ListView();
            this.ProjectList = new System.Windows.Forms.ListView();
            this.ProjectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.CreateEditTeamGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(-24, -24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 587);
            this.label1.TabIndex = 15;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(-5, 479);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(148, 64);
            this.LogoutBtn.TabIndex = 25;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            // 
            // AssignProjectMnBtn
            // 
            this.AssignProjectMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.AssignProjectMnBtn.FlatAppearance.BorderSize = 0;
            this.AssignProjectMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignProjectMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignProjectMnBtn.Location = new System.Drawing.Point(-6, 133);
            this.AssignProjectMnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AssignProjectMnBtn.Name = "AssignProjectMnBtn";
            this.AssignProjectMnBtn.Size = new System.Drawing.Size(148, 64);
            this.AssignProjectMnBtn.TabIndex = 24;
            this.AssignProjectMnBtn.Text = "Assign Project";
            this.AssignProjectMnBtn.UseVisualStyleBackColor = false;
            // 
            // ModifyProjectMnBtn
            // 
            this.ModifyProjectMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ModifyProjectMnBtn.FlatAppearance.BorderSize = 0;
            this.ModifyProjectMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyProjectMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProjectMnBtn.Location = new System.Drawing.Point(-6, 65);
            this.ModifyProjectMnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProjectMnBtn.Name = "ModifyProjectMnBtn";
            this.ModifyProjectMnBtn.Size = new System.Drawing.Size(148, 64);
            this.ModifyProjectMnBtn.TabIndex = 23;
            this.ModifyProjectMnBtn.Text = "Modify Projects";
            this.ModifyProjectMnBtn.UseVisualStyleBackColor = false;
            this.ModifyProjectMnBtn.Click += new System.EventHandler(this.ModifyProjectMnBtn_Click);
            // 
            // ModifyTeamMnBtn
            // 
            this.ModifyTeamMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ModifyTeamMnBtn.FlatAppearance.BorderSize = 0;
            this.ModifyTeamMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyTeamMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyTeamMnBtn.Location = new System.Drawing.Point(-5, -3);
            this.ModifyTeamMnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyTeamMnBtn.Name = "ModifyTeamMnBtn";
            this.ModifyTeamMnBtn.Size = new System.Drawing.Size(148, 64);
            this.ModifyTeamMnBtn.TabIndex = 22;
            this.ModifyTeamMnBtn.Text = "Modify Teams";
            this.ModifyTeamMnBtn.UseVisualStyleBackColor = false;
            this.ModifyTeamMnBtn.Click += new System.EventHandler(this.ModifyTeamMnBtn_Click);
            // 
            // ProjectGroupBox
            // 
            this.ProjectGroupBox.BackColor = System.Drawing.Color.White;
            this.ProjectGroupBox.Controls.Add(this.richTextBox1);
            this.ProjectGroupBox.Controls.Add(this.numericUpDown1);
            this.ProjectGroupBox.Controls.Add(this.CreateEditUserLabel);
            this.ProjectGroupBox.Controls.Add(this.CancelUsersBtn);
            this.ProjectGroupBox.Controls.Add(this.RegMsgLabel);
            this.ProjectGroupBox.Controls.Add(this.RegNumBox);
            this.ProjectGroupBox.Controls.Add(this.CreateEditUserBtn);
            this.ProjectGroupBox.Controls.Add(this.ProjectNameLabel);
            this.ProjectGroupBox.Controls.Add(this.MaxGradeLabel);
            this.ProjectGroupBox.Controls.Add(this.DescriptionLabel);
            this.ProjectGroupBox.Controls.Add(this.RegNumErrorLabel);
            this.ProjectGroupBox.Location = new System.Drawing.Point(148, 5);
            this.ProjectGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectGroupBox.Name = "ProjectGroupBox";
            this.ProjectGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ProjectGroupBox.Size = new System.Drawing.Size(326, 318);
            this.ProjectGroupBox.TabIndex = 28;
            this.ProjectGroupBox.TabStop = false;
            this.ProjectGroupBox.Text = "CreateEditProject";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 121);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 123);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(230, 64);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown1.TabIndex = 29;
            // 
            // CreateEditUserLabel
            // 
            this.CreateEditUserLabel.Location = new System.Drawing.Point(62, 15);
            this.CreateEditUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateEditUserLabel.Name = "CreateEditUserLabel";
            this.CreateEditUserLabel.Size = new System.Drawing.Size(202, 27);
            this.CreateEditUserLabel.TabIndex = 26;
            this.CreateEditUserLabel.Text = "label";
            this.CreateEditUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CancelUsersBtn
            // 
            this.CancelUsersBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelUsersBtn.Location = new System.Drawing.Point(138, 291);
            this.CancelUsersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelUsersBtn.Name = "CancelUsersBtn";
            this.CancelUsersBtn.Size = new System.Drawing.Size(56, 22);
            this.CancelUsersBtn.TabIndex = 31;
            this.CancelUsersBtn.Text = "Cancel";
            this.CancelUsersBtn.UseVisualStyleBackColor = false;
            // 
            // RegMsgLabel
            // 
            this.RegMsgLabel.AutoSize = true;
            this.RegMsgLabel.BackColor = System.Drawing.Color.White;
            this.RegMsgLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegMsgLabel.Location = new System.Drawing.Point(86, 50);
            this.RegMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegMsgLabel.Name = "RegMsgLabel";
            this.RegMsgLabel.Size = new System.Drawing.Size(19, 13);
            this.RegMsgLabel.TabIndex = 29;
            this.RegMsgLabel.Text = "no";
            // 
            // RegNumBox
            // 
            this.RegNumBox.Location = new System.Drawing.Point(20, 67);
            this.RegNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.RegNumBox.Name = "RegNumBox";
            this.RegNumBox.Size = new System.Drawing.Size(172, 20);
            this.RegNumBox.TabIndex = 0;
            // 
            // CreateEditUserBtn
            // 
            this.CreateEditUserBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateEditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateEditUserBtn.Location = new System.Drawing.Point(100, 249);
            this.CreateEditUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateEditUserBtn.Name = "CreateEditUserBtn";
            this.CreateEditUserBtn.Size = new System.Drawing.Size(130, 37);
            this.CreateEditUserBtn.TabIndex = 12;
            this.CreateEditUserBtn.Text = "Create";
            this.CreateEditUserBtn.UseVisualStyleBackColor = false;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(20, 48);
            this.ProjectNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(69, 13);
            this.ProjectNameLabel.TabIndex = 1;
            this.ProjectNameLabel.Text = "Project name";
            // 
            // MaxGradeLabel
            // 
            this.MaxGradeLabel.AutoSize = true;
            this.MaxGradeLabel.Location = new System.Drawing.Point(227, 48);
            this.MaxGradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxGradeLabel.Name = "MaxGradeLabel";
            this.MaxGradeLabel.Size = new System.Drawing.Size(57, 13);
            this.MaxGradeLabel.TabIndex = 11;
            this.MaxGradeLabel.Text = "Max grade";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(20, 102);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description";
            // 
            // RegNumErrorLabel
            // 
            this.RegNumErrorLabel.BackColor = System.Drawing.Color.Red;
            this.RegNumErrorLabel.Location = new System.Drawing.Point(19, 66);
            this.RegNumErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegNumErrorLabel.Name = "RegNumErrorLabel";
            this.RegNumErrorLabel.Size = new System.Drawing.Size(172, 20);
            this.RegNumErrorLabel.TabIndex = 13;
            // 
            // GradeProjectsMnBtn
            // 
            this.GradeProjectsMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.GradeProjectsMnBtn.FlatAppearance.BorderSize = 0;
            this.GradeProjectsMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradeProjectsMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeProjectsMnBtn.Location = new System.Drawing.Point(-6, 201);
            this.GradeProjectsMnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GradeProjectsMnBtn.Name = "GradeProjectsMnBtn";
            this.GradeProjectsMnBtn.Size = new System.Drawing.Size(148, 64);
            this.GradeProjectsMnBtn.TabIndex = 29;
            this.GradeProjectsMnBtn.Text = "Grade Projects";
            this.GradeProjectsMnBtn.UseVisualStyleBackColor = false;
            // 
            // CreateEditTeamGroupBox
            // 
            this.CreateEditTeamGroupBox.BackColor = System.Drawing.Color.White;
            this.CreateEditTeamGroupBox.Controls.Add(this.TeamMembersList);
            this.CreateEditTeamGroupBox.Controls.Add(this.label2);
            this.CreateEditTeamGroupBox.Controls.Add(this.button1);
            this.CreateEditTeamGroupBox.Controls.Add(this.label3);
            this.CreateEditTeamGroupBox.Controls.Add(this.TeamIDBox);
            this.CreateEditTeamGroupBox.Controls.Add(this.button2);
            this.CreateEditTeamGroupBox.Controls.Add(this.TeamIDLabel);
            this.CreateEditTeamGroupBox.Controls.Add(this.label6);
            this.CreateEditTeamGroupBox.Controls.Add(this.label7);
            this.CreateEditTeamGroupBox.Location = new System.Drawing.Point(478, 5);
            this.CreateEditTeamGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CreateEditTeamGroupBox.Name = "CreateEditTeamGroupBox";
            this.CreateEditTeamGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CreateEditTeamGroupBox.Size = new System.Drawing.Size(320, 318);
            this.CreateEditTeamGroupBox.TabIndex = 32;
            this.CreateEditTeamGroupBox.TabStop = false;
            this.CreateEditTeamGroupBox.Text = "CreateEditTeam";
            // 
            // TeamMembersList
            // 
            this.TeamMembersList.Location = new System.Drawing.Point(22, 125);
            this.TeamMembersList.Margin = new System.Windows.Forms.Padding(2);
            this.TeamMembersList.Name = "TeamMembersList";
            this.TeamMembersList.Size = new System.Drawing.Size(278, 114);
            this.TeamMembersList.TabIndex = 32;
            this.TeamMembersList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "label";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(140, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 22);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(86, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "no";
            // 
            // TeamIDBox
            // 
            this.TeamIDBox.Location = new System.Drawing.Point(20, 67);
            this.TeamIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.TeamIDBox.Name = "TeamIDBox";
            this.TeamIDBox.Size = new System.Drawing.Size(172, 20);
            this.TeamIDBox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(102, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Create team";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TeamIDLabel
            // 
            this.TeamIDLabel.AutoSize = true;
            this.TeamIDLabel.Location = new System.Drawing.Point(20, 48);
            this.TeamIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeamIDLabel.Name = "TeamIDLabel";
            this.TeamIDLabel.Size = new System.Drawing.Size(48, 13);
            this.TeamIDLabel.TabIndex = 1;
            this.TeamIDLabel.Text = "Team ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Team students";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 13;
            // 
            // StudentsList
            // 
            this.StudentsList.Location = new System.Drawing.Point(610, 455);
            this.StudentsList.Margin = new System.Windows.Forms.Padding(2);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(92, 80);
            this.StudentsList.TabIndex = 33;
            this.StudentsList.UseCompatibleStateImageBehavior = false;
            // 
            // ProjectList
            // 
            this.ProjectList.Location = new System.Drawing.Point(491, 455);
            this.ProjectList.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(92, 80);
            this.ProjectList.TabIndex = 34;
            this.ProjectList.UseCompatibleStateImageBehavior = false;
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 549);
            this.Controls.Add(this.ProjectList);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.CreateEditTeamGroupBox);
            this.Controls.Add(this.GradeProjectsMnBtn);
            this.Controls.Add(this.ProjectGroupBox);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.AssignProjectMnBtn);
            this.Controls.Add(this.ModifyProjectMnBtn);
            this.Controls.Add(this.ModifyTeamMnBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1040, 570);
            this.Name = "ProfessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorForm";
            this.ProjectGroupBox.ResumeLayout(false);
            this.ProjectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.CreateEditTeamGroupBox.ResumeLayout(false);
            this.CreateEditTeamGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button AssignProjectMnBtn;
        private System.Windows.Forms.Button ModifyProjectMnBtn;
        private System.Windows.Forms.Button ModifyTeamMnBtn;
        private System.Windows.Forms.GroupBox ProjectGroupBox;
        private System.Windows.Forms.Label CreateEditUserLabel;
        private System.Windows.Forms.Button CancelUsersBtn;
        private System.Windows.Forms.Label RegMsgLabel;
        private System.Windows.Forms.TextBox RegNumBox;
        private System.Windows.Forms.Button CreateEditUserBtn;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label MaxGradeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label RegNumErrorLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button GradeProjectsMnBtn;
        private System.Windows.Forms.GroupBox CreateEditTeamGroupBox;
        private System.Windows.Forms.ListView TeamMembersList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TeamIDBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TeamIDLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView StudentsList;
        private System.Windows.Forms.ListView ProjectList;
    }
}