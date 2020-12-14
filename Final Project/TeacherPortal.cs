using System;
using System.Threading;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class TeacherPortal : Form
    {
        private Thread _thread;
        
        public TeacherPortal()
        {
            InitializeComponent();
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
        
        private void LoadData()
        {
            teacherIdLabel.Text = Login.UserID;
            teacherNameLabel.Text = Login.UserName;
            teacherEmaillabel.Text = Login.Email;
            teacherGenderLabel.Text = Login.Gender;
            teacherAgeLabel.Text = Login.Age;
            teacherSalaryLabel.Text = Login.Salary;
        }

        private void TeacherPortal_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void teacherResetPasswordButton_Click(object sender, EventArgs e)
        {
            _thread = new Thread(OpenPasswordResetForm);
            _thread.SetApartmentState(ApartmentState.MTA);
            _thread.Start();
        }
    }
}