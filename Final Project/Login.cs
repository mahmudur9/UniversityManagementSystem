using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Login : Form
    {
        // Sql connection
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TSHBB8\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        
        // Student Details
        public static String UserID;
        public static String UserName;
        public static String Course;
        public static String Status;
        
        // Common properties
        public static int ID;
        public static String Email;
        public static String Password;
        public static String Gender;
        public static String Age;
        public static String Payment;
        public static String Salary;
        public static String Type;

        private Thread _thread;
        public Login()
        {
            InitializeComponent();
        }
        
        // Open Portal
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread =  new Thread(OpenRegisterForm);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void OpenRegisterForm(Object o)
        {
            Application.Run(new Register());
        }

        // Open student portal
        private void OpenStudentPortal()
        {
            Application.Run(new StudentPortal());
        }
        
        // Open Admin portal
        private void OpenAdminPortal()
        {
            Application.Run(new AdminPortal());
        }
        
        // Open Teacher Portal
        private void OpenTeacherPortal()
        {
            Application.Run(new TeacherPortal());
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            UserLogin();

        }
        
        // User Login
        private void UserLogin()
        {
            SqlCommand command = new SqlCommand("select * from UserTable where UserID = @UserID and Password = @Password", connection);

            command.Parameters.AddWithValue("@UserID",userIdBox.Text);
            command.Parameters.AddWithValue("@Password",userPassBox.Text);
            
            connection.Open();

            try
            {
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    UserID = sqlDataReader["UserID"].ToString();
                    UserName = sqlDataReader["UserName"].ToString();
                    Email = sqlDataReader["Email"].ToString();
                    Gender = sqlDataReader["Gender"].ToString();
                    Age = sqlDataReader["Age"].ToString();
                    Course = sqlDataReader["Course"].ToString();
//                    Payment = sqlDataReader["Payment"].ToString();
                    Type = sqlDataReader["Type"].ToString();
                    Salary = sqlDataReader["Salary"].ToString();
                    Status = sqlDataReader["Status"].ToString();
                }
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();
            
            int count = ds.Tables[0].Rows.Count;

            if (userIdBox.Text != "" && userPassBox.Text != "")
            {
                if (count == 1 && Type == "Student")
                {
                    if (Status == "Approved")
                    {
                        MessageBox.Show("Login Successful!");
                        this.Close();
                        _thread =  new Thread(OpenStudentPortal);
                        _thread.SetApartmentState(ApartmentState.MTA);
                        _thread.Start();
                    }
                    else
                    {
                        MessageBox.Show("You are not a valid user!");
                    }
                }
                else if(count == 1 && Type == "Admin")
                {
                    MessageBox.Show("Login Successful!");
                    this.Close();
                    _thread =  new Thread(OpenAdminPortal);
                    _thread.SetApartmentState(ApartmentState.MTA);
                    _thread.Start();
                }
                else if (count == 1 && Type == "Teacher")
                {
                    MessageBox.Show("Login Successful!");
                    this.Close();
                    _thread =  new Thread(OpenTeacherPortal);
                    _thread.SetApartmentState(ApartmentState.MTA);
                    _thread.Start();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
            }
            else
            {
                MessageBox.Show("The fields can not be empty!");
            }
        }
    }
}