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
 
    public partial class mainContainer : Form
    {
        // Form Initialization
        public static string filepath = "";
        public static bool algo = false; // false : BFS, true : DFS
        public static string chosenAccount = "";
        public static string exploreFriendsWith = "";

        public mainContainer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*
            GENERAL 
        */
        // Exit Button
        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
           BROWSE FILE SECTION
        */
        // "Graph File" Label
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // Button
        private void button1_Click(object sender, EventArgs e)
        {
            // ---- INPUT HANDLER ----
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Graph File";
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Path : ofd.FileName
                // Name : ofd.SafeFileName
                // filename is the Label name inside the filename container
                filename.Text = ofd.SafeFileName;
                filepath = ofd.FileName;
            }

            // ---- SHOWING DATA ----
            // > ---- Dropdown Explore Friends ---- <
            // Display Accounts
            List<String> explore = new List<String>();

            // Add nodes
            explore.Add("Pokkat");
            explore.Add("Hemobol");

            // Add to dropdown
            dropdownExploreFriends.DataSource = explore;

            // > ---- Dropdown Account ---- <
            // Display Accounts
            List<String> account = new List<String>();

            // Add nodes
            account.Add("Cikibol");
            account.Add("Koala");

            // Add to dropdown
            dropdownAccount.DataSource = account;

            // > ---- Display Graph ---- <
            // Create a graph object
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            // Add edges
            graph.AddEdge("Cikibol", "Pokkat");
            graph.AddEdge("Koala", "Pokkat");

            // Bind with viewer
            fileGraphViewer.Graph = graph;

        }

        /*
            DESIGN ELEMENTS
         */
        // Filename container
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        // File Graph Viewer Box
        private void fileGraphViewer_Load(object sender, EventArgs e)
        {

        }

        // "Algorithm" Label
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        // "Choose" Label
        private void label1_Click_3(object sender, EventArgs e)
        {

        }
        // "Account" Label
        private void label2_Click(object sender, EventArgs e)
        {

        }
        // "Explore" Label
        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Social Tab Logo
        private void socialTabHeader_Click(object sender, EventArgs e)
        {

        }

        /*
            RADIO BUTTONS
         */
        // BFS Radio
        private void radioBFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        // DFS Radio
        private void radioDFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Radio Container
        private void radioButtonContainer_Paint(object sender, PaintEventArgs e)
        {

        }


        /*
            SUBMIT BUTTON
        */

        private void submit_Click(object sender, EventArgs e)
        {
            // ---- INPUT HANDLER ----
            // filepath defined on ofd section
            // algo => false : BFS, true : DFS
            if (radioBFS.Checked)
            {
                algo = false;
            }
            if (radioDFS.Checked)
            {
                algo = true;
            }
            
            // get chosen account
            if (dropdownAccount.SelectedValue != null)
            {
                chosenAccount = dropdownAccount.SelectedValue.ToString();
            }

            // get friend to explore
            if (dropdownExploreFriends.SelectedValue != null)
            {
                exploreFriendsWith = dropdownExploreFriends.SelectedValue.ToString();
            }

            // Requirement Handler
            if (filepath == "")
            {
                // File not loaded
                MessageBox.Show("You have not selected any files yet.");
            } 
            else if (dropdownAccount.SelectedValue == null && dropdownExploreFriends.SelectedValue == null)
            {
                // Radio button not selected
                MessageBox.Show("You have not selected any algorithm yet.");
            }
            else
            {
                MessageBox.Show(filepath);
                MessageBox.Show(chosenAccount);
                MessageBox.Show(exploreFriendsWith);

                // ---- SHOWING DATA ----

            }
        }

        /*
            DROPDOWN SECTION
            Dropdown handled on Browse button as it 
            automatically shows after file is loaded
        */
        // Choose Account
        private void dropdownAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        // Explore Friends
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        /*
            NAVIGATION
         */
        // Go to Explore Friends
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form exploreFriends = new Form();
            exploreFriends.Location = this.Location;
            exploreFriends.StartPosition = FormStartPosition.Manual;
            exploreFriends.FormClosing += delegate { this.Show(); };
            exploreFriends.Show();
            this.Hide();
        }

        // Go to Friend Rec
        private void toFriendRec_Click(object sender, EventArgs e)
        {

        }
    }

}
