using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class AdminPortal : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TSHBB8\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        
        private Thread _thread;
        
        // Student Details
        private int id;
        private String UserID;
        private static String UserName;
        private static String Course;
        private static String Status;
        private static int ID;
        private static String Email;
        private static String Password;
        private static String Gender;
        private static String Age;
        private static String Payment;
        private static String Salary;
        private static String Type;
        
        // Teacher Details
        private String teacherID;

        private String teacherGender;
        
        private ToolTip _toolTip;

        private DataTable _dataTable;
        
        // Student ID for assigning Classes
        public static String studentID = "";
        
        // Teacher User Name for assigning class
        public static String[] teacherName;
        public static String[] TeacherID;
        
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadStudentDataIntoGrid();
            LoadTeacherDataIntoGrid();
            LoadTeachersName();
        }

        private void LoadData()
        {
            adminIdLabel.Text = Login.UserID;
            adminNameLabel.Text = Login.UserName;
            adminEmaillabel.Text = Login.Email;
            adminGenderLabel.Text = Login.Gender;
            adminAgeLabel.Text = Login.Age;
            adminSalaryLabel.Text = Login.Salary;

            userCourseBox.Items.Add("CSE");
            userCourseBox.Items.Add("EEE");
        }
        
        private void OpenLoginForm(Object o)
        {
            Application.Run(new Login());
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(OpenLoginForm);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void LoadStudentDataIntoGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from Student", connection);

            DataTable dt = new DataTable();
            
            connection.Open();

            /*studentGrid.AutoGenerateColumns = false;
            studentGrid.ColumnCount = 7;

            studentGrid.Columns[0].HeaderText = "Student ID";
            studentGrid.Columns[0].DataPropertyName = "UserID";
            
            studentGrid.Columns[1].HeaderText = "Student Name";
            studentGrid.Columns[1].DataPropertyName = "UserName";

            studentGrid.Columns[2].HeaderText = "Email";
            studentGrid.Columns[2].DataPropertyName = "Email";
            
            studentGrid.Columns[3].HeaderText = "Gender";
            studentGrid.Columns[3].DataPropertyName = "Gender";
            
            studentGrid.Columns[4].HeaderText = "Age";
            studentGrid.Columns[4].DataPropertyName = "Age";
            
            studentGrid.Columns[5].HeaderText = "Course";
            studentGrid.Columns[5].DataPropertyName = "Course";
            
            studentGrid.Columns[6].HeaderText = "Status";
            studentGrid.Columns[6].DataPropertyName = "Status";
*/

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            
            dt.Load(sqlDataReader);
            
            studentGrid.DataSource = dt;
            connection.Close();
            
        }

        private void LoadTeacherDataIntoGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from Teacher", connection);
            DataTable dt = new DataTable();
            connection.Open();

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);
            teacherGrid.DataSource = dt;
            connection.Close();
        }

        private void studentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID = studentGrid.SelectedRows[0].Cells[1].Value.ToString();
            studentID = UserID;
            userNameBox.Text = studentGrid.SelectedRows[0].Cells[2].Value.ToString();
            userEmailBox.Text = studentGrid.SelectedRows[0].Cells[3].Value.ToString();
            // For gender
            String gender = studentGrid.SelectedRows[0].Cells[4].Value.ToString();
            if (gender == "Male")
            {
                maleButton.Checked = true;
            }
            else
            {
                femaleButton.Checked = true;
            }
            userAgeBox.Text = studentGrid.SelectedRows[0].Cells[5].Value.ToString();
            userCourseBox.Text = studentGrid.SelectedRows[0].Cells[6].Value.ToString();
            
            // Approve button
            String status = studentGrid.SelectedRows[0].Cells[8].Value.ToString();
            if (status == "Pending")
            {
                studentApproveButton.Text = "Approve";
                studentApproveButton.Enabled = true;
            }
            else if(status == "Approved")
            {
                studentApproveButton.Text = "Approved";
                studentApproveButton.Enabled = false;
            }
        }

        private void studentUpdateButton_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand command = new SqlCommand("update UserTable set UserName = @UserName, Email = @Email, Gender = @Gender, Age = @Age, Course = @Course where UserID = @UserID", connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@UserName", userNameBox.Text);
                command.Parameters.AddWithValue("@Email", userEmailBox.Text);
                if (maleButton.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Male");
                }
                else if (femaleButton.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Female");
                }
                command.Parameters.AddWithValue("@Age", userAgeBox.Text);
                command.Parameters.AddWithValue("@Course", userCourseBox.Text);
                command.Parameters.AddWithValue("@UserID", this.UserID);
                
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                UpdateStudentIntoStudentTable();
                LoadStudentDataIntoGrid();
                Reset();
            }
            catch (Exception exception)
            {
                connection.Close();
                MessageBox.Show("Please select a student!");
            }
        }

        private void UpdateStudentIntoStudentTable()
        {
            SqlCommand command = new SqlCommand("update Student set UserName = @UserName, Email = @Email, Gender = @Gender, Age = @Age, Course = @Course where UserID = @UserID", connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@UserName", userNameBox.Text);
            command.Parameters.AddWithValue("@Email", userEmailBox.Text);
            if (maleButton.Checked)
            {
                command.Parameters.AddWithValue("@Gender", "Male");
            }
            else if (femaleButton.Checked)
            {
                command.Parameters.AddWithValue("@Gender", "Female");
            }
            command.Parameters.AddWithValue("@Age", userAgeBox.Text);
            command.Parameters.AddWithValue("@Course", userCourseBox.Text);
            command.Parameters.AddWithValue("@UserID", this.UserID);
                
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void studentApproveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update UserTable set Status = @Status where UserID = @UserID", connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Status", "Approved");
                command.Parameters.AddWithValue("@UserID", this.UserID);
            
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                
                ApproveStudentIntoStudentTable();
                
                studentApproveButton.Text = "Approved";
                studentApproveButton.Enabled = false;
                Reset();
                MessageBox.Show("Student has been approved successfully!");
                LoadStudentDataIntoGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please select a student!");
            }
        }

        private void ApproveStudentIntoStudentTable()
        {
            SqlCommand command = new SqlCommand("update Student set Status = @Status where UserID = @UserID", connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Status", "Approved");
            command.Parameters.AddWithValue("@UserID", this.UserID);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void studentGrid_MouseHover_1(object sender, EventArgs e)
        {
            _toolTip = new ToolTip();
            _toolTip.SetToolTip(studentGrid, "Double click on a cell to delete");
        }

        private void studentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from UserTable where UserID = @UserID", connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@UserID", this.UserID);
                
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            DeleteStudentFromStudentTable();
            LoadStudentDataIntoGrid();
        }

        private void DeleteStudentFromStudentTable()
        {
            SqlCommand command = new SqlCommand("delete from Student where UserID = @UserID", connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@UserID", this.UserID);
                
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void teacherRegisterButton_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                SqlCommand command = new SqlCommand("insert into UserTable values (@UserID,@UserName,@Email,@Password,@Gender,@Age,@Course,@Classes,@Type,@Status,@Salary)", connection);
                SqlCommand cmd2 = new SqlCommand("select count(ID) from UserTable where Type = 'Teacher'", connection);
                
                connection.Open();
                
                int row_count = Convert.ToInt32(cmd2.ExecuteScalar()) + 1;
                String ID = row_count.ToString();
                
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@UserID","20-" + ID + "-2");
                command.Parameters.AddWithValue("@UserName", teacherNameBox.Text);
                command.Parameters.AddWithValue("@Email", teacherEmailBox.Text);
                command.Parameters.AddWithValue("@Password", teacherPasswordBox.Text);
                if (teacherMaleButton.Checked)
                {
                    teacherGender = "Male";
                }
                else if(teacherFemaleButton.Checked)
                {
                    teacherGender = "Female";
                }
                command.Parameters.AddWithValue("@Gender", teacherGender);
                command.Parameters.AddWithValue("@Age", teacherAgeBox.Text);
                command.Parameters.AddWithValue("@Course", "");
                command.Parameters.AddWithValue("@Classes", "");
                command.Parameters.AddWithValue("@Type", "Teacher");
                command.Parameters.AddWithValue("@Status", "Approved");
                command.Parameters.AddWithValue("@Salary", teacherSalaryBox.Text);
                
                command.ExecuteNonQuery();
                connection.Close();
                
                DataInsertIntoTeacherTable();
                Reset();
                MessageBox.Show("Registration completed successfully!");
                LoadTeacherDataIntoGrid();
            }
            else
            {
                MessageBox.Show("The fields can not be empty!");
            }
        }

        private void DataInsertIntoTeacherTable()
        {
            SqlCommand command = new SqlCommand("insert into Teacher values (@UserID,@UserName,@Email,@Gender,@Age,@Status,@Salary)", connection);
            SqlCommand cmd2 = new SqlCommand("select count(ID) from Teacher", connection);
                
            connection.Open();
                
            int row_count = Convert.ToInt32(cmd2.ExecuteScalar()) + 1;
            String ID = row_count.ToString();
                
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@UserID","20-" + ID + "-2");
            command.Parameters.AddWithValue("@UserName", teacherNameBox.Text);
            command.Parameters.AddWithValue("@Email", teacherEmailBox.Text);
            if (teacherMaleButton.Checked)
            {
                teacherGender = "Male";
            }
            else if(teacherFemaleButton.Checked)
            {
                teacherGender = "Female";
            }
            command.Parameters.AddWithValue("@Gender", teacherGender);
            command.Parameters.AddWithValue("@Age", teacherAgeBox.Text);
            command.Parameters.AddWithValue("@Status", "Approved");
            command.Parameters.AddWithValue("@Salary", teacherSalaryBox.Text);

                
            command.ExecuteNonQuery();
            connection.Close();
        }
        
        private bool Valid()
        {
            if (teacherNameBox.Text != "" && teacherEmailBox.Text != "" && teacherPasswordBox.Text != "" && teacherGender != "" &&
                teacherAgeBox.Text != "" && teacherSalaryBox.Text != "")
            {
                return true;
            }

            return false;
        }

        private void teacherUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update UserTable set UserName = @UserName, Email = @Email, Gender = @Gender, Age = @Age, Salary = @Salary where UserID = @UserID", connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@UserName", teacherNameBox.Text);
                command.Parameters.AddWithValue("@Email", teacherEmailBox.Text);
                if (teacherMaleButton.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Male");
                }
                else if (teacherFemaleButton.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Female");
                }
                command.Parameters.AddWithValue("@Age", teacherAgeBox.Text);
                command.Parameters.AddWithValue("@Salary", teacherSalaryBox.Text);
                command.Parameters.AddWithValue("@UserID", this.teacherID);
                
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                UpdateDataFromTeacherTable();
                LoadTeacherDataIntoGrid();
                Reset();
            }
            catch (Exception exception)
            {
                connection.Close();
                MessageBox.Show("Please select a student!");
            }
        }

        private void UpdateDataFromTeacherTable()
        {
            SqlCommand command = new SqlCommand("update Teacher set UserName = @UserName, Email = @Email, Gender = @Gender, Age = @Age, Salary = @Salary where UserID = @UserID", connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@UserName", teacherNameBox.Text);
            command.Parameters.AddWithValue("@Email", teacherEmailBox.Text);
            if (teacherMaleButton.Checked)
            {
                command.Parameters.AddWithValue("@Gender", "Male");
            }
            else if (teacherFemaleButton.Checked)
            {
                command.Parameters.AddWithValue("@Gender", "Female");
            }
            command.Parameters.AddWithValue("@Age", teacherAgeBox.Text);
            command.Parameters.AddWithValue("@Salary", teacherSalaryBox.Text);
            command.Parameters.AddWithValue("@UserID", this.teacherID);
                
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void teacherGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherID = teacherGrid.SelectedRows[0].Cells[1].Value.ToString();
            teacherNameBox.Text = teacherGrid.SelectedRows[0].Cells[2].Value.ToString();
            teacherEmailBox.Text = teacherGrid.SelectedRows[0].Cells[3].Value.ToString();
            // For gender
            String gender = teacherGrid.SelectedRows[0].Cells[4].Value.ToString();
            if (gender == "Male")
            {
                teacherMaleButton.Checked = true;
            }
            else
            {
                teacherFemaleButton.Checked = true;
            }
            teacherAgeBox.Text = teacherGrid.SelectedRows[0].Cells[5].Value.ToString();
            teacherSalaryBox.Text = teacherGrid.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void teacherGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from UserTable where UserID = @UserID", connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@UserID", this.teacherID);
                
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            DeleteDataFromTeacherTable();
            LoadTeacherDataIntoGrid();
        }

        private void DeleteDataFromTeacherTable()
        {
            SqlCommand command = new SqlCommand("delete from Teacher where UserID = @UserID", connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@UserID", this.teacherID);
                
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        
        private void OpenPasswordResetForm()
        {
            Application.Run(new PasswordResetForm());
        }

        private void adminResetPasswordButton_Click(object sender, EventArgs e)
        {
            _thread = new Thread(OpenPasswordResetForm);
            _thread.SetApartmentState(ApartmentState.MTA);
            _thread.Start();
        }

        private void studentSearchBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = studentGrid.DataSource;
            bs.Filter = "UserName" + " like '%" + studentSearchBox.Text + "%'";
            studentGrid.DataSource = bs;
        }

        private void teacherSearchBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = teacherGrid.DataSource;
            bs.Filter = "UserName" + " like '%" + teacherSearchBox.Text + "%'";
            teacherGrid.DataSource = bs;
        }

        private void Reset()
        {
            userNameBox.Clear();
            userEmailBox.Clear();
            userEmailBox.Clear();
            userAgeBox.Clear();
            maleButton.Checked = false;
            femaleButton.Checked = false;
            userCourseBox.Text = "";
            
            teacherNameBox.Clear();
            teacherEmailBox.Clear();
            teacherPasswordBox.Clear();
            teacherMaleButton.Checked = false;
            teacherFemaleButton.Checked = false;
            teacherSalaryBox.Clear();
            teacherAgeBox.Clear();
        }

        private void OpenAssignClassForm()
        {
            Application.Run(new AssignClass());
        }

        private void assignClassButton_Click(object sender, EventArgs e)
        {
            if (studentID != "")
            {
                _thread = new Thread(OpenAssignClassForm);
                _thread.SetApartmentState(ApartmentState.MTA);
                _thread.Start();
            }
            else
            {
                MessageBox.Show("At first select a student");
            }
        }

        private void LoadTeachersName()
        {
            try
            {
                teacherName = new string[teacherGrid.Rows.Count];
            
                for (int i = 0; i < teacherGrid.Rows.Count-1; i++)
                {
                    teacherName[i] = teacherGrid.Rows[i].Cells[2].Value.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}