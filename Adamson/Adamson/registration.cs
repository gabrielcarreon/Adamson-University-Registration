using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Adamson
{
    public partial class registration : Form
    {
        string source = @"Data Source = DESKTOP-V2BGUCQ\SQLEXPRESS; Initial Catalog = Event Registration; Integrated Security = True";
        public registration()
        {
            InitializeComponent();  
        }


        private void registration_Load(object sender, EventArgs e)
        {
            timeTimer.Start();

        }

        private void studentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SqlConnection connection = new SqlConnection(source);
                //checks for student ID on the database
                connection.Open();
                student = studentIDTxt.Text;
                string studentID = "Select StudentID# from dbo.StudentData where StudentID# = '" + studentIDTxt.Text + "'";
                SqlCommand getStudentID = new SqlCommand(studentID, connection);
                SqlDataAdapter studentAdapter = new SqlDataAdapter(getStudentID);
                DataTable studentTable = new DataTable();
                try
                {
                    studentAdapter.Fill(studentTable);
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect Input");
                }
                connection.Close();
                if (studentTable.Rows.Count > 0)
                {

                    //shows registration form
                    registrationLoading registration = new registrationLoading();
                    registration.Show();
                    //updates attendance in the database
                    DateTime TimeIn = DateTime.Now;
                    string timeOnly = DateTime.Now.ToShortTimeString();
                    connection.Open();
                    SqlCommand updateTimeIn = new SqlCommand("Update [" + UI.currentEvent + "] set TimeIn = '"+ timeOnly  +"' where StudentID = " + studentIDTxt.Text, connection);
                    updateTimeIn.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    SqlCommand updateAttendance = new SqlCommand("Update [" + UI.currentEvent + "] set Attendance = 'Present' where StudentID = " + studentIDTxt.Text, connection);
                    updateAttendance.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("No Student ID # " + studentIDTxt.Text);
                }
                studentIDTxt.Clear();
                
                
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string dateOnly = time.ToString("MM-dd-yyyy hh:mm tt");
            string timeOnly = time.ToString(" hh:mm tt");
            string dateAndTimeNow = Convert.ToString(dateOnly + timeOnly);
            string dateEnd = Convert.ToString(UI.dateAndTimeEnd);
            hourLbl.Text = time.ToString("hh");
            minLbl.Text = time.ToString("mm");
            AMorPMLbl.Text = time.ToString("tt");
            secondLbl.Text = time.ToString("ss");
            if(dateOnly == dateEnd)
            {
                this.Hide();
                UI UI = new UI();
                UI.Show();
                //updates absences in database
                SqlConnection connection = new SqlConnection(source);
                connection.Open();
                SqlCommand updateAttendance = new SqlCommand("Update [" + UI.currentEvent + "] set Attendance = 'Absent' where Attendance IS NULL", connection);
                updateAttendance.ExecuteNonQuery();
                timeTimer.Stop();
                connection.Close();
            }
        }

        //global variables
        public static string student;

        private void End_Click(object sender, EventArgs e)
        {

            this.Hide();
            UI UI = new UI();
            UI.Show();
            //updates absences in database
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand updateAttendance = new SqlCommand("Update [" + UI.currentEvent + "] set Attendance = 'Absent' where Attendance IS NULL", connection);
            updateAttendance.ExecuteNonQuery();
            timeTimer.Stop();
            connection.Close();
        }
    }
}
