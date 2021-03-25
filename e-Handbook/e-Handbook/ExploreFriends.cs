using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Handbook
{
    public partial class ExploreFriends : Form
    {
        public ExploreFriends()
        {
            InitializeComponent();
        }

        /*
            DESIGN ELEMENTS
        */
        // "Explore Friends Label
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Exit Application
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Go Back to Home
        private void toHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
