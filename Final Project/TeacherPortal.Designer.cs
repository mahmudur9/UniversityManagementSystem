using System.ComponentModel;

namespace Final_Project
{
    partial class TeacherPortal
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
            this.teacherSalaryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherAgeLabel = new System.Windows.Forms.Label();
            this.teacherGenderLabel = new System.Windows.Forms.Label();
            this.teacherEmaillabel = new System.Windows.Forms.Label();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.teacherIdLabel = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Profile);
            this.tabControl1.Controls.Add(this.Classes);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.teacherResetPasswordButton);
            this.Profile.Controls.Add(this.signOutButton);
            this.Profile.Controls.Add(this.teacherSalaryLabel);
            this.Profile.Controls.Add(this.label2);
            this.Profile.Controls.Add(this.teacherAgeLabel);
            this.Profile.Controls.Add(this.teacherGenderLabel);
            this.Profile.Controls.Add(this.teacherEmaillabel);
            this.Profile.Controls.Add(this.teacherNameLabel);
            this.Profile.Controls.Add(this.teacherIdLabel);
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
            this.Profile.Size = new System.Drawing.Size(926, 487);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // teacherResetPasswordButton
            // 
            this.teacherResetPasswordButton.Font = new System.Drawing.Font("Lato", 8.999999F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teacherResetPasswordButton.Location = new System.Drawing.Point(789, 18);
            this.teacherResetPasswordButton.Name = "teacherResetPasswordButton";
            this.teacherResetPasswordButton.Size = new System.Drawing.Size(115, 27);
            this.teacherResetPasswordButton.TabIndex = 108;
            this.teacherResetPasswordButton.Text = "Reset Password";
            this.teacherResetPasswordButton.UseVisualStyleBackColor = true;
            this.teacherResetPasswordButton.Click += new System.EventHandler(this.teacherResetPasswordButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signOutButton.Location = new System.Drawing.Point(79, 360);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(86, 27);
            this.signOutButton.TabIndex = 107;
            this.signOutButton.Text = "Signout";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // teacherSalaryLabel
            // 
            this.teacherSalaryLabel.AutoSize = true;
            this.teacherSalaryLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teacherSalaryLabel.Location = new System.Drawing.Point(167, 309);
            this.teacherSalaryLabel.Name = "teacherSalaryLabel";
            this.teacherSalaryLabel.Size = new System.Drawing.Size(51, 19);
            this.teacherSalaryLabel.TabIndex = 106;
            this.teacherSalaryLabel.Text = "Salary";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(79, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 105;
            this.label2.Text = "Salary:";
            // 
            // teacherAgeLabel
            // 
            this.teacherAgeLabel.AutoSize = true;
            this.teacherAgeLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teacherAgeLabel.Location = new System.Drawing.Point(167, 264);
            this.teacherAgeLabel.Name = "teacherAgeLabel";
            this.teacherAgeLabel.Size = new System.Drawing.Size(36, 19);
            this.teacherAgeLabel.TabIndex = 104;
            this.teacherAgeLabel.Text = "Age";
            // 
            // teacherGenderLabel
            // 
            this.teacherGenderLabel.AutoSize = true;
            this.teacherGenderLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teacherGenderLabel.Location = new System.Drawing.Point(167, 225);
            this.teacherGenderLabel.Name = "teacherGenderLabel";
            this.teacherGenderLabel.Size = new System.Drawing.Size(61, 19);
            this.teacherGenderLabel.TabIndex = 103;
            this.teacherGenderLabel.Text = "Gender";
            // 
            // teacherEmaillabel
            // 
            this.teacherEmaillabel.AutoSize = true;
            this.teacherEmaillabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teacherEmaillabel.Location = new System.Drawing.Point(167, 183);
            this.teacherEmaillabel.Name = "teacherEmaillabel";
            this.teacherEmaillabel.Size = new System.Drawing.Size(47, 19);
            this.teacherEmaillabel.TabIndex = 102;
            this.teacherEmaillabel.Text = "Email";
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teacherNameLabel.Location = new System.Drawing.Point(167, 140);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(50, 19);
            this.teacherNameLabel.TabIndex = 101;
            this.teacherNameLabel.Text = "Name";
            // 
            // teacherIdLabel
            // 
            this.teacherIdLabel.AutoSize = true;
            this.teacherIdLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.teacherIdLabel.Location = new System.Drawing.Point(167, 102);
            this.teacherIdLabel.Name = "teacherIdLabel";
            this.teacherIdLabel.Size = new System.Drawing.Size(79, 19);
            this.teacherIdLabel.TabIndex = 100;
            this.teacherIdLabel.Text = "TeacherID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nameLabel.Location = new System.Drawing.Point(185, 140);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 19);
            this.nameLabel.TabIndex = 99;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailLabel.Location = new System.Drawing.Point(185, 183);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 19);
            this.emailLabel.TabIndex = 98;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.genderLabel.Location = new System.Drawing.Point(185, 225);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(0, 19);
            this.genderLabel.TabIndex = 97;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ageLabel.Location = new System.Drawing.Point(185, 264);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 19);
            this.ageLabel.TabIndex = 96;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.courseLabel.Location = new System.Drawing.Point(185, 305);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(0, 19);
            this.courseLabel.TabIndex = 95;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.paymentLabel.Location = new System.Drawing.Point(185, 309);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(0, 19);
            this.paymentLabel.TabIndex = 94;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.idLabel.Location = new System.Drawing.Point(185, 102);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 19);
            this.idLabel.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(79, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 92;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(79, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 91;
            this.label6.Text = "Email:";
            // 
            // lnfjngjn
            // 
            this.lnfjngjn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lnfjngjn.Location = new System.Drawing.Point(79, 225);
            this.lnfjngjn.Name = "lnfjngjn";
            this.lnfjngjn.Size = new System.Drawing.Size(100, 23);
            this.lnfjngjn.TabIndex = 90;
            this.lnfjngjn.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(79, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 89;
            this.label4.Text = "Age:";
            // 
            // studentName
            // 
            this.studentName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentName.Location = new System.Drawing.Point(79, 102);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(100, 23);
            this.studentName.TabIndex = 88;
            this.studentName.Text = "AdminID:";
            // 
            // Classes
            // 
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(926, 489);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // TeacherPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 513);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeacherPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPortal";
            this.Load += new System.EventHandler(this.TeacherPortal_Load);
            this.tabControl1.ResumeLayout(false);
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label studentName;
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
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label teacherEmaillabel;
        private System.Windows.Forms.Label teacherGenderLabel;
        private System.Windows.Forms.Label teacherAgeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label teacherSalaryLabel;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Label teacherIdLabel;
        private System.Windows.Forms.Button teacherResetPasswordButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.TabPage Classes;
    }
}