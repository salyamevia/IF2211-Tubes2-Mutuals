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
        public static Functions functions = new Functions();

        public ExploreFriends()
        {
            InitializeComponent();
        }
        // Error Dialog Catcher
        public String errorDialogCatcher
        {
            get
            {
                return this.errorDialog.Text;
            }
            set
            {
                this.errorDialog.Text = value;
            }
        }

        // Algoname Catcher
        public String algoNameCatcher
        {
            get
            {
                return this.algoUsed.Text;
            }
            set
            {
                this.algoUsed.Text = value;
            }
        }

        // Nodes Handler
        public Tuple<String, List<String>> nodesHandler
        {
            get
            {
                return new Tuple<String, List<String>>("", new List<String>());
            }
            set
            {
                // Make edge pairs
                List<Tuple<String, String>> resultingEdge = new List<Tuple<String, String>>();
                for (int i = 1; i < value.Item2.Count; i++)
                {
                    Tuple<String, String> temp = new Tuple<String, String>(value.Item2[i - 1], value.Item2[i]);
                    resultingEdge.Add(temp);
                }

                // Init graph
                functions.BacaFile(value.Item1);

                // Create a graph object
                Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                
                // Add resulting edges
                foreach(Tuple<String, String> edge in resultingEdge) {
                    graph.AddEdge(edge.Item1, edge.Item2).Attr.Color = new Microsoft.Msagl.Drawing.Color(230, 226, 98);
                }

                // Add other edges
                foreach (var map in functions.getGraf())
                {
                    foreach (var vals in map.Value)
                    {
                        Tuple<String, String> check = new Tuple<String, String>(map.Key, vals);
                        if (!resultingEdge.Contains(check))
                        {
                            graph.AddEdge(map.Key, vals);
                        }
                    }

                    // Add color to nodes and change shape to circle
                    if (value.Item2.Contains(map.Key)) {
                        graph.FindNode(map.Key).Attr.FillColor = new Microsoft.Msagl.Drawing.Color(203, 103, 253);
                    }
                    graph.FindNode(map.Key).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
                }

                // Bind with viewer
                exploreFriendViewer.Graph = graph;
            }
        }

        // Go Back to Home
        private void toHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
