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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {
            
            loadtimer.Start();
            
        }

        private void loadtimer_Tick(object sender, EventArgs e)
        {
            loadingbar.Increment(3);
            if(loadingbar.Value == 100)
            {
                UI UI = new UI();
                UI.Show();
                loadtimer.Stop();
                this.Hide();
            }
        }
    }
}
