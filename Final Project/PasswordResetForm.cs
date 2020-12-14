using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class PasswordResetForm : Form
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TSHBB8\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        private String userID;
        
        public PasswordResetForm()
        {
            InitializeComponent();
        }

        private void studentPasswordResetButton_Click(object sender, EventArgs e)
        {
            userID = Login.UserID;

            if (OldPasswordBox.Text.Length != 0 && NewPasswordBox.Text.Length != 0)
            {
                SqlCommand command1 = new SqlCommand("select * from UserTable where UserID = @UserID", connection);
                command1.Parameters.AddWithValue("@UserID", userID);

                connection.Open();

                try
                {
                    SqlDataReader sqlDataReader = command1.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        String studentPassword = sqlDataReader["Password"].ToString();
                        
                        connection.Close();
                        
                        if (studentPassword == OldPasswordBox.Text)
                        {
                            SqlCommand command2 = new SqlCommand("update UserTable set Password = @Password where UserID = @UserID", connection);

                            command2.CommandType = CommandType.Text;
                            
                            command2.Parameters.AddWithValue("@Password", NewPasswordBox.Text);
                            command2.Parameters.AddWithValue("@UserID", this.userID);
                            
                            connection.Open();
                            command2.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Password has been successfully changed!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Your old password can not have matched!");
                        }
                        
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            else
            {
                MessageBox.Show("The fields can not be empty!");
            }
        }

        private void StudentPasswordResetCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}