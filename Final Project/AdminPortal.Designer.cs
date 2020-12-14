using System.ComponentModel;

namespace Final_Project
{
    partial class AdminPortal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Profile = new System.Windows.Forms.TabPage();
            this.teacherResetPasswordButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.adminSalaryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminAgeLabel = new System.Windows.Forms.Label();
            this.adminGenderLabel = new System.Windows.Forms.Label();
            this.adminEmaillabel = new System.Windows.Forms.Label();
            this.adminNameLabel = new System.Windows.Forms.Label();
            this.adminIdLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lnfjngjn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.TabPage();
            this.assignClassButton = new System.Windows.Forms.Button();
            this.studentSearchBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.studentApproveButton = new System.Windows.Forms.Button();
            this.studentUpdateButton = new System.Windows.Forms.Button();
            this.userCourseBox = new System.Windows.Forms.ComboBox();
            this.userAgeBox = new System.Windows.Forms.TextBox();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.userEmailBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.Notices = new System.Windows.Forms.TabPage();
            this.teacherSearchBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.teacherSalaryBox = new System.Windows.Forms.TextBox();
            this.teacherRegisterButton = new System.Windows.Forms.Button();
            this.teacherAgeBox = new System.Windows.Forms.TextBox();
            this.teacherFemaleButton = new System.Windows.Forms.RadioButton();
            this.teacherMaleButton = new System.Windows.Forms.RadioButton();
            this.teacherPasswordBox = new System.Windows.Forms.TextBox();
            this.teacherEmailBox = new System.Windows.Forms.TextBox();
            this.teacherNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.teacherUpdateButton = new System.Windows.Forms.Button();
            this.teacherGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Profile.SuspendLayout();
            this.Classes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.studentGrid)).BeginInit();
            this.Notices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.teacherGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Profile);
            this.tabControl1.Controls.Add(this.Classes);
            this.tabControl1.Controls.Add(this.Notices);
            this.tabControl1.Location = new System.Drawing.Point(-6, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 542);
            this.tabControl1.TabIndex = 1;
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.teacherResetPasswordButton);
            this.Profile.Controls.Add(this.signOutButton);
            this.Profile.Controls.Add(this.adminSalaryLabel);
            this.Profile.Controls.Add(this.label2);
            this.Profile.Controls.Add(this.adminAgeLabel);
            this.Profile.Controls.Add(this.adminGenderLabel);
            this.Profile.Controls.Add(this.adminEmaillabel);
            this.Profile.Controls.Add(this.adminNameLabel);
            this.Profile.Controls.Add(this.adminIdLabel);
            this.Profile.Controls.Add(this.nameLabel);
            this.Profile.Controls.Add(this.emailLabel);
            this.Profile.Controls.Add(this.genderLabel);
            this.Profile.Controls.Add(this.ageLabel);
            this.Profile.Controls.Add(this.courseLabel);
            this.Profile.Controls.Add(this.paymentLabel);
            this.Profile.Controls.Add(this.idLabel);
            this.Profile.Controls.Add(this.label7);
            this.Profile.Controls.Add(this.label6);
            this.Profile.Controls.Add(this.lnfjngjn);
            this.Profile.Controls.Add(this.label4);
            this.Profile.Controls.Add(this.studentName);
            this.Profile.Location = new System.Drawing.Point(4, 24);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(3);
            this.Profile.Size = new System.Drawing.Size(925, 514);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // teacherResetPasswordButton
            // 
            this.teacherResetPasswordButton.Font = new System.Drawing.Font("Lato", 8.999999F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teacherResetPasswordButton.Location = new System.Drawing.Point(793, 16);
            this.teacherResetPasswordButton.Name = "teacherResetPasswordButton";
            this.teacherResetPasswordButton.Size = new System.Drawing.Size(115, 27);
            this.teacherResetPasswordButton.TabIndex = 88;
            this.teacherResetPasswordButton.Text = "Reset Password";
            this.teacherResetPasswordButton.UseVisualStyleBackColor = true;
            this.teacherResetPasswordButton.Click += new System.EventHandler(this.adminResetPasswordButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signOutButton.Location = new System.Drawing.Point(73, 357);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(86, 27);
            this.signOutButton.TabIndex = 65;
            this.signOutButton.Text = "Signout";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // adminSalaryLabel
            // 
            this.adminSalaryLabel.AutoSize = true;
            this.adminSalaryLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.adminSalaryLabel.Location = new System.Drawing.Point(161, 306);
            this.adminSalaryLabel.Name = "adminSalaryLabel";
            this.adminSalaryLabel.Size = new System.Drawing.Size(51, 19);
            this.adminSalaryLabel.TabIndex = 64;
            this.adminSalaryLabel.Text = "Salary";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(73, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Salary:";
            // 
            // adminAgeLabel
            // 
            this.adminAgeLabel.AutoSize = true;
            this.adminAgeLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.adminAgeLabel.Location = new System.Drawing.Point(161, 262);
            this.adminAgeLabel.Name = "adminAgeLabel";
            this.adminAgeLabel.Size = new System.Drawing.Size(36, 19);
            this.adminAgeLabel.TabIndex = 61;
            this.adminAgeLabel.Text = "Age";
            // 
            // adminGenderLabel
            // 
            this.adminGenderLabel.AutoSize = true;
            this.adminGenderLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.adminGenderLabel.Location = new System.Drawing.Point(161, 222);
            this.adminGenderLabel.Name = "adminGenderLabel";
            this.adminGenderLabel.Size = new System.Drawing.Size(61, 19);
            this.adminGenderLabel.TabIndex = 60;
            this.adminGenderLabel.Text = "Gender";
            // 
            // adminEmaillabel
            // 
            this.adminEmaillabel.AutoSize = true;
            this.adminEmaillabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.adminEmaillabel.Location = new System.Drawing.Point(161, 180);
            this.adminEmaillabel.Name = "adminEmaillabel";
            this.adminEmaillabel.Size = new System.Drawing.Size(47, 19);
            this.adminEmaillabel.TabIndex = 59;
            this.adminEmaillabel.Text = "Email";
            // 
            // adminNameLabel
            // 
            this.adminNameLabel.AutoSize = true;
            this.adminNameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.adminNameLabel.Location = new System.Drawing.Point(161, 137);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(50, 19);
            this.adminNameLabel.TabIndex = 58;
            this.adminNameLabel.Text = "Name";
            // 
            // adminIdLabel
            // 
            this.adminIdLabel.AutoSize = true;
            this.adminIdLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.adminIdLabel.Location = new System.Drawing.Point(161, 99);
            this.adminIdLabel.Name = "adminIdLabel";
            this.adminIdLabel.Size = new System.Drawing.Size(72, 19);
            this.adminIdLabel.TabIndex = 57;
            this.adminIdLabel.Text = "AdminID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nameLabel.Location = new System.Drawing.Point(180, 137);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 19);
            this.nameLabel.TabIndex = 56;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailLabel.Location = new System.Drawing.Point(180, 180);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 19);
            this.emailLabel.TabIndex = 55;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.genderLabel.Location = new System.Drawing.Point(180, 222);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(0, 19);
            this.genderLabel.TabIndex = 54;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ageLabel.Location = new System.Drawing.Point(180, 262);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 19);
            this.ageLabel.TabIndex = 53;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.courseLabel.Location = new System.Drawing.Point(180, 302);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(0, 19);
            this.courseLabel.TabIndex = 52;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.paymentLabel.Location = new System.Drawing.Point(180, 306);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(0, 19);
            this.paymentLabel.TabIndex = 51;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.idLabel.Location = new System.Drawing.Point(180, 99);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 19);
            this.idLabel.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(73, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 49;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(73, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Email:";
            // 
            // lnfjngjn
            // 
            this.lnfjngjn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lnfjngjn.Location = new System.Drawing.Point(73, 222);
            this.lnfjngjn.Name = "lnfjngjn";
            this.lnfjngjn.Size = new System.Drawing.Size(100, 23);
            this.lnfjngjn.TabIndex = 47;
            this.lnfjngjn.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(73, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Age:";
            // 
            // studentName
            // 
            this.studentName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentName.Location = new System.Drawing.Point(73, 99);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(100, 23);
            this.studentName.TabIndex = 43;
            this.studentName.Text = "AdminID:";
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.assignClassButton);
            this.Classes.Controls.Add(this.studentSearchBox);
            this.Classes.Controls.Add(this.label16);
            this.Classes.Controls.Add(this.studentApproveButton);
            this.Classes.Controls.Add(this.studentUpdateButton);
            this.Classes.Controls.Add(this.userCourseBox);
            this.Classes.Controls.Add(this.userAgeBox);
            this.Classes.Controls.Add(this.femaleButton);
            this.Classes.Controls.Add(this.maleButton);
            this.Classes.Controls.Add(this.userEmailBox);
            this.Classes.Controls.Add(this.userNameBox);
            this.Classes.Controls.Add(this.label1);
            this.Classes.Controls.Add(this.label3);
            this.Classes.Controls.Add(this.label8);
            this.Classes.Controls.Add(this.label9);
            this.Classes.Controls.Add(this.label10);
            this.Classes.Controls.Add(this.studentGrid);
            this.Classes.Location = new System.Drawing.Point(4, 24);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(925, 514);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Students";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // assignClassButton
            // 
            this.assignClassButton.Location = new System.Drawing.Point(423, 155);
            this.assignClassButton.Name = "assignClassButton";
            this.assignClassButton.Size = new System.Drawing.Size(100, 29);
            this.assignClassButton.TabIndex = 85;
            this.assignClassButton.Text = "Assign Class";
            this.assignClassButton.UseVisualStyleBackColor = true;
            this.assignClassButton.Click += new System.EventHandler(this.assignClassButton_Click);
            // 
            // studentSearchBox
            // 
            this.studentSearchBox.Location = new System.Drawing.Point(689, 155);
            this.studentSearchBox.Name = "studentSearchBox";
            this.studentSearchBox.Size = new System.Drawing.Size(167, 23);
            this.studentSearchBox.TabIndex = 81;
            this.studentSearchBox.TextChanged += new System.EventHandler(this.studentSearchBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(624, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 19);
            this.label16.TabIndex = 80;
            this.label16.Text = "Search:";
            // 
            // studentApproveButton
            // 
            this.studentApproveButton.Location = new System.Drawing.Point(252, 235);
            this.studentApproveButton.Name = "studentApproveButton";
            this.studentApproveButton.Size = new System.Drawing.Size(100, 29);
            this.studentApproveButton.TabIndex = 79;
            this.studentApproveButton.Text = "Approve";
            this.studentApproveButton.UseVisualStyleBackColor = true;
            this.studentApproveButton.Click += new System.EventHandler(this.studentApproveButton_Click);
            // 
            // studentUpdateButton
            // 
            this.studentUpdateButton.Location = new System.Drawing.Point(122, 235);
            this.studentUpdateButton.Name = "studentUpdateButton";
            this.studentUpdateButton.Size = new System.Drawing.Size(100, 29);
            this.studentUpdateButton.TabIndex = 78;
            this.studentUpdateButton.Text = "Update";
            this.studentUpdateButton.UseVisualStyleBackColor = true;
            this.studentUpdateButton.Click += new System.EventHandler(this.studentUpdateButton_Click);
            // 
            // userCourseBox
            // 
            this.userCourseBox.FormattingEnabled = true;
            this.userCourseBox.Location = new System.Drawing.Point(126, 195);
            this.userCourseBox.Name = "userCourseBox";
            this.userCourseBox.Size = new System.Drawing.Size(97, 23);
            this.userCourseBox.TabIndex = 77;
            // 
            // userAgeBox
            // 
            this.userAgeBox.Location = new System.Drawing.Point(126, 155);
            this.userAgeBox.Name = "userAgeBox";
            this.userAgeBox.Size = new System.Drawing.Size(226, 23);
            this.userAgeBox.TabIndex = 76;
            // 
            // femaleButton
            // 
            this.femaleButton.Location = new System.Drawing.Point(248, 115);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(104, 24);
            this.femaleButton.TabIndex = 75;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            this.maleButton.Location = new System.Drawing.Point(126, 115);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(104, 24);
            this.maleButton.TabIndex = 74;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // userEmailBox
            // 
            this.userEmailBox.Location = new System.Drawing.Point(126, 75);
            this.userEmailBox.Name = "userEmailBox";
            this.userEmailBox.Size = new System.Drawing.Size(226, 23);
            this.userEmailBox.TabIndex = 72;
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(126, 37);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(226, 23);
            this.userNameBox.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(35, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Email:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(35, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(35, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 66;
            this.label9.Text = "Age:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(35, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 65;
            this.label10.Text = "Course:";
            // 
            // studentGrid
            // 
            this.studentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGrid.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Location = new System.Drawing.Point(252, 265);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGrid.Size = new System.Drawing.Size(674, 224);
            this.studentGrid.TabIndex = 0;
            this.studentGrid.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGrid_CellClick);
            this.studentGrid.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGrid_CellDoubleClick);
            this.studentGrid.MouseHover += new System.EventHandler(this.studentGrid_MouseHover_1);
            // 
            // Notices
            // 
            this.Notices.Controls.Add(this.teacherSearchBox);
            this.Notices.Controls.Add(this.label17);
            this.Notices.Controls.Add(this.teacherSalaryBox);
            this.Notices.Controls.Add(this.teacherRegisterButton);
            this.Notices.Controls.Add(this.teacherAgeBox);
            this.Notices.Controls.Add(this.teacherFemaleButton);
            this.Notices.Controls.Add(this.teacherMaleButton);
            this.Notices.Controls.Add(this.teacherPasswordBox);
            this.Notices.Controls.Add(this.teacherEmailBox);
            this.Notices.Controls.Add(this.teacherNameBox);
            this.Notices.Controls.Add(this.label5);
            this.Notices.Controls.Add(this.label11);
            this.Notices.Controls.Add(this.label12);
            this.Notices.Controls.Add(this.label13);
            this.Notices.Controls.Add(this.label14);
            this.Notices.Controls.Add(this.label15);
            this.Notices.Controls.Add(this.teacherUpdateButton);
            this.Notices.Controls.Add(this.teacherGrid);
            this.Notices.Location = new System.Drawing.Point(4, 22);
            this.Notices.Name = "Notices";
            this.Notices.Size = new System.Drawing.Size(925, 516);
            this.Notices.TabIndex = 2;
            this.Notices.Text = "Teachers";
            this.Notices.UseVisualStyleBackColor = true;
            // 
            // teacherSearchBox
            // 
            this.teacherSearchBox.Location = new System.Drawing.Point(702, 163);
            this.teacherSearchBox.Name = "teacherSearchBox";
            this.teacherSearchBox.Size = new System.Drawing.Size(167, 23);
            this.teacherSearchBox.TabIndex = 83;
            this.teacherSearchBox.TextChanged += new System.EventHandler(this.teacherSearchBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.Location = new System.Drawing.Point(637, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 19);
            this.label17.TabIndex = 82;
            this.label17.Text = "Search:";
            // 
            // teacherSalaryBox
            // 
            this.teacherSalaryBox.Location = new System.Drawing.Point(105, 204);
            this.teacherSalaryBox.Name = "teacherSalaryBox";
            this.teacherSalaryBox.Size = new System.Drawing.Size(226, 23);
            this.teacherSalaryBox.TabIndex = 81;
            // 
            // teacherRegisterButton
            // 
            this.teacherRegisterButton.Location = new System.Drawing.Point(105, 253);
            this.teacherRegisterButton.Name = "teacherRegisterButton";
            this.teacherRegisterButton.Size = new System.Drawing.Size(100, 29);
            this.teacherRegisterButton.TabIndex = 80;
            this.teacherRegisterButton.Text = "Register";
            this.teacherRegisterButton.UseVisualStyleBackColor = true;
            this.teacherRegisterButton.Click += new System.EventHandler(this.teacherRegisterButton_Click);
            // 
            // teacherAgeBox
            // 
            this.teacherAgeBox.Location = new System.Drawing.Point(105, 163);
            this.teacherAgeBox.Name = "teacherAgeBox";
            this.teacherAgeBox.Size = new System.Drawing.Size(226, 23);
            this.teacherAgeBox.TabIndex = 78;
            // 
            // teacherFemaleButton
            // 
            this.teacherFemaleButton.Location = new System.Drawing.Point(227, 123);
            this.teacherFemaleButton.Name = "teacherFemaleButton";
            this.teacherFemaleButton.Size = new System.Drawing.Size(104, 24);
            this.teacherFemaleButton.TabIndex = 77;
            this.teacherFemaleButton.TabStop = true;
            this.teacherFemaleButton.Text = "Female";
            this.teacherFemaleButton.UseVisualStyleBackColor = true;
            // 
            // teacherMaleButton
            // 
            this.teacherMaleButton.Location = new System.Drawing.Point(105, 123);
            this.teacherMaleButton.Name = "teacherMaleButton";
            this.teacherMaleButton.Size = new System.Drawing.Size(104, 24);
            this.teacherMaleButton.TabIndex = 76;
            this.teacherMaleButton.TabStop = true;
            this.teacherMaleButton.Text = "Male";
            this.teacherMaleButton.UseVisualStyleBackColor = true;
            // 
            // teacherPasswordBox
            // 
            this.teacherPasswordBox.Location = new System.Drawing.Point(105, 90);
            this.teacherPasswordBox.Name = "teacherPasswordBox";
            this.teacherPasswordBox.Size = new System.Drawing.Size(226, 23);
            this.teacherPasswordBox.TabIndex = 75;
            // 
            // teacherEmailBox
            // 
            this.teacherEmailBox.Location = new System.Drawing.Point(105, 53);
            this.teacherEmailBox.Name = "teacherEmailBox";
            this.teacherEmailBox.Size = new System.Drawing.Size(226, 23);
            this.teacherEmailBox.TabIndex = 74;
            // 
            // teacherNameBox
            // 
            this.teacherNameBox.Location = new System.Drawing.Point(105, 15);
            this.teacherNameBox.Name = "teacherNameBox";
            this.teacherNameBox.Size = new System.Drawing.Size(226, 23);
            this.teacherNameBox.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(14, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 72;
            this.label5.Text = "Password:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(14, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 71;
            this.label11.Text = "Name:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(14, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 70;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.Location = new System.Drawing.Point(14, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 69;
            this.label13.Text = "Gender:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.Location = new System.Drawing.Point(14, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 68;
            this.label14.Text = "Age:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.Location = new System.Drawing.Point(14, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 67;
            this.label15.Text = "Salary:";
            // 
            // teacherUpdateButton
            // 
            this.teacherUpdateButton.Location = new System.Drawing.Point(231, 253);
            this.teacherUpdateButton.Name = "teacherUpdateButton";
            this.teacherUpdateButton.Size = new System.Drawing.Size(100, 29);
            this.teacherUpdateButton.TabIndex = 66;
            this.teacherUpdateButton.Text = "Update";
            this.teacherUpdateButton.UseVisualStyleBackColor = true;
            this.teacherUpdateButton.Click += new System.EventHandler(this.teacherUpdateButton_Click);
            // 
            // teacherGrid
            // 
            this.teacherGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherGrid.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherGrid.Location = new System.Drawing.Point(346, 265);
            this.teacherGrid.Name = "teacherGrid";
            this.teacherGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherGrid.Size = new System.Drawing.Size(577, 224);
            this.teacherGrid.TabIndex = 1;
            this.teacherGrid.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherGrid_CellClick);
            this.teacherGrid.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherGrid_CellDoubleClick);
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 513);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPortal";
            this.Load += new System.EventHandler(this.AdminPortal_Load);
            this.tabControl1.ResumeLayout(false);
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.Classes.ResumeLayout(false);
            this.Classes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.studentGrid)).EndInit();
            this.Notices.ResumeLayout(false);
            this.Notices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.teacherGrid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage Notices;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lnfjngjn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label adminIdLabel;
        private System.Windows.Forms.Label adminSalaryLabel;
        private System.Windows.Forms.Label adminAgeLabel;
        private System.Windows.Forms.Label adminGenderLabel;
        private System.Windows.Forms.Label adminEmaillabel;
        private System.Windows.Forms.Label adminNameLabel;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox userEmailBox;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.TextBox userAgeBox;
        private System.Windows.Forms.ComboBox userCourseBox;
        private System.Windows.Forms.Button studentUpdateButton;
        private System.Windows.Forms.Button studentApproveButton;
        private System.Windows.Forms.DataGridView teacherGrid;
        private System.Windows.Forms.Button teacherUpdateButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button teacherRegisterButton;
        private System.Windows.Forms.TextBox teacherNameBox;
        private System.Windows.Forms.TextBox teacherEmailBox;
        private System.Windows.Forms.TextBox teacherPasswordBox;
        private System.Windows.Forms.RadioButton teacherMaleButton;
        private System.Windows.Forms.RadioButton teacherFemaleButton;
        private System.Windows.Forms.TextBox teacherAgeBox;
        private System.Windows.Forms.TextBox teacherSalaryBox;
        private System.Windows.Forms.Button teacherResetPasswordButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox studentSearchBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox teacherSearchBox;
        private System.Windows.Forms.Button assignClassButton;
    }
}