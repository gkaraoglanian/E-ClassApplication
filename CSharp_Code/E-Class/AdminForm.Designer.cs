namespace E_Class
{
    partial class AdminForm
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
            this.RegNumBox = new System.Windows.Forms.TextBox();
            this.RegNumLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.CapacityBox = new System.Windows.Forms.ComboBox();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.CreateEditUserBtn = new System.Windows.Forms.Button();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateEditUserLabel = new System.Windows.Forms.Label();
            this.CancelUsersBtn = new System.Windows.Forms.Button();
            this.PassMsgLabel = new System.Windows.Forms.Label();
            this.SurnameMsgLabel = new System.Windows.Forms.Label();
            this.CapacityMsgLabel = new System.Windows.Forms.Label();
            this.RegMsgLabel = new System.Windows.Forms.Label();
            this.NameMsgLabel = new System.Windows.Forms.Label();
            this.EmailMsgLabel = new System.Windows.Forms.Label();
            this.RegNumErrorLabel = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.EmailErrorLabel = new System.Windows.Forms.Label();
            this.SurnameErrorLabel = new System.Windows.Forms.Label();
            this.PassErrorLabel = new System.Windows.Forms.Label();
            this.CapacityErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateUserMnBtn = new System.Windows.Forms.Button();
            this.CreateCourseMnBtn = new System.Windows.Forms.Button();
            this.AssignCoursesMnBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.EditDelUsersMnBtn = new System.Windows.Forms.Button();
            this.EditDelCoursesMnBtn = new System.Windows.Forms.Button();
            this.CourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateEditCourseLabel = new System.Windows.Forms.Label();
            this.CancelCoursesBtn = new System.Windows.Forms.Button();
            this.CreateEditCourseBtn = new System.Windows.Forms.Button();
            this.CourseTitleBox = new System.Windows.Forms.TextBox();
            this.CourseTitleLabel = new System.Windows.Forms.Label();
            this.CourseTitleErrorLabel = new System.Windows.Forms.Label();
            this.UsersList = new System.Windows.Forms.ListView();
            this.CoursesList = new System.Windows.Forms.ListView();
            this.AssignCourseBtn = new System.Windows.Forms.Button();
            this.AssignMsgLabel = new System.Windows.Forms.Label();
            this.UserGroupBox.SuspendLayout();
            this.CourseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegNumBox
            // 
            this.RegNumBox.Location = new System.Drawing.Point(26, 82);
            this.RegNumBox.Name = "RegNumBox";
            this.RegNumBox.Size = new System.Drawing.Size(228, 22);
            this.RegNumBox.TabIndex = 0;
            // 
            // RegNumLabel
            // 
            this.RegNumLabel.AutoSize = true;
            this.RegNumLabel.Location = new System.Drawing.Point(26, 59);
            this.RegNumLabel.Name = "RegNumLabel";
            this.RegNumLabel.Size = new System.Drawing.Size(96, 17);
            this.RegNumLabel.TabIndex = 1;
            this.RegNumLabel.Text = "Registration #";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(26, 125);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(26, 148);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(228, 22);
            this.NameBox.TabIndex = 2;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(306, 125);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(65, 17);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Surname";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(306, 148);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(228, 22);
            this.SurnameBox.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(26, 195);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(26, 218);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(228, 22);
            this.EmailBox.TabIndex = 6;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(306, 195);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(69, 17);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Password";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(306, 218);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(228, 22);
            this.PassBox.TabIndex = 8;
            // 
            // CapacityBox
            // 
            this.CapacityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CapacityBox.FormattingEnabled = true;
            this.CapacityBox.Items.AddRange(new object[] {
            "Professor",
            "Student"});
            this.CapacityBox.Location = new System.Drawing.Point(306, 80);
            this.CapacityBox.Name = "CapacityBox";
            this.CapacityBox.Size = new System.Drawing.Size(228, 24);
            this.CapacityBox.TabIndex = 10;
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Location = new System.Drawing.Point(303, 59);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(62, 17);
            this.CapacityLabel.TabIndex = 11;
            this.CapacityLabel.Text = "Capacity";
            // 
            // CreateEditUserBtn
            // 
            this.CreateEditUserBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateEditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateEditUserBtn.Location = new System.Drawing.Point(192, 251);
            this.CreateEditUserBtn.Name = "CreateEditUserBtn";
            this.CreateEditUserBtn.Size = new System.Drawing.Size(173, 46);
            this.CreateEditUserBtn.TabIndex = 12;
            this.CreateEditUserBtn.Text = "Create";
            this.CreateEditUserBtn.UseVisualStyleBackColor = false;
            this.CreateEditUserBtn.Click += new System.EventHandler(this.CreateEditUserBtn_Click);
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.CreateEditUserLabel);
            this.UserGroupBox.Controls.Add(this.CancelUsersBtn);
            this.UserGroupBox.Controls.Add(this.PassMsgLabel);
            this.UserGroupBox.Controls.Add(this.SurnameMsgLabel);
            this.UserGroupBox.Controls.Add(this.CapacityMsgLabel);
            this.UserGroupBox.Controls.Add(this.RegMsgLabel);
            this.UserGroupBox.Controls.Add(this.NameMsgLabel);
            this.UserGroupBox.Controls.Add(this.EmailMsgLabel);
            this.UserGroupBox.Controls.Add(this.CapacityBox);
            this.UserGroupBox.Controls.Add(this.SurnameBox);
            this.UserGroupBox.Controls.Add(this.PassBox);
            this.UserGroupBox.Controls.Add(this.EmailBox);
            this.UserGroupBox.Controls.Add(this.NameBox);
            this.UserGroupBox.Controls.Add(this.RegNumBox);
            this.UserGroupBox.Controls.Add(this.CreateEditUserBtn);
            this.UserGroupBox.Controls.Add(this.RegNumLabel);
            this.UserGroupBox.Controls.Add(this.CapacityLabel);
            this.UserGroupBox.Controls.Add(this.PassLabel);
            this.UserGroupBox.Controls.Add(this.NameLabel);
            this.UserGroupBox.Controls.Add(this.EmailLabel);
            this.UserGroupBox.Controls.Add(this.SurnameLabel);
            this.UserGroupBox.Controls.Add(this.RegNumErrorLabel);
            this.UserGroupBox.Controls.Add(this.NameErrorLabel);
            this.UserGroupBox.Controls.Add(this.EmailErrorLabel);
            this.UserGroupBox.Controls.Add(this.SurnameErrorLabel);
            this.UserGroupBox.Controls.Add(this.PassErrorLabel);
            this.UserGroupBox.Controls.Add(this.CapacityErrorLabel);
            this.UserGroupBox.Location = new System.Drawing.Point(223, 43);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(557, 363);
            this.UserGroupBox.TabIndex = 13;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "CreateEditUsers";
            // 
            // CreateEditUserLabel
            // 
            this.CreateEditUserLabel.Location = new System.Drawing.Point(82, 19);
            this.CreateEditUserLabel.Name = "CreateEditUserLabel";
            this.CreateEditUserLabel.Size = new System.Drawing.Size(383, 33);
            this.CreateEditUserLabel.TabIndex = 26;
            this.CreateEditUserLabel.Text = "label";
            this.CreateEditUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CancelUsersBtn
            // 
            this.CancelUsersBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelUsersBtn.Location = new System.Drawing.Point(242, 303);
            this.CancelUsersBtn.Name = "CancelUsersBtn";
            this.CancelUsersBtn.Size = new System.Drawing.Size(75, 27);
            this.CancelUsersBtn.TabIndex = 31;
            this.CancelUsersBtn.Text = "Cancel";
            this.CancelUsersBtn.UseVisualStyleBackColor = false;
            this.CancelUsersBtn.Click += new System.EventHandler(this.CancelUsersBtn_Click);
            // 
            // PassMsgLabel
            // 
            this.PassMsgLabel.AutoSize = true;
            this.PassMsgLabel.BackColor = System.Drawing.Color.White;
            this.PassMsgLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PassMsgLabel.Location = new System.Drawing.Point(374, 201);
            this.PassMsgLabel.Name = "PassMsgLabel";
            this.PassMsgLabel.Size = new System.Drawing.Size(24, 17);
            this.PassMsgLabel.TabIndex = 26;
            this.PassMsgLabel.Text = "no";
            // 
            // SurnameMsgLabel
            // 
            this.SurnameMsgLabel.AutoSize = true;
            this.SurnameMsgLabel.BackColor = System.Drawing.Color.White;
            this.SurnameMsgLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SurnameMsgLabel.Location = new System.Drawing.Point(374, 130);
            this.SurnameMsgLabel.Name = "SurnameMsgLabel";
            this.SurnameMsgLabel.Size = new System.Drawing.Size(24, 17);
            this.SurnameMsgLabel.TabIndex = 27;
            this.SurnameMsgLabel.Text = "no";
            // 
            // CapacityMsgLabel
            // 
            this.CapacityMsgLabel.AutoSize = true;
            this.CapacityMsgLabel.BackColor = System.Drawing.Color.White;
            this.CapacityMsgLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CapacityMsgLabel.Location = new System.Drawing.Point(374, 62);
            this.CapacityMsgLabel.Name = "CapacityMsgLabel";
            this.CapacityMsgLabel.Size = new System.Drawing.Size(24, 17);
            this.CapacityMsgLabel.TabIndex = 28;
            this.CapacityMsgLabel.Text = "no";
            // 
            // RegMsgLabel
            // 
            this.RegMsgLabel.AutoSize = true;
            this.RegMsgLabel.BackColor = System.Drawing.Color.White;
            this.RegMsgLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegMsgLabel.Location = new System.Drawing.Point(128, 65);
            this.RegMsgLabel.Name = "RegMsgLabel";
            this.RegMsgLabel.Size = new System.Drawing.Size(24, 17);
            this.RegMsgLabel.TabIndex = 29;
            this.RegMsgLabel.Text = "no";
            // 
            // NameMsgLabel
            // 
            this.NameMsgLabel.AutoSize = true;
            this.NameMsgLabel.BackColor = System.Drawing.Color.White;
            this.NameMsgLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameMsgLabel.Location = new System.Drawing.Point(67, 129);
            this.NameMsgLabel.Name = "NameMsgLabel";
            this.NameMsgLabel.Size = new System.Drawing.Size(24, 17);
            this.NameMsgLabel.TabIndex = 30;
            this.NameMsgLabel.Text = "no";
            // 
            // EmailMsgLabel
            // 
            this.EmailMsgLabel.AutoSize = true;
            this.EmailMsgLabel.BackColor = System.Drawing.Color.White;
            this.EmailMsgLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmailMsgLabel.Location = new System.Drawing.Point(67, 200);
            this.EmailMsgLabel.Name = "EmailMsgLabel";
            this.EmailMsgLabel.Size = new System.Drawing.Size(24, 17);
            this.EmailMsgLabel.TabIndex = 24;
            this.EmailMsgLabel.Text = "no";
            // 
            // RegNumErrorLabel
            // 
            this.RegNumErrorLabel.BackColor = System.Drawing.Color.Red;
            this.RegNumErrorLabel.Location = new System.Drawing.Point(25, 81);
            this.RegNumErrorLabel.Name = "RegNumErrorLabel";
            this.RegNumErrorLabel.Size = new System.Drawing.Size(230, 24);
            this.RegNumErrorLabel.TabIndex = 13;
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.BackColor = System.Drawing.Color.Red;
            this.NameErrorLabel.Location = new System.Drawing.Point(25, 147);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(230, 24);
            this.NameErrorLabel.TabIndex = 14;
            // 
            // EmailErrorLabel
            // 
            this.EmailErrorLabel.BackColor = System.Drawing.Color.Red;
            this.EmailErrorLabel.Location = new System.Drawing.Point(25, 217);
            this.EmailErrorLabel.Name = "EmailErrorLabel";
            this.EmailErrorLabel.Size = new System.Drawing.Size(230, 24);
            this.EmailErrorLabel.TabIndex = 25;
            // 
            // SurnameErrorLabel
            // 
            this.SurnameErrorLabel.BackColor = System.Drawing.Color.Red;
            this.SurnameErrorLabel.Location = new System.Drawing.Point(305, 147);
            this.SurnameErrorLabel.Name = "SurnameErrorLabel";
            this.SurnameErrorLabel.Size = new System.Drawing.Size(230, 24);
            this.SurnameErrorLabel.TabIndex = 25;
            // 
            // PassErrorLabel
            // 
            this.PassErrorLabel.BackColor = System.Drawing.Color.Red;
            this.PassErrorLabel.Location = new System.Drawing.Point(305, 217);
            this.PassErrorLabel.Name = "PassErrorLabel";
            this.PassErrorLabel.Size = new System.Drawing.Size(230, 24);
            this.PassErrorLabel.TabIndex = 25;
            // 
            // CapacityErrorLabel
            // 
            this.CapacityErrorLabel.BackColor = System.Drawing.Color.Red;
            this.CapacityErrorLabel.Location = new System.Drawing.Point(305, 79);
            this.CapacityErrorLabel.Name = "CapacityErrorLabel";
            this.CapacityErrorLabel.Size = new System.Drawing.Size(230, 26);
            this.CapacityErrorLabel.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(-32, -29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 722);
            this.label1.TabIndex = 14;
            // 
            // CreateUserMnBtn
            // 
            this.CreateUserMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CreateUserMnBtn.FlatAppearance.BorderSize = 0;
            this.CreateUserMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserMnBtn.Location = new System.Drawing.Point(-7, -3);
            this.CreateUserMnBtn.Name = "CreateUserMnBtn";
            this.CreateUserMnBtn.Size = new System.Drawing.Size(197, 79);
            this.CreateUserMnBtn.TabIndex = 15;
            this.CreateUserMnBtn.Text = "Create User";
            this.CreateUserMnBtn.UseVisualStyleBackColor = false;
            this.CreateUserMnBtn.Click += new System.EventHandler(this.CreateUserMenuBtn_Click);
            // 
            // CreateCourseMnBtn
            // 
            this.CreateCourseMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CreateCourseMnBtn.FlatAppearance.BorderSize = 0;
            this.CreateCourseMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCourseMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCourseMnBtn.Location = new System.Drawing.Point(-7, 167);
            this.CreateCourseMnBtn.Name = "CreateCourseMnBtn";
            this.CreateCourseMnBtn.Size = new System.Drawing.Size(197, 79);
            this.CreateCourseMnBtn.TabIndex = 16;
            this.CreateCourseMnBtn.Text = "Create Course";
            this.CreateCourseMnBtn.UseVisualStyleBackColor = false;
            this.CreateCourseMnBtn.Click += new System.EventHandler(this.CreateCourseMenuBtn_Click);
            // 
            // AssignCoursesMnBtn
            // 
            this.AssignCoursesMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.AssignCoursesMnBtn.FlatAppearance.BorderSize = 0;
            this.AssignCoursesMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignCoursesMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignCoursesMnBtn.Location = new System.Drawing.Point(-7, 337);
            this.AssignCoursesMnBtn.Name = "AssignCoursesMnBtn";
            this.AssignCoursesMnBtn.Size = new System.Drawing.Size(197, 79);
            this.AssignCoursesMnBtn.TabIndex = 17;
            this.AssignCoursesMnBtn.Text = "Assign Courses";
            this.AssignCoursesMnBtn.UseVisualStyleBackColor = false;
            this.AssignCoursesMnBtn.Click += new System.EventHandler(this.AssignCoursesMenuBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(-7, 590);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(197, 79);
            this.LogoutBtn.TabIndex = 18;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // EditDelUsersMnBtn
            // 
            this.EditDelUsersMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.EditDelUsersMnBtn.FlatAppearance.BorderSize = 0;
            this.EditDelUsersMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditDelUsersMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDelUsersMnBtn.Location = new System.Drawing.Point(-7, 82);
            this.EditDelUsersMnBtn.Name = "EditDelUsersMnBtn";
            this.EditDelUsersMnBtn.Size = new System.Drawing.Size(197, 79);
            this.EditDelUsersMnBtn.TabIndex = 20;
            this.EditDelUsersMnBtn.Text = "Edit|Delete Users";
            this.EditDelUsersMnBtn.UseVisualStyleBackColor = false;
            this.EditDelUsersMnBtn.Click += new System.EventHandler(this.EditDelUsersMnBtn_Click);
            // 
            // EditDelCoursesMnBtn
            // 
            this.EditDelCoursesMnBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.EditDelCoursesMnBtn.FlatAppearance.BorderSize = 0;
            this.EditDelCoursesMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditDelCoursesMnBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDelCoursesMnBtn.Location = new System.Drawing.Point(-7, 252);
            this.EditDelCoursesMnBtn.Name = "EditDelCoursesMnBtn";
            this.EditDelCoursesMnBtn.Size = new System.Drawing.Size(197, 79);
            this.EditDelCoursesMnBtn.TabIndex = 21;
            this.EditDelCoursesMnBtn.Text = "Edit|Delete Courses";
            this.EditDelCoursesMnBtn.UseVisualStyleBackColor = false;
            this.EditDelCoursesMnBtn.Click += new System.EventHandler(this.EditDelCoursesMnBtn_Click);
            // 
            // CourseGroupBox
            // 
            this.CourseGroupBox.Controls.Add(this.CreateEditCourseLabel);
            this.CourseGroupBox.Controls.Add(this.CancelCoursesBtn);
            this.CourseGroupBox.Controls.Add(this.CreateEditCourseBtn);
            this.CourseGroupBox.Controls.Add(this.CourseTitleBox);
            this.CourseGroupBox.Controls.Add(this.CourseTitleLabel);
            this.CourseGroupBox.Controls.Add(this.CourseTitleErrorLabel);
            this.CourseGroupBox.Location = new System.Drawing.Point(822, 12);
            this.CourseGroupBox.Name = "CourseGroupBox";
            this.CourseGroupBox.Size = new System.Drawing.Size(285, 214);
            this.CourseGroupBox.TabIndex = 15;
            this.CourseGroupBox.TabStop = false;
            this.CourseGroupBox.Text = "CreateEdit Course";
            // 
            // CreateEditCourseLabel
            // 
            this.CreateEditCourseLabel.Location = new System.Drawing.Point(31, 28);
            this.CreateEditCourseLabel.Name = "CreateEditCourseLabel";
            this.CreateEditCourseLabel.Size = new System.Drawing.Size(228, 27);
            this.CreateEditCourseLabel.TabIndex = 32;
            this.CreateEditCourseLabel.Text = "label";
            this.CreateEditCourseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CancelCoursesBtn
            // 
            this.CancelCoursesBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelCoursesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelCoursesBtn.Location = new System.Drawing.Point(102, 171);
            this.CancelCoursesBtn.Name = "CancelCoursesBtn";
            this.CancelCoursesBtn.Size = new System.Drawing.Size(75, 27);
            this.CancelCoursesBtn.TabIndex = 32;
            this.CancelCoursesBtn.Text = "Cancel";
            this.CancelCoursesBtn.UseVisualStyleBackColor = false;
            this.CancelCoursesBtn.Click += new System.EventHandler(this.CancelCoursesBtn_Click);
            // 
            // CreateEditCourseBtn
            // 
            this.CreateEditCourseBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateEditCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateEditCourseBtn.Location = new System.Drawing.Point(53, 119);
            this.CreateEditCourseBtn.Name = "CreateEditCourseBtn";
            this.CreateEditCourseBtn.Size = new System.Drawing.Size(173, 46);
            this.CreateEditCourseBtn.TabIndex = 12;
            this.CreateEditCourseBtn.Text = "Create";
            this.CreateEditCourseBtn.UseVisualStyleBackColor = false;
            this.CreateEditCourseBtn.Click += new System.EventHandler(this.CreateCourseBtn_Click);
            // 
            // CourseTitleBox
            // 
            this.CourseTitleBox.Location = new System.Drawing.Point(31, 87);
            this.CourseTitleBox.Name = "CourseTitleBox";
            this.CourseTitleBox.Size = new System.Drawing.Size(228, 22);
            this.CourseTitleBox.TabIndex = 2;
            // 
            // CourseTitleLabel
            // 
            this.CourseTitleLabel.AutoSize = true;
            this.CourseTitleLabel.Location = new System.Drawing.Point(31, 64);
            this.CourseTitleLabel.Name = "CourseTitleLabel";
            this.CourseTitleLabel.Size = new System.Drawing.Size(79, 17);
            this.CourseTitleLabel.TabIndex = 3;
            this.CourseTitleLabel.Text = "Course title";
            // 
            // CourseTitleErrorLabel
            // 
            this.CourseTitleErrorLabel.BackColor = System.Drawing.Color.Red;
            this.CourseTitleErrorLabel.Location = new System.Drawing.Point(30, 86);
            this.CourseTitleErrorLabel.Name = "CourseTitleErrorLabel";
            this.CourseTitleErrorLabel.Size = new System.Drawing.Size(230, 24);
            this.CourseTitleErrorLabel.TabIndex = 24;
            // 
            // UsersList
            // 
            this.UsersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UsersList.Location = new System.Drawing.Point(994, 490);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(131, 137);
            this.UsersList.TabIndex = 22;
            this.UsersList.UseCompatibleStateImageBehavior = false;
            this.UsersList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsersList_MouseClick);
            // 
            // CoursesList
            // 
            this.CoursesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoursesList.Location = new System.Drawing.Point(853, 490);
            this.CoursesList.Name = "CoursesList";
            this.CoursesList.Size = new System.Drawing.Size(135, 137);
            this.CoursesList.TabIndex = 23;
            this.CoursesList.UseCompatibleStateImageBehavior = false;
            this.CoursesList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CoursesList_MouseClick);
            // 
            // AssignCourseBtn
            // 
            this.AssignCourseBtn.Location = new System.Drawing.Point(640, 490);
            this.AssignCourseBtn.Name = "AssignCourseBtn";
            this.AssignCourseBtn.Size = new System.Drawing.Size(123, 52);
            this.AssignCourseBtn.TabIndex = 24;
            this.AssignCourseBtn.Text = "Assign";
            this.AssignCourseBtn.UseVisualStyleBackColor = true;
            this.AssignCourseBtn.Click += new System.EventHandler(this.AssignCourseBtn_Click);
            // 
            // AssignMsgLabel
            // 
            this.AssignMsgLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AssignMsgLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AssignMsgLabel.Location = new System.Drawing.Point(534, 409);
            this.AssignMsgLabel.Name = "AssignMsgLabel";
            this.AssignMsgLabel.Size = new System.Drawing.Size(246, 44);
            this.AssignMsgLabel.TabIndex = 25;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1261, 669);
            this.Controls.Add(this.AssignMsgLabel);
            this.Controls.Add(this.AssignCourseBtn);
            this.Controls.Add(this.CoursesList);
            this.Controls.Add(this.UsersList);
            this.Controls.Add(this.UserGroupBox);
            this.Controls.Add(this.CourseGroupBox);
            this.Controls.Add(this.EditDelCoursesMnBtn);
            this.Controls.Add(this.EditDelUsersMnBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.AssignCoursesMnBtn);
            this.Controls.Add(this.CreateCourseMnBtn);
            this.Controls.Add(this.CreateUserMnBtn);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1196, 714);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            this.CourseGroupBox.ResumeLayout(false);
            this.CourseGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RegNumBox;
        private System.Windows.Forms.Label RegNumLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.ComboBox CapacityBox;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.Button CreateEditUserBtn;
        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateUserMnBtn;
        private System.Windows.Forms.Button CreateCourseMnBtn;
        private System.Windows.Forms.Button AssignCoursesMnBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button EditDelUsersMnBtn;
        private System.Windows.Forms.Button EditDelCoursesMnBtn;
        private System.Windows.Forms.GroupBox CourseGroupBox;
        private System.Windows.Forms.Button CreateEditCourseBtn;
        private System.Windows.Forms.TextBox CourseTitleBox;
        private System.Windows.Forms.Label CourseTitleLabel;
        private System.Windows.Forms.ListView UsersList;
        private System.Windows.Forms.ListView CoursesList;
        private System.Windows.Forms.Label CourseTitleErrorLabel;
        private System.Windows.Forms.Label EmailMsgLabel;
        private System.Windows.Forms.Label RegNumErrorLabel;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label EmailErrorLabel;
        private System.Windows.Forms.Label SurnameErrorLabel;
        private System.Windows.Forms.Label PassErrorLabel;
        private System.Windows.Forms.Label CapacityErrorLabel;
        private System.Windows.Forms.Label PassMsgLabel;
        private System.Windows.Forms.Label SurnameMsgLabel;
        private System.Windows.Forms.Label CapacityMsgLabel;
        private System.Windows.Forms.Label RegMsgLabel;
        private System.Windows.Forms.Label NameMsgLabel;
        private System.Windows.Forms.Button AssignCourseBtn;
        private System.Windows.Forms.Label AssignMsgLabel;
        private System.Windows.Forms.Button CancelUsersBtn;
        private System.Windows.Forms.Button CancelCoursesBtn;
        private System.Windows.Forms.Label CreateEditUserLabel;
        private System.Windows.Forms.Label CreateEditCourseLabel;
    }
}