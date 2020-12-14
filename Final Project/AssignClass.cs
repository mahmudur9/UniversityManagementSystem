using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class AssignClass : Form
    {
        private readonly SqlConnection connection =
            new SqlConnection(@"Data Source=DESKTOP-0TSHBB8\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");

        private readonly string[] courses = {"CS1", "CS2 ", "CS3", "CS4", "CS5", "CS6", "CS7", "CS8", "CS10", "CS11", "CS12", "CS13", "CS14", "CS15", 
            "CS16", "CS17", "EEE1", "EEE2", "EEE3", "EEE4", "EEE5", "EEE6", "EEE7", "EEE8", "EEE9", "EEE10", "EEE11", "EEE12"};
        private readonly string[] sections = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N"};
        private string studentID;
        private string[] teacherName;

        public AssignClass()
        {
            InitializeComponent();
        }

        private void AssignClass_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Courses
            for (var i = 0; i < courses.Length; i++)
            {
                courseOneBox.Items.Add(courses[i]);
                courseTwoBox.Items.Add(courses[i]);
                courseThreeBox.Items.Add(courses[i]);
                courseFourBox.Items.Add(courses[i]);
                courseFiveBox.Items.Add(courses[i]);
                courseSixBox.Items.Add(courses[i]);
            }

            // Sections
            for (var i = 0; i < sections.Length; i++)
            {
                sectionOneBox.Items.Add(sections[i]);
                sectionTwoBox.Items.Add(sections[i]);
                sectionThreeBox.Items.Add(sections[i]);
                sectionFourBox.Items.Add(sections[i]);
                sectionFiveBox.Items.Add(sections[i]);
                sectionSixBox.Items.Add(sections[i]);
            }

            // Teachers
            for (var i = 0; i < AdminPortal.teacherName.Length - 1; i++)
            {
                teacherOneBox.Items.Add(AdminPortal.teacherName[i]);
                teacherTwoBox.Items.Add(AdminPortal.teacherName[i]);
                teacherThreeBox.Items.Add(AdminPortal.teacherName[i]);
                teacherFourBox.Items.Add(AdminPortal.teacherName[i]);
                teacherFiveBox.Items.Add(AdminPortal.teacherName[i]);
                teacherSixBox.Items.Add(AdminPortal.teacherName[i]);
            }
        }

        private void coursesSaveButton_Click(object sender, EventArgs e)
        {
            CourseAssignForTeacherAndStudent();
        }

        private void CourseAssignForTeacherAndStudent()
        {
            studentID = AdminPortal.studentID;

            var command1 = new SqlCommand("select * from Classes where StudentID = @StudentID", connection);

            command1.Parameters.AddWithValue("@StudentID", studentID);

//            SqlDataReader sqlDataReader = command1.ExecuteReader();

            connection.Open();

            var adapt = new SqlDataAdapter(command1);
            var ds = new DataSet();
            adapt.Fill(ds);

            connection.Close();

            var count = ds.Tables[0].Rows.Count;

            if (count != 1)
            {
                if (courseOneBox.Text != "" && courseTwoBox.Text != "" && courseThreeBox.Text != "" &&
                    courseFourBox.Text != "")
                {
                    if (teacherOneBox.Text != "" && courseOneBox.Text != "" && sectionOneBox.Text != "" &&
                        courseTwoBox.Text != "" && teacherTwoBox.Text != "" && sectionTwoBox.Text != "" &&
                        courseThreeBox.Text != "" && teacherThreeBox.Text != "" && sectionThreeBox.Text != "" &&
                        courseFourBox.Text != "" && teacherFourBox.Text != "" && sectionFourBox.Text != "" &&
                        courseFiveBox.Text != "" && teacherFiveBox.Text != "" && sectionFiveBox.Text != "" &&
                        courseSixBox.Text != "" && teacherSixBox.Text != "" && sectionSixBox.Text != "")
                    {
                        var command =
                            new SqlCommand(
                                "insert into Classes values (@Course1,@Course2,@Course3,@Course4,@Course5,@Course6, @StudentID)",
                                connection);

                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Course1 ",
                            courseOneBox.Text + " Teacher: " + teacherOneBox.Text + " Section: " + sectionOneBox.Text);
                        command.Parameters.AddWithValue("@Course2 ",
                            courseTwoBox.Text + " Teacher: " + teacherTwoBox.Text + " Section: " + sectionTwoBox.Text);
                        command.Parameters.AddWithValue("@Course3 ",
                            courseThreeBox.Text + " Teacher: " + teacherThreeBox.Text + " Section: " +
                            sectionThreeBox.Text);
                        command.Parameters.AddWithValue("@Course4 ",
                            courseFourBox.Text + " Teacher: " + teacherFourBox.Text + " Section: " +
                            sectionFourBox.Text);
                        command.Parameters.AddWithValue("@Course5 ",
                            courseFiveBox.Text + " Teacher: " + teacherFiveBox.Text + " Section: " +
                            sectionFiveBox.Text);
                        command.Parameters.AddWithValue("@Course6 ",
                            courseSixBox.Text + " Teacher: " + teacherSixBox.Text + " Section: " + sectionSixBox.Text);
                        command.Parameters.AddWithValue("@StudentID", studentID);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.Close();
                    }
                    else if (teacherOneBox.Text != "" && courseOneBox.Text != "" && sectionOneBox.Text != "" &&
                             courseTwoBox.Text != "" && teacherTwoBox.Text != "" && sectionTwoBox.Text != "" &&
                             courseThreeBox.Text != "" && teacherThreeBox.Text != "" && sectionThreeBox.Text != "" &&
                             courseFourBox.Text != "" && teacherFourBox.Text != "" && sectionFourBox.Text != "" &&
                             courseFiveBox.Text != "" && teacherFiveBox.Text != "" && sectionFiveBox.Text != "")
                    {
                        var command =
                            new SqlCommand(
                                "insert into Classes values (@Course1,@Course2,@Course3,@Course4,@Course5, @Course6, @StudentID)",
                                connection);

                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Course1 ",
                            courseOneBox.Text + " Teacher: " + teacherOneBox.Text + " Section: " + sectionOneBox.Text);
                        command.Parameters.AddWithValue("@Course2 ",
                            courseTwoBox.Text + " Teacher: " + teacherTwoBox.Text + " Section: " + sectionTwoBox.Text);
                        command.Parameters.AddWithValue("@Course3 ",
                            courseThreeBox.Text + " Teacher: " + teacherThreeBox.Text + " Section: " +
                            sectionThreeBox.Text);
                        command.Parameters.AddWithValue("@Course4 ",
                            courseFourBox.Text + " Teacher: " + teacherFourBox.Text + " Section: " +
                            sectionFourBox.Text);
                        command.Parameters.AddWithValue("@Course5 ",
                            courseFiveBox.Text + " Teacher: " + teacherFiveBox.Text + " Section: " +
                            sectionFiveBox.Text);
                        command.Parameters.AddWithValue("@Course6 ", "");
                        command.Parameters.AddWithValue("@StudentID", studentID);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.Close();
                    }
                    else if (teacherOneBox.Text != "" && courseOneBox.Text != "" && sectionOneBox.Text != "" &&
                             courseTwoBox.Text != "" && teacherTwoBox.Text != "" && sectionTwoBox.Text != "" &&
                             courseThreeBox.Text != "" && teacherThreeBox.Text != "" && sectionThreeBox.Text != "" &&
                             courseFourBox.Text != "" && teacherFourBox.Text != "" && sectionFourBox.Text != "")
                    {
                        var command =
                            new SqlCommand(
                                "insert into Classes values (@Course1,@Course2,@Course3,@Course4, @Course5, @Course6, @StudentID)",
                                connection);

                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Course1 ",
                            courseOneBox.Text + " Teacher: " + teacherOneBox.Text + " Section: " + sectionOneBox.Text);
                        command.Parameters.AddWithValue("@Course2 ",
                            courseTwoBox.Text + " Teacher: " + teacherTwoBox.Text + " Section: " + sectionTwoBox.Text);
                        command.Parameters.AddWithValue("@Course3 ",
                            courseThreeBox.Text + " Teacher: " + teacherThreeBox.Text + " Section: " +
                            sectionThreeBox.Text);
                        command.Parameters.AddWithValue("@Course4 ",
                            courseFourBox.Text + " Teacher: " + teacherFourBox.Text + " Section: " +
                            sectionFourBox.Text);
                        command.Parameters.AddWithValue("@Course5 ", "");
                        command.Parameters.AddWithValue("@Course6 ", "");
                        command.Parameters.AddWithValue("@StudentID", studentID);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The particular fields can not be empty!");
                    }
                }
                else
                {
                    MessageBox.Show("You have to select at least four courses!");
                }
            }
            else
            {
                MessageBox.Show("Course already has been assigned of this student!");
            }
        }

        private void CourseAssignFour()
        {
            
        }

        private void CourseAssignFive()
        {
        }

        private void CourseAssignSix()
        {
            
        }

        private void coursesCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}