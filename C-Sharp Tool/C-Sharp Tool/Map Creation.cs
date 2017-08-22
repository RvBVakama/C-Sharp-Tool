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

		private void pbGridPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			int numOfCells = 50;
			int cellSize = 0;

			if (numOfCells == 70)
				cellSize = 10;

			if (numOfCells == 50)
				cellSize = 14;

			Pen p = new Pen(Color.LightGray);

			for (int y = 0; y < numOfCells; ++y)
			{
				g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
			}

			for (int x = 0; x < numOfCells; ++x)
			{
				g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
			}
		}
	}
}
