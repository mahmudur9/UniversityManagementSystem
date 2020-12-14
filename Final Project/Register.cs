using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Register : Form
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TSHBB8\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        
        private int id;
        private String gender;
        private String age;
        private String Type = "Student";
        private String Status = "Pending";
        

        private Thread _thread;
        public Register()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }

        private void OpenLoginForm(Object o)
        {
            Application.Run(new Login());
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                SqlCommand command = new SqlCommand("insert into UserTable values (@UserID,@UserName,@Email,@Password,@Gender,@Age,@Course,@Classes,@Type,@Status,@Salary)", connection);
                SqlCommand cmd2 = new SqlCommand("select count(ID) from UserTable where Type = 'Student'", connection);
                
                connection.Open();
                
                int row_count = Convert.ToInt32(cmd2.ExecuteScalar()) + 1;
                String ID = row_count.ToString();
                
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@UserID","20-" + ID + "-3");
                command.Parameters.AddWithValue("@UserName", userNameBox.Text);
                command.Parameters.AddWithValue("@Email", userEmailBox.Text);
                command.Parameters.AddWithValue("@Password", userPasswordBox.Text);
                if (maleButton.Checked)
                {
                    gender = "Male";
                }
                else if(femaleButton.Checked)
                {
                    gender = "Female";
                }
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Age", userAgeBox.Text);
                command.Parameters.AddWithValue("@Course", userCourseBox.Text);
                command.Parameters.AddWithValue("@Classes", "");
                command.Parameters.AddWithValue("@Type", Type);
                command.Parameters.AddWithValue("@Status", Status);
                command.Parameters.AddWithValue("@Salary", "");

                
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Registration completed successfully!");
                InsertDataIntoStudentTable();
                BackToLogin();
            }
            else
            {
                MessageBox.Show("The fields can not be empty!");
            }
        }

        private void InsertDataIntoStudentTable()
        {
            SqlCommand command = new SqlCommand("insert into Student values (@UserID,@UserName,@Email,@Gender,@Age,@Course,@Classes,@Status)", connection);
            SqlCommand cmd2 = new SqlCommand("select count(ID) from Student", connection);
                
            connection.Open();
                
            int row_count = Convert.ToInt32(cmd2.ExecuteScalar()) + 1;
            String ID = row_count.ToString();
                
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@UserID","20-" + ID + "-3");
            command.Parameters.AddWithValue("@UserName", userNameBox.Text);
            command.Parameters.AddWithValue("@Email", userEmailBox.Text);
            if (maleButton.Checked)
            {
                gender = "Male";
            }
            else if(femaleButton.Checked)
            {
                gender = "Female";
            }
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Age", userAgeBox.Text);
            command.Parameters.AddWithValue("@Course", userCourseBox.Text);
            command.Parameters.AddWithValue("@Classes", "");
            command.Parameters.AddWithValue("@Status", Status);


            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            userCourseBox.Items.Add("CSE");
            userCourseBox.Items.Add("EEE");
        }

        private bool Valid()
        {
            if (userNameBox.Text != "" && userEmailBox.Text != "" && userPasswordBox.Text != "" && gender != "" &&
                userAgeBox.Text != "" && userCourseBox.Text != "")
            {
                return true;
            }

            return false;
        }

        private void BackToLogin()
        {
            this.Close();
            _thread = new Thread(OpenLoginForm);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }
    }
}