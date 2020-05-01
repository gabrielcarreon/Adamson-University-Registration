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
    public partial class moderators : Form
    {
        int timerTick;
        string source = @"Data Source = DESKTOP-V2BGUCQ\SQLEXPRESS; Initial Catalog = Event Registration; Integrated Security = True";
        public moderators()
        {
            InitializeComponent();
        }

        private void moderators_Load(object sender, EventArgs e)
        {
            //displays data from table to combo box
            SqlConnection connection = new SqlConnection(source);
            DataSet data = new DataSet();
            try
            {
                connection.Open();
                SqlCommand mods = new SqlCommand("Select UserID,Name from dbo.Admin", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = mods;
                dataAdapter.Fill(data);
                editors.DisplayMember = "Name";
                editors.ValueMember = "UserID";
                editors.DataSource = data.Tables[0];
            }
            catch
            {

            }
            connection.Close();

            connection.Open();
            SqlCommand permission = new SqlCommand("Select Permission from dbo.Admin where Name = '" + editors.Text + "'", connection);
            SqlDataReader readPermission = permission.ExecuteReader();
            if (readPermission.Read())
            {
                string permissionType = Convert.ToString(readPermission.GetValue(0));
                if (permissionType == "Admin")
                {
                    changePermission.Text = "Change to Moderator";
                }
                else
                {
                    changePermission.Text = "Change to Admin";
                }
            }
            connection.Close();
            permissionCombo.Text = "Moderator";
        }

        private void editors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand permission = new SqlCommand("Select Permission from dbo.Admin where Name = '" + editors.Text + "'",connection);
            SqlDataReader readPermission = permission.ExecuteReader();
            if(readPermission.Read())
            {
                string permissionType = Convert.ToString(readPermission.GetValue(0));
                if(permissionType == "Admin")
                {
                    changePermission.Text = "Change to Moderator";
                }
                else
                {
                    changePermission.Text = "Change to Admin";
                }
            }
            connection.Close();
        }

        private void changePermission_Click(object sender, EventArgs e)
        {
            //checks the permission of active text in combo box
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand permission = new SqlCommand("Select Permission from dbo.Admin where Name = '" + editors.Text + "'", connection);
            SqlDataReader readPermission = permission.ExecuteReader();
            if (readPermission.Read())
            {
                string permissionType = Convert.ToString(readPermission.GetValue(0));
                connection.Close();
                if (permissionType == "Admin")
                {
                    connection.Close();
                    changePermission.Text = "Change to Admin";

                    connection.Open();
                    SqlCommand editPermission = new SqlCommand("Update dbo.Admin set Permission = 'Moderator' where Name = '" + editors.Text + "'", connection);
                    editPermission.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    changePermission.Text = "Change to Moderator";
                    connection.Open();
                    SqlCommand editPermission = new SqlCommand("Update dbo.Admin set Permission = 'Admin' where Name = '" + editors.Text + "'", connection);
                    editPermission.ExecuteNonQuery();
                    connection.Close();
                }
            }
            connection.Close();
        }

        private void removeMod_Click(object sender, EventArgs e)
        {
            //deletes data from table
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand permission = new SqlCommand("Delete from dbo.Admin where Name = '" + editors.Text + "'", connection);
            permission.ExecuteNonQuery();
            connection.Close();
            updateTick.Start();
        }

        private void updateTick_Tick(object sender, EventArgs e)
        {
            //updates the form
            timerTick++;
            SqlConnection connection = new SqlConnection(source);
            DataSet data = new DataSet();
            try
            {
                connection.Open();
                SqlCommand mods = new SqlCommand("Select UserID,Name from dbo.Admin", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = mods;
                dataAdapter.Fill(data);
                editors.DisplayMember = "Name";
                editors.ValueMember = "UserID";
                editors.DataSource = data.Tables[0];
            }
            catch
            {

            }
            connection.Close();
            if(timerTick == 2)
            {
                updateTick.Stop();
                timerTick = 0;
            }
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source); 
            connection.Open();
            string insertIntoEvents = "Insert into dbo.Admin (Permission, UserID, Password, Name) " + "Values(@Permission, @UserID, @Password, @Name)";
            using (SqlCommand insertEvents = new SqlCommand(insertIntoEvents, connection))
            {
                insertEvents.Parameters.AddWithValue("@Permission", permissionCombo.Text);
                insertEvents.Parameters.AddWithValue("@UserID", userIDTxt.Text);
                insertEvents.Parameters.AddWithValue("@Password", passwordTxt.Text);
                insertEvents.Parameters.AddWithValue("@Name", nameTxt.Text);
                try
                {
                    int insert = insertEvents.ExecuteNonQuery();
                    MessageBox.Show("Successfully added a new " + permissionCombo.Text);
                    connection.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Enter other User ID.");
                    connection.Close();
                }
                connection.Close();
            }
            userIDTxt.Clear();
            passwordTxt.Clear();
            nameTxt.Clear();
            updateTick.Start();
        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
