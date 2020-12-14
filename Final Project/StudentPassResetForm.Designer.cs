using System.ComponentModel;

namespace Final_Project
{
    partial class PasswordResetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.studentPasswordResetButton = new System.Windows.Forms.Button();
            this.StudentPasswordResetCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "Old password:";
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Location = new System.Drawing.Point(169, 37);
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.PasswordChar = '*';
            this.OldPasswordBox.Size = new System.Drawing.Size(180, 23);
            this.OldPasswordBox.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "New password:";
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(169, 81);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.PasswordChar = '*';
            this.NewPasswordBox.Size = new System.Drawing.Size(180, 23);
            this.NewPasswordBox.TabIndex = 74;
            // 
            // studentPasswordResetButton
            // 
            this.studentPasswordResetButton.Location = new System.Drawing.Point(169, 128);
            this.studentPasswordResetButton.Name = "studentPasswordResetButton";
            this.studentPasswordResetButton.Size = new System.Drawing.Size(80, 29);
            this.studentPasswordResetButton.TabIndex = 79;
            this.studentPasswordResetButton.Text = "Reset";
            this.studentPasswordResetButton.UseVisualStyleBackColor = true;
            this.studentPasswordResetButton.Click += new System.EventHandler(this.studentPasswordResetButton_Click);
            // 
            // StudentPasswordResetCancelButton
            // 
            this.StudentPasswordResetCancelButton.Location = new System.Drawing.Point(268, 128);
            this.StudentPasswordResetCancelButton.Name = "StudentPasswordResetCancelButton";
            this.StudentPasswordResetCancelButton.Size = new System.Drawing.Size(80, 29);
            this.StudentPasswordResetCancelButton.TabIndex = 80;
            this.StudentPasswordResetCancelButton.Text = "Cancel";
            this.StudentPasswordResetCancelButton.UseVisualStyleBackColor = true;
            this.StudentPasswordResetCancelButton.Click +=
                new System.EventHandler(this.StudentPasswordResetCancelButton_Click);
            // 
            // PasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 245);
            this.Controls.Add(this.StudentPasswordResetCancelButton);
            this.Controls.Add(this.studentPasswordResetButton);
            this.Controls.Add(this.NewPasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OldPasswordBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordResetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPassResetForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.Button StudentPasswordResetCancelButton;
        private System.Windows.Forms.Button studentPasswordResetButton;
        private System.Windows.Forms.TextBox NewPasswordBox;
    }
}