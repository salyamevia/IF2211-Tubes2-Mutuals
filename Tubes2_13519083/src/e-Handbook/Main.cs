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
        public static Functions logicFunctions = new Functions();

        public mainContainer()
        {
            InitializeComponent();
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
            // > ---- Read Graph File ---- <
            logicFunctions.BacaFile(filepath);

            // Get Nodes List
            List<String> explore = new List<String>();
            List<String> friend = new List<String>();
            foreach (var map in logicFunctions.getGraf())
            {
                explore.Add(map.Key);
                friend.Add(map.Key);
            }

            // > ---- Dropdown Explore Friends ---- <
            dropdownExploreFriends.DataSource = explore;

            // > ---- Dropdown Account ---- <
            dropdownAccount.DataSource = friend;

            // > ---- Display Graph ---- <
            // Create a graph object
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            // Add edges
            foreach(var map in logicFunctions.getGraf())
            {
                foreach (var vals in map.Value)
                {
                    graph.AddEdge(map.Key, vals);
                }
            }

            //Change shape to circle
            foreach (var map in logicFunctions.getGraf())
            {
                graph.FindNode(map.Key).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            }

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
                MessageBox.Show("Data submitted!");

                // ---- SHOWING DATA ----
                // > ---- Friend Recommendation ---- <
                // Show Account Name
                friendRec.accountName = chosenAccount.ToUpper();

                // Get Result
                Dictionary<String, List<String>> friendRecResult =
                    logicFunctions.friendRecommendation(chosenAccount.ToString());

                // Init Label
                String friendList = "";

                foreach (var map in friendRecResult)
                {
                    // Add Name
                    friendList += "\u25A0 " + map.Key + "\n";
                    
                    // Add Mutuals
                    friendList += map.Value.Count.ToString() + " Mutual Friends:\n";
                    foreach (var m in map.Value)
                    {
                        friendList += "- " + m.ToString() + "\n";
                    }

                    // Add linebreak
                    friendList += "\n";

                }
                // Add to Friend List
                friendRec.friendListCatcher = friendList;

                // > ---- Explore Friends ---- <
                // Get Result
                List<string> result = logicFunctions.exploreFriends(chosenAccount, exploreFriendsWith, algo);

                // Check if error
                if (result.Count == 1)
                {
                    exploreFriend.errorDialogCatcher = result[0];
                } else
                {
                    if (algo) { 
                        exploreFriend.algoNameCatcher = ": DFS"; 
                    } 
                    else { 
                        exploreFriend.algoNameCatcher = ": BFS"; 
                    }
                    Tuple<String, List<String>> data = new Tuple<String, List<String>>(filepath, result);
                    exploreFriend.nodesHandler = data;
                }

            }
            // Change state
            submitted = true;
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
