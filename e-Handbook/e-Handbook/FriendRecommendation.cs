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
    public partial class FriendRecommendation : Form
    {
        public FriendRecommendation()
        {
            InitializeComponent();
        }

        /*
            DESIGN ELEMENTS
         */

        // "Friend Recommendation For" Label
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Chosen Account Name Text Catcher
        public String accountName
        {
            get
            {
                return this.chosenAccount.Text;
            }
            set
            {
                this.chosenAccount.Text = value;
            }
        }

        // Friend List Container Catcher
        public Panel friendListContainerCatcher
        {
            get
            {
                return this.friendListContainer;
            }
            set
            {
                this.friendListContainer.Controls.Add(value);
            }
        }

        /*
            GENERAL
         */

        // Go Back to Home
        private void toHome_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
