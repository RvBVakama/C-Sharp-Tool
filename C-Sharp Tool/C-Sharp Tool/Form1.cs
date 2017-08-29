using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace C_Sharp_Tool
{
	public partial class formMmaakpe : Form
	{
		// creating the map and setting up the initial items
		EItemList[,] EIL = new EItemList[,]
			{{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR},
			{EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR, EItemList.ENUM_FLOOR}};

		public formMmaakpe()
		{
			InitializeComponent();
			Global.MapSize.btnNewSet(btnSet_Click);
			Items.InitializeItemList();

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
		}

		private void pbGridPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			int nBoxSize = 690;

			int nNumOfCells = 0;
			int nCellSize = 0;

			nNumOfCells = formMapSize.nMapGridSize;

			nCellSize = nBoxSize / nNumOfCells;

			// Draw images to screen.
			for (int i = 0; i < EIL.GetLength(0); ++i)
			{
				for (int j = 0; j < EIL.GetLength(1); ++j)
				{
					Rectangle destRect = new Rectangle((46 * i), (46 * j), 46, 46);

					// Create rectangle for source image.
					Rectangle srcRect = new Rectangle(0, 0, 64, 64);

					GraphicsUnit units = GraphicsUnit.Pixel;

					//e.Graphics.DrawImage(Items.dictItemList[EIL[i,j]], (46 * i), (46 * j), 46, 46);
					e.Graphics.DrawImage(Items.dictItemList[EIL[i, j]], destRect, srcRect, units);
				}
			}

			Pen p = new Pen(Color.LightGray);

			for (int y = 0; y < nNumOfCells; ++y)
			{
				g.DrawLine(p, 0, y * nCellSize, nNumOfCells * nCellSize, y * nCellSize);
			}

			for (int x = 0; x < nNumOfCells; ++x)
			{
				g.DrawLine(p, x * nCellSize, 0, x * nCellSize, nNumOfCells * nCellSize);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Point point = pictureBox1.PointToClient(Cursor.Position);

			int posX = point.X;
			int posY = point.Y;

			posX = posX / 46;
			posY = posY / 46;

			EIL[posX, posY] = Items.currentItem;

			Invalidate();
			Refresh();
		}

		private void pbItem1_Click(object sender, EventArgs e)
		{
			Items.currentItem = EItemList.ENUM_SPIKES;
		}

		private void pbItem2_Click(object sender, EventArgs e)
		{
			Items.currentItem = EItemList.ENUM_MOVEAB;
		}

		private void pictureBox39_Click(object sender, EventArgs e)
		{
			Items.currentItem = EItemList.ENUM_FLOOR;
		}

		private void pictureBox55_Click(object sender, EventArgs e)
		{
			Items.currentItem = EItemList.ENUM_WALL;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();

			if (open.ShowDialog() == DialogResult.OK)
			{
				//read in file location
				string text = System.IO.File.ReadAllText(open.FileName);
				string[] values = text.Split(',');
				int index = 0;

				for (int i = 0; i < EIL.GetLength(1); ++i)
				{
					for (int j = 0; j < EIL.GetLength(0); ++j)
					{
						EIL[j,i] = (EItemList)Enum.Parse(typeof(EItemList), values[index]);
						index++;
						Thread.Sleep(1);
						Invalidate();
						Refresh();
					}
				}
			}
		}

		private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.InitialDirectory = @"C:\Users\s171761\Desktop\New folder";
			save.Filter = "Text Files|*.txt";
			save.DefaultExt = "txt";

			if (save.ShowDialog() == DialogResult.OK)
			{
				//save a text file
				string text = "";

				for (int i = 0; i < EIL.GetLength(1); ++i)
				{
					for (int j = 0; j < EIL.GetLength(0); ++j)
					{
						text += EIL[j, i].ToString();
						text += ",";
					}
				}
				File.WriteAllText(save.FileName, text);
			}
		}


		private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Global.uExit();
		}

	}
}
