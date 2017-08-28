using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Tool
{
	public partial class formMmaakpe : Form
	{
		EItemList[,] EIL = new EItemList[,]
			{{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR},
			{EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR, EItemList.EFLOOR}};

		public formMmaakpe()
		{
			InitializeComponent();
			Global.MapSize.btnNewSet(btnSet_Click);
		}
		private void formMmaakpe_Load(object sender, EventArgs e)
        {
		}

		private void btnSet_Click(object sender, EventArgs e)
		{
			Invalidate();
			Refresh();
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

		private void pbGridPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			int nBoxSize = 690;

			int nNumOfCells = 0;
			int nCellSize = 0;

			nNumOfCells = formMapSize.nMapGridSize;

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
			Rectangle destRect = new Rectangle(0, 0, 46, 46);

			// Create rectangle for source image.
			Rectangle srcRect = new Rectangle(0, 0, 64, 64);
			GraphicsUnit units = GraphicsUnit.Pixel;

			// Draw image to screen.
			//for (int i = 0; i < EIL.GetLength(0); ++i)
			//{
			//	for (int j = 0; j < EIL.GetLength(1); ++j)
			//	{

			//	}
			//}
			e.Graphics.DrawImage(Properties.Resources.Spikes, destRect, srcRect, units);

		}
	}
}
