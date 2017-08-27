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

		public void btnNewGet(object sender, EventArgs e)
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

			int nBoxSize = 700;

			int nNumOfCells = 0;
			int nCellSize = 0;

			nNumOfCells = formMapSize.tet;

			nCellSize = nBoxSize / nNumOfCells; 
			
			Pen p = new Pen(Color.LightGray);

			for (int y = 0; y < nNumOfCells; ++y)
			{
				g.DrawLine(p, 0, y * nCellSize, nNumOfCells * nCellSize, y * nCellSize);
			}

			for (int x = 0; x < nNumOfCells; ++x)
			{
				g.DrawLine(p, x * nCellSize, 0, x * nCellSize, nNumOfCells * nCellSize);
			}


			// Create image.
			//Image newImage = Image.FromFile("Move");
			

			// Create rectangle for displaying image.
			Rectangle destRect = new Rectangle(100,0,64,64);

			// Create rectangle for source image.
			Rectangle srcRect = new Rectangle(0, 0, 64, 64);
			GraphicsUnit units = GraphicsUnit.Pixel;

			// Draw image to screen.
			e.Graphics.DrawImage(Properties.Resources.Spikes, destRect, srcRect, units);

		}
	}
}
