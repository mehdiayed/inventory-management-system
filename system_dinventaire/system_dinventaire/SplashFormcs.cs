using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_dinventaire
{
    public partial class SplashFormcs : Form
    {
        public SplashFormcs()
        {
            InitializeComponent();
        }
        int startpoint;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar.Value = startpoint;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();

            }
        }

        private void SplashFormcs_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
