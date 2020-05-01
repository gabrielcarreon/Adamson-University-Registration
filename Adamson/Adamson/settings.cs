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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        private void darkModePic_Click(object sender, EventArgs e)
        {
            toggleSwitchBtn.Image = Properties.Resources.toggleswitchdark;
            mode = "darkmode";
            this.BackgroundImage = Properties.Resources.darkmode;
            darkModePic.Image = Properties.Resources.darkmodelogo2;
            lightModePic.Image = Properties.Resources.lightmodelogo2;
            
        }

        private void lightModePic_Click(object sender, EventArgs e)
        {
            toggleSwitchBtn.Image = Properties.Resources.toggleswitchlight;
            mode = "lightmode";
            this.BackgroundImage = null;
            lightModePic.Image = Properties.Resources.lightmodelogo;
            darkModePic.Image = Properties.Resources.darkmodelogo;
        }

        public static string mode = "";

        private void saveBtn_Click(object sender, EventArgs e)
        {
            UI ui = new UI();
            this.Hide();
            ui.Show();

        }
    }
}
