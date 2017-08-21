using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Tool
{
    public partial class Map_Creation : UserControl
    {
		public Map_Creation()
        {
            InitializeComponent();
        }

		public void tetget(object sender, EventArgs e)
		{
			Show();
		}

		private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Map_Creation_Load(object sender, EventArgs e)
        {
			pbItem1.BackgroundImage = Properties.Resources.Spikes;
			pbItem2.BackgroundImage = Properties.Resources.Wall;
			pbItem3.BackgroundImage = Properties.Resources.Floor;
			pbItem4.BackgroundImage = Properties.Resources.Move_AB;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }
		
		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
	}
}
