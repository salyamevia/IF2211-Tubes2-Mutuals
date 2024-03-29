﻿using System;
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
        public String friendListCatcher
        {
            get
            {
                return this.friendList.Text;
            }
            set
            {
                this.friendList.Text = value;
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
