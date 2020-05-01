using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adamson
{
    public partial class attendanceConfirmation : Form
    {
        int counter;
        public attendanceConfirmation()
        {
            InitializeComponent();
        }

        private void attendanceConfirmation_Load(object sender, EventArgs e)
        {
            string image = "C:\\Users\\Ivan\\Desktop\\COmprog\\Pictures\\" + registration.student + ".jpg";
            try
            {
                studentPic.Image = Image.FromFile(image);
            }
            catch(Exception)
            {
                
            }
            DateTime date = DateTime.Now;
            
            timeIn.Text = date.ToString("h:mm tt");
            confirmTimer.Start();
        }
        private void confirmTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 2)
            {
                this.Hide();
                confirmTimer.Stop();
            }
        }
    }
}
