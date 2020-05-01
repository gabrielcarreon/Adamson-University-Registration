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
    public partial class attendanceForm : Form
    {
        string source = @"Data Source = DESKTOP-V2BGUCQ\SQLEXPRESS; Initial Catalog = Event Registration; Integrated Security = True";
        public attendanceForm()
        {
            InitializeComponent();
        }

        private void checkDate_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);

            studentAttendace.DataSource = null;
            studentAttendace.Rows.Clear();

            //check event date
            DateTime dateEnd = checkDate.Value;
            string dateEndOnly = dateEnd.ToString("yyyy-MM-dd");
            connection.Open();
            SqlCommand getDate = new SqlCommand("Select EventName from [Events] where Date ='" + dateEndOnly + "'", connection);
            SqlDataReader readDate = getDate.ExecuteReader();
            if (readDate.Read())
            {
                string currentEvent = Convert.ToString(readDate.GetValue(0));
                eventlabel.Text = currentEvent;
                connection.Close();
                //fills table with student data
                DataTable studentInfo = new DataTable();
                SqlCommand displayData = new SqlCommand("Select StudentID, StudentName,  Attendance,  TimeIn, Course, Block from [" + currentEvent + "]", connection);
                connection.Open();
                SqlDataAdapter getStudentInfo = new SqlDataAdapter(displayData);
                getStudentInfo.Fill(studentInfo);
                studentAttendace.DataSource = studentInfo;
                studentAttendace.Columns[0].Name = "StudentID#";
                studentAttendace.Columns[1].Name = "Name";
                studentAttendace.Columns[2].Name = "Block";
                studentAttendace.Columns[3].Name = "Course";
                studentAttendace.Columns[3].Name = "Attendance";
                studentAttendace.Columns[3].Name = "TimeIn";

                connection.Close();
            }
            else
            {
                eventlabel.Text = " ";
            }

        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);

            //check event date
            DateTime dateEnd = checkDate.Value;
            string dateEndOnly = dateEnd.ToString("yyyy-MM-dd");
            connection.Open();
            SqlCommand getDate = new SqlCommand("Select EventName from dbo.Events where Date = '" + dateEndOnly + "'",connection);
            SqlDataReader readDate = getDate.ExecuteReader();
            if (readDate.Read())
            {
                string currentEvent = Convert.ToString(readDate.GetValue(0));
                eventlabel.Text = currentEvent;
                connection.Close();
                //fills table with student data
                DataTable studentInfo = new DataTable();
                SqlCommand displayData = new SqlCommand("Select StudentID, StudentName,  Attendance,  TimeIn, Course, Block from [" + currentEvent + "]", connection);
                connection.Open();
                SqlDataAdapter getStudentInfo = new SqlDataAdapter(displayData);
                getStudentInfo.Fill(studentInfo);
                studentAttendace.DataSource = studentInfo;
                studentAttendace.Columns[0].Name = "StudentID#";
                studentAttendace.Columns[1].Name = "Name";
                studentAttendace.Columns[2].Name = "Block";
                studentAttendace.Columns[3].Name = "Course";
                studentAttendace.Columns[3].Name = "Attendance";
                studentAttendace.Columns[3].Name = "TimeIn";

                connection.Close();


            }
            searchComboBox.Text = "StudentID";
          
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            (studentAttendace.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchComboBox.Text + " LIKE '{0}%' OR " + searchComboBox.Text +  " LIKE '% {0}%'", searchBox.Text);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI UI = new UI();
            UI.Show();
        }
    }
}
