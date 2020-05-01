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
    public partial class UI : Form
    {
        string source = @"Data Source = DESKTOP-V2BGUCQ\SQLEXPRESS; Initial Catalog = Event Registration; Integrated Security = True";
        public UI()
        {
            InitializeComponent();
            adminbtn.MouseEnter += new EventHandler(adminbtn_MouseEnter);
            adminbtn.MouseLeave += new EventHandler(adminbtn_MouseLeave);

            registrationbtn.MouseEnter += new EventHandler(registrationbtn_MouseEnter);
            registrationbtn.MouseLeave += new EventHandler(registrationbtn_MouseLeave);
           
        }

        private void UI_Load(object sender, EventArgs e)
        {
            adminPanel.Hide();
            regPanel.Hide();
            loggedPanel.Hide();
            startComboBox.Text=("AM");
            endComboBox.Text = ("PM");
            timeTimer.Start();
            SqlConnection connection = new SqlConnection(source);
            connection.Close();

            if (string.IsNullOrWhiteSpace(eventNameTxtBox.Text))
            {
                createEvent.Enabled = false;
            }
            else
            {

            }
        }

        void adminbtn_MouseEnter(object sender, EventArgs e)
        {
            adminbtn.Image = Properties.Resources.adminbtnpoint;
            adminPanel.Show();
            regPanel.Hide();
        }
        void adminbtn_MouseLeave(object sender, EventArgs e)
        {
            adminbtn.Image = Properties.Resources.adminbtn;
        }
        void registrationbtn_MouseEnter(object sender, EventArgs e)
        {
            registrationbtn.Image = Properties.Resources.registrationpoint;
            regPanel.Show();
            adminPanel.Hide();
        }
        void registrationbtn_MouseLeave(object sender, EventArgs e)
        {
            registrationbtn.Image = Properties.Resources.registration;
            
        }

        private void registrationbtn_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            this.Hide();
            registration.Show();
        }
        private void eventName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SqlConnection connection = new SqlConnection(source);
                connection.Open();
                string login = "Select UserID, Password from dbo.Admin where UserID = '" + userIDTxtBox.Text + "' and Password = '" + passwordTxtBox.Text + "'";
                SqlCommand tryLog = new SqlCommand(login, connection);
                SqlDataAdapter adapterLog = new SqlDataAdapter(tryLog);
                DataTable userTable = new DataTable();
                try
                {
                    adapterLog.Fill(userTable);
                }
                catch(Exception)
                {
                    MessageBox.Show("   Incorrect User ID/ Password");
                }
                if(userTable.Rows.Count > 0)
                {
                    MessageBox.Show("    Log In Successful!");
                    adminPanel.Hide();
                    loggedPanel.Show();
                    string selectPermission = "Select Permission from dbo.Admin where UserID = '" + userIDTxtBox.Text + "' and Password = '" + passwordTxtBox.Text + "'";
                    SqlCommand checkPermission = new SqlCommand(selectPermission, connection);
                    SqlDataReader permission = checkPermission.ExecuteReader();
                    if(permission.Read())
                    {
                        string permit = Convert.ToString(permission.GetValue(0));
                        if(permit == "Admin")
                        {
                            editMods.Show();
                        }
                        else
                        {
                            editMods.Hide();
                        }

                    }
                    connection.Close();
                    connection.Open();
                    string selectUser = "Select Name from dbo.Admin where UserID = '" + userIDTxtBox.Text + "' and Password = '" + passwordTxtBox.Text + "'";
                    SqlCommand getUser = new SqlCommand(selectUser, connection);
                    SqlDataReader readUser = getUser.ExecuteReader();
                    if (readUser.Read())
                    {

                        creator.Text = (Convert.ToString(readUser.GetValue(0)));
                        creator.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("    Incorrect User ID/ Password");
                }
                connection.Close();
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            UI UI = new UI();
            this.Hide();
            UI.Show();
        }

        private void createEvent_Click(object sender, EventArgs e)
        {
            //sets the time start and end of the event
            string timeStart = " " + eventStartTime.Value + ":" + eventStartMin.Value + ":00 " + startComboBox.Text;
            DateTime timeStartSet = Convert.ToDateTime(timeStart);


            string timeEnd = " " + eventEndHour.Value + ":" + eventEndMin.Value + " " + endComboBox.Text;
            DateTime timeEndSet = Convert.ToDateTime(timeEnd);

            //sets dateEnd
            DateTime dateEnd = datePicker.Value;
            string dateEndOnly = dateEnd.ToString("MM-dd-yyyy");
            string timeEnd2 = " " + eventEndHour.Value + ":" + eventEndMin.Value + " " + endComboBox.Text;
            dateAndTimeEnd = Convert.ToDateTime(dateEndOnly + timeEnd2);
            //set DateStart
            DateTime dateStart = DateTime.Now;
            string dateStartOnly = dateStart.ToString("MM-dd-yyyy");
            string timeStart2 = " " + eventEndHour.Value + ":" + eventEndMin.Value + " " + endComboBox.Text;
            dateAndTimeStart = Convert.ToDateTime(dateStartOnly + timeStart2);
            //checks if time input is valid
            if (dateAndTimeStart > dateAndTimeEnd)
            {
                MessageBox.Show("Invalid event time.");
            }
            else
            {
                SqlConnection connection = new SqlConnection(source);

                //checks if there is an existing table
                string selectTable = "Select * from INFORMATION_SCHEMA.TABLES where table_name = '" + eventNameTxtBox.Text + "'";
                SqlCommand checkTable = new SqlCommand(selectTable, connection);
                connection.Open();
                SqlDataReader readTable = checkTable.ExecuteReader();
                if (readTable.Read())
                {
                    MessageBox.Show(eventNameTxtBox.Text + " already exists.");
                    connection.Close();
                }
                else
                {
                    //if there's no existing table, create new table
                    connection.Close();
                    string eventNameText = Convert.ToString(eventNameTxtBox.Text);
                    connection.Open();
                    string table = @"Create table [" + eventNameTxtBox.Text + "](StudentID varchar(50) primary key, StudentName varchar(50), Course varchar(50), Block varchar(50), Attendance varchar(50),TimeIn time(7),)";
                    currentEvent = eventNameTxtBox.Text;
                    SqlCommand createTable = new SqlCommand(table, connection);
                    try
                    {
                        createTable.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch
                    {
                    }
                    //copy data from StudentInfo to Event
                    connection.Close();
                    connection.Open();
                    SqlCommand copyInfo = new SqlCommand("Insert into [" + eventNameTxtBox.Text + "] (StudentID, StudentName, Course, Block)" + "Select StudentID#, Name, Course, Block from dbo.StudentData", connection);
                    try
                    {
                        copyInfo.ExecuteNonQuery();
                    }
                    catch
                    {

                    }
                    connection.Close();

                    //inserts event info
                    connection.Open();
                    string insertIntoEvents = "Insert into dbo.Events (EventName, TimeStart, TimeEnd, Date) " + "Values(@EventName, @TimeStart, @TimeEnd, @Date)";
                    using (SqlCommand insertEvents = new SqlCommand(insertIntoEvents, connection))
                    {
                        insertEvents.Parameters.AddWithValue("@EventName", eventNameTxtBox.Text);
                        insertEvents.Parameters.AddWithValue("@TimeStart", timeStartSet);
                        insertEvents.Parameters.AddWithValue("@TimeEnd", timeEndSet);
                        insertEvents.Parameters.AddWithValue("@Date", DateTime.Now);

                        int insert = insertEvents.ExecuteNonQuery();
                        connection.Close();
                    }
                    connection.Close();
                    MessageBox.Show("Event successfully created!");
                    this.Hide();
                    registration registration = new registration();
                    registration.Show();

                }
            }
            
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            //updates time
            DateTime time = DateTime.Now;
            hour.Text = time.ToString("hh");
            minute.Text = time.ToString("mm");
            AMorPM.Text = time.ToString("tt");
            second.Text = time.ToString("ss");

            //updated numeric up down values
            DateTime currentTime = DateTime.Now;
            string currentHour = currentTime.ToString("hh");
            string currentMin = currentTime.ToString("mm");
            eventStartTime.Minimum = Convert.ToInt32(currentHour);
            eventStartTime.Maximum = 12;
            eventStartMin.Minimum = Convert.ToInt32(currentMin);
            eventStartMin.Maximum = 59;
            eventEndHour.Maximum = 12;
            eventEndMin.Maximum = 59;

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI UI = new UI();
            UI.Show();
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            if (string.IsNullOrWhiteSpace(changeUserTxt.Text))
            {

            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand updateUser = new SqlCommand("Update dbo.Admin set UserID = '" + changeUserTxt.Text + "' where UserID = '" + userIDTxtBox.Text + "'", connection);
                    updateUser.ExecuteNonQuery();
                    MessageBox.Show("Changed user ID successfully");
                }
                catch(Exception)
                {
                    MessageBox.Show(changeUserTxt.Text + " is taken");
                }
                connection.Close();
            }
           
            if(string.IsNullOrWhiteSpace(changePassTxt.Text))
            {

            }
            else
            {
                connection.Open();
                SqlCommand updatePass = new SqlCommand("Update dbo.Admin set Password = '" + changePassTxt.Text + "' where UserID = '" + userIDTxtBox.Text + "'", connection);
                updatePass.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Changed password successfully");
            }
            
            
        }

        private void editMods_Click(object sender, EventArgs e)
        {
            moderators moderators = new moderators();
            moderators.Show();
        }

        private void attendancePic_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendanceForm database = new attendanceForm();
            database.Show();
        }

        private void eventNameTxtBox_TextChanged(object sender, EventArgs e)
        {

            //disables create event button if creator and event text are empty
            if (string.IsNullOrWhiteSpace(eventNameTxtBox.Text))
            {
                createEvent.Enabled = false;
            }
            else
            {
                createEvent.Enabled = true;
                if (string.IsNullOrWhiteSpace(creator.Text))
                {
                    createEvent.Enabled = false;
                }
                else
                {
                    createEvent.Enabled = true;
                }
            }
        }
        //global variables
        public static string currentEvent;
        public static DateTime timeEndGlobal;
        public static DateTime dateAndTimeEnd;
        public static DateTime dateAndTimeStart;

    }
}
