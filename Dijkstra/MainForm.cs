using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class MainForm : Form
    {
        GraphData graphData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (OpenDataFileDialog.ShowDialog() == DialogResult.OK)
            {
                Filename.Text = OpenDataFileDialog.FileName;
            }
        }        
        
        private void ImportData_Click(object sender, EventArgs e)
        {
            graphData = LoadData.Run(Filename.Text);
            
            pathStart.Items.Clear();
            pathStart.Items.AddRange(Enumerable.Range(0, graphData.Rank).Select(i => i.ToString()).ToArray());
            pathFinish.Items.Clear();
            pathFinish.Items.AddRange(Enumerable.Range(0, graphData.Rank).Select(i => i.ToString()).ToArray());            
        }

        private void RunSearch_Click(object sender, EventArgs e)
        {
            var solverPath = DijkstraSolver.Run(graphData, pathStart.SelectedIndex, pathFinish.SelectedIndex);

            pathLength.Text = solverPath.PathLength.ToString();
            path.Text = solverPath.Path
                .Aggregate<int, string>("", (x, y) => x + " => " + y.ToString());
        }
    }
}
