using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class StudentPortal : Form
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TSHBB8\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        
        private Thread _thread;

        private static string studentID;

        private String ClassFive;
        private String ClassSix;
        
        public StudentPortal()
        {
            InitializeComponent();
        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadClassInfo();
        }
        
        private void LoadData()
        {
            studentID = Login.UserID;
            
            studentID = Login.UserID;
            studentNameLabel.Text = Login.UserName;
            studentEmaillabel.Text = Login.Email;
            genderLabel.Text = Login.Gender;
            studentAgeLabel.Text = Login.Age;
            studentCourseLabel.Text = Login.Course;

            studentID = Login.UserID;
        }
        
        private void OpenLoginForm(Object o)
        {
            Application.Run(new Login());
        }
        
        private void OpenPasswordResetForm()
        {
            Application.Run(new PasswordResetForm());
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(OpenLoginForm);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void studentResetPasswordButton_Click(object sender, EventArgs e)
        {
            _thread = new Thread(OpenPasswordResetForm);
            _thread.SetApartmentState(ApartmentState.MTA);
            _thread.Start();
        }

        private void LoadClassInfo()
        {
            SqlCommand command = new SqlCommand("select * from Classes where StudentID = @StudentID", connection);

            command.Parameters.AddWithValue("@StudentID", studentID);
            
            DataTable dt = new DataTable();
            
            connection.Open();
            
            SqlDataReader sqlDataReader = command.ExecuteReader();
            
            dt.Load(sqlDataReader);
            
            classesGrid.DataSource = dt;
            
            connection.Close();
        }
    }
}