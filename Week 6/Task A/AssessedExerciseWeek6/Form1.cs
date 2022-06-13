using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssessedExerciseWeek6.Classes;

namespace AssessedExerciseWeek6
{
    public partial class Form1 : Form
    {
        //Create new graph
        int numedges;
        Graph myGraph = new Graph();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            //Call add node on myGraph, passing in value entered in input box
            myGraph.AddNode(Convert.ToInt32(AddNodeTextBox.Text));
            //Display number of nodes
            NodeLabel.Text = "Total number of Nodes: " + myGraph.NumOfNodes().ToString();
            //Refresh list box to show nodes
            FromListSelect();
        }

        public void FromListSelect()
        {
            //Clear list box to prevent double adding items 
            FromListBox.Items.Clear();
            ToListBox.Items.Clear();

            //Create new list of graph nodes called nodes, call nodesList on my graph and fill new list with node values
            LinkedList<GraphNode> nodes = myGraph.nodesList();

            //Create new graph node list, with max size the amount of nodes we have 
            GraphNode[] fromNode = new GraphNode[nodes.Count()];

            //copy nodes over starting from 0 in the index
            nodes.CopyTo(fromNode, 0);

            //foreach loop gets each node in fromNode, each time adding the corresponding node value from the index into the text boxes
            foreach (var node in fromNode)
            {
                FromListBox.Items.Add(node.ID);
                ToListBox.Items.Add(node.ID);
            }
        }
        
        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            //Get selected value from each list box and store it in from and to node variables
            int fromNodeSelection = Convert.ToInt32(FromListBox.SelectedItem);
            int toNodeSelection = Convert.ToInt32(ToListBox.SelectedItem);

            //Call add edge function on my graph, passing in the two values, adding an edge
            myGraph.AddEdge(fromNodeSelection, toNodeSelection);

            numedges++;

            EdgeLabel.Text = "Number of Edges: " + numedges.ToString();

        }
    }
}
