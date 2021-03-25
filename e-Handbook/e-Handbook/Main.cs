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
        private static Boolean submitted = false;

        public static FriendRecommendation friendRec = new FriendRecommendation();
        public static ExploreFriends exploreFriend = new ExploreFriends();

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

        // "Graph File" Label
        private void label1_Click_1(object sender, EventArgs e)
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
            ======================================================================================
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
        // Browse Button
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
                // ---- SHOWING DATA ----
                // > ---- Friend Recommendation ---- <
                // Show Account Name
                friendRec.accountName = chosenAccount.ToUpper();

                // Show Friend List
                List<String> friends = new List<String>();
                List<String> mutuals = new List<string>();
                friends.Add("Hemoball");
                friends.Add("Pokatt");
                mutuals.Add("a");
                mutuals.Add("b");

                // Make Friend List Container
                TableLayoutPanel friendListContainer = new TableLayoutPanel();
                friendListContainer.Location = new System.Drawing.Point(12, 140);
                friendListContainer.Size = new System.Drawing.Size(652, 277);
                friendListContainer.ColumnCount = 1;
                friendListContainer.RowCount = friends.Count;

                int rowCount = 0;
                foreach (var item in friends)
                {
                    // Make Container
                    TableLayoutPanel container = new TableLayoutPanel();
                    container.Size = new Size(325, 155);
                    container.AutoSize = true;
                    container.ColumnCount = 1;
                    container.RowCount = 2;

                    // Add Name
                    Label name = new Label();
                    name.Text = "\u25A0 " + item.ToString();
                    name.ForeColor = Color.FromArgb(203, 103, 253);
                    name.Font = new Font("Days One", 13);
                    name.AutoSize = true;

                    // Add Mutuals
                    Label mutual = new Label();
                    mutual.Text = mutuals.Count.ToString() + " Mutual Friends:\n";
                    foreach (var m in mutuals)
                    {
                        mutual.Text += "- " + m.ToString() + "\n";
                    }
                    mutual.ForeColor = Color.FromArgb(203, 103, 253);
                    mutual.Font = new Font("Calibri", 13);
                    mutual.AutoSize = true;

                    // Add to Container
                    container.Controls.Add(name, 0, 0);
                    container.Controls.Add(mutual, 0, 1);

                    // Add to Friend Rec Container
                    friendListContainer.Controls.Add(container, 0, rowCount);
                    rowCount++;

                }
                // Add to Friend List
                friendRec.friendListContainerCatcher = friendListContainer;

                // Change state
                submitted = true;

                // > ---- Explore Friends ---- <
            }
        }

        /*
            NAVIGATION
         */
        // Go to Explore Friends
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (filepath == "")
            {
                MessageBox.Show("You have not selected any files yet.");
            } else if (!submitted)
            {
                MessageBox.Show("You have not submitted the files yet.");
            }
            else
            {
                this.Hide();
                exploreFriend.ShowDialog();
                this.Show();
            }
        }

        // Go to Friend Rec
        private void toFriendRec_Click(object sender, EventArgs e)
        {
            if (filepath == "")
            {
                MessageBox.Show("You have not selected any files yet.");
            }
            else if (!submitted)
            {
                MessageBox.Show("You have not submitted the files yet.");
            }
            else
            {
                this.Hide();
                friendRec.ShowDialog();
                this.Show();
            }
        }


    }

}
