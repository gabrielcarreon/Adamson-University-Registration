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
    public partial class registrationLoading : Form
    {
        public registrationLoading()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void rLoading_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter == 2)
            {
                this.Close();
                attendanceConfirmation attendance = new attendanceConfirmation();
                attendance.Show();
                rLoading.Stop();
            }
        }

        private void registrationLoading_Load(object sender, EventArgs e)
        {
            rLoading.Start();
        }
    }
}
