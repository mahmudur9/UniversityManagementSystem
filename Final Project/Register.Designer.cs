using System.ComponentModel;

namespace Final_Project
{
    partial class Register
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lnfjngjn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.userEmailBox = new System.Windows.Forms.TextBox();
            this.userPasswordBox = new System.Windows.Forms.TextBox();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.userAgeBox = new System.Windows.Forms.TextBox();
            this.userCourseBox = new System.Windows.Forms.ComboBox();
            this.SignupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(476, 348);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register as a student";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(259, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 56;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(259, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Email:";
            // 
            // lnfjngjn
            // 
            this.lnfjngjn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lnfjngjn.Location = new System.Drawing.Point(259, 218);
            this.lnfjngjn.Name = "lnfjngjn";
            this.lnfjngjn.Size = new System.Drawing.Size(100, 23);
            this.lnfjngjn.TabIndex = 54;
            this.lnfjngjn.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(259, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(259, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Course:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(259, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "Password:";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(350, 110);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(226, 23);
            this.userNameBox.TabIndex = 58;
            // 
            // userEmailBox
            // 
            this.userEmailBox.Location = new System.Drawing.Point(350, 148);
            this.userEmailBox.Name = "userEmailBox";
            this.userEmailBox.Size = new System.Drawing.Size(226, 23);
            this.userEmailBox.TabIndex = 59;
            // 
            // userPasswordBox
            // 
            this.userPasswordBox.Location = new System.Drawing.Point(350, 185);
            this.userPasswordBox.Name = "userPasswordBox";
            this.userPasswordBox.Size = new System.Drawing.Size(226, 23);
            this.userPasswordBox.TabIndex = 60;
            // 
            // maleButton
            // 
            this.maleButton.Location = new System.Drawing.Point(350, 218);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(104, 24);
            this.maleButton.TabIndex = 61;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            this.femaleButton.Location = new System.Drawing.Point(472, 218);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(104, 24);
            this.femaleButton.TabIndex = 62;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // userAgeBox
            // 
            this.userAgeBox.Location = new System.Drawing.Point(350, 258);
            this.userAgeBox.Name = "userAgeBox";
            this.userAgeBox.Size = new System.Drawing.Size(226, 23);
            this.userAgeBox.TabIndex = 63;
            // 
            // userCourseBox
            // 
            this.userCourseBox.FormattingEnabled = true;
            this.userCourseBox.Location = new System.Drawing.Point(350, 298);
            this.userCourseBox.Name = "userCourseBox";
            this.userCourseBox.Size = new System.Drawing.Size(97, 23);
            this.userCourseBox.TabIndex = 64;
            // 
            // SignupButton
            // 
            this.SignupButton.Location = new System.Drawing.Point(350, 348);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(100, 29);
            this.SignupButton.TabIndex = 65;
            this.SignupButton.Text = "Signup";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 513);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.userCourseBox);
            this.Controls.Add(this.userAgeBox);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.userPasswordBox);
            this.Controls.Add(this.userEmailBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnfjngjn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lnfjngjn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox userEmailBox;
        private System.Windows.Forms.TextBox userPasswordBox;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.TextBox userAgeBox;
        private System.Windows.Forms.ComboBox userCourseBox;
    }
}