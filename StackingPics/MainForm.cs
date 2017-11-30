using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackingPics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartingQuery _startingquery = new StartingQuery();
            _startingquery.ShowDialog();
        }
    }
}
