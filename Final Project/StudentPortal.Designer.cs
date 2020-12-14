using System.ComponentModel;

namespace Final_Project
{
    partial class StudentPortal
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
            this.studentResetPasswordButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.studentCourseLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentAgeLabel = new System.Windows.Forms.Label();
            this.studentGenderLabel = new System.Windows.Forms.Label();
            this.studentEmaillabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
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
            this.classesGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Profile.SuspendLayout();
            this.Classes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.classesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Profile);
            this.tabControl1.Controls.Add(this.Classes);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.studentResetPasswordButton);
            this.Profile.Controls.Add(this.signOutButton);
            this.Profile.Controls.Add(this.studentCourseLabel);
            this.Profile.Controls.Add(this.label2);
            this.Profile.Controls.Add(this.studentAgeLabel);
            this.Profile.Controls.Add(this.studentGenderLabel);
            this.Profile.Controls.Add(this.studentEmaillabel);
            this.Profile.Controls.Add(this.studentNameLabel);
            this.Profile.Controls.Add(this.studentIdLabel);
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
            this.Profile.Size = new System.Drawing.Size(928, 494);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // studentResetPasswordButton
            // 
            this.studentResetPasswordButton.Font = new System.Drawing.Font("Lato", 8.999999F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentResetPasswordButton.Location = new System.Drawing.Point(779, 21);
            this.studentResetPasswordButton.Name = "studentResetPasswordButton";
            this.studentResetPasswordButton.Size = new System.Drawing.Size(115, 27);
            this.studentResetPasswordButton.TabIndex = 86;
            this.studentResetPasswordButton.Text = "Reset Password";
            this.studentResetPasswordButton.UseVisualStyleBackColor = true;
            this.studentResetPasswordButton.Click += new System.EventHandler(this.studentResetPasswordButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signOutButton.Location = new System.Drawing.Point(64, 363);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(86, 27);
            this.signOutButton.TabIndex = 85;
            this.signOutButton.Text = "Signout";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // studentCourseLabel
            // 
            this.studentCourseLabel.AutoSize = true;
            this.studentCourseLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentCourseLabel.Location = new System.Drawing.Point(152, 312);
            this.studentCourseLabel.Name = "studentCourseLabel";
            this.studentCourseLabel.Size = new System.Drawing.Size(51, 19);
            this.studentCourseLabel.TabIndex = 84;
            this.studentCourseLabel.Text = "Salary";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(64, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 83;
            this.label2.Text = "Course:";
            // 
            // studentAgeLabel
            // 
            this.studentAgeLabel.AutoSize = true;
            this.studentAgeLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentAgeLabel.Location = new System.Drawing.Point(152, 268);
            this.studentAgeLabel.Name = "studentAgeLabel";
            this.studentAgeLabel.Size = new System.Drawing.Size(36, 19);
            this.studentAgeLabel.TabIndex = 82;
            this.studentAgeLabel.Text = "Age";
            // 
            // studentGenderLabel
            // 
            this.studentGenderLabel.AutoSize = true;
            this.studentGenderLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentGenderLabel.Location = new System.Drawing.Point(152, 228);
            this.studentGenderLabel.Name = "studentGenderLabel";
            this.studentGenderLabel.Size = new System.Drawing.Size(61, 19);
            this.studentGenderLabel.TabIndex = 81;
            this.studentGenderLabel.Text = "Gender";
            // 
            // studentEmaillabel
            // 
            this.studentEmaillabel.AutoSize = true;
            this.studentEmaillabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentEmaillabel.Location = new System.Drawing.Point(152, 186);
            this.studentEmaillabel.Name = "studentEmaillabel";
            this.studentEmaillabel.Size = new System.Drawing.Size(47, 19);
            this.studentEmaillabel.TabIndex = 80;
            this.studentEmaillabel.Text = "Email";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentNameLabel.Location = new System.Drawing.Point(152, 143);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(50, 19);
            this.studentNameLabel.TabIndex = 79;
            this.studentNameLabel.Text = "Name";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentIdLabel.Location = new System.Drawing.Point(152, 105);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(81, 19);
            this.studentIdLabel.TabIndex = 78;
            this.studentIdLabel.Text = "StudentID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nameLabel.Location = new System.Drawing.Point(171, 143);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 19);
            this.nameLabel.TabIndex = 77;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailLabel.Location = new System.Drawing.Point(171, 186);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 19);
            this.emailLabel.TabIndex = 76;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.genderLabel.Location = new System.Drawing.Point(171, 228);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(0, 19);
            this.genderLabel.TabIndex = 75;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ageLabel.Location = new System.Drawing.Point(171, 268);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 19);
            this.ageLabel.TabIndex = 74;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.courseLabel.Location = new System.Drawing.Point(171, 308);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(0, 19);
            this.courseLabel.TabIndex = 73;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.paymentLabel.Location = new System.Drawing.Point(171, 312);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(0, 19);
            this.paymentLabel.TabIndex = 72;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.idLabel.Location = new System.Drawing.Point(171, 105);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 19);
            this.idLabel.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(64, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(64, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Email:";
            // 
            // lnfjngjn
            // 
            this.lnfjngjn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lnfjngjn.Location = new System.Drawing.Point(64, 228);
            this.lnfjngjn.Name = "lnfjngjn";
            this.lnfjngjn.Size = new System.Drawing.Size(100, 23);
            this.lnfjngjn.TabIndex = 68;
            this.lnfjngjn.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(64, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Age:";
            // 
            // studentName
            // 
            this.studentName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentName.Location = new System.Drawing.Point(64, 105);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(100, 23);
            this.studentName.TabIndex = 66;
            this.studentName.Text = "AdminID:";
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.classesGrid);
            this.Classes.Location = new System.Drawing.Point(4, 24);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(928, 494);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // classesGrid
            // 
            this.classesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classesGrid.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesGrid.Location = new System.Drawing.Point(0, 0);
            this.classesGrid.Name = "classesGrid";
            this.classesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classesGrid.Size = new System.Drawing.Size(925, 117);
            this.classesGrid.TabIndex = 0;
            // 
            // StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 513);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPortal";
            this.Load += new System.EventHandler(this.StudentPortal_Load);
            this.tabControl1.ResumeLayout(false);
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.Classes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.classesGrid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.TabPage Classes;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Label studentCourseLabel;
        private System.Windows.Forms.Label studentAgeLabel;
        private System.Windows.Forms.Label studentGenderLabel;
        private System.Windows.Forms.Label studentEmaillabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Button studentResetPasswordButton;
        private System.Windows.Forms.DataGridView classesGrid;
    }
}