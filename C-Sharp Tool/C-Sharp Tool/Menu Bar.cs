using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C_Sharp_Tool
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

       

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if(open.ShowDialog() == DialogResult.OK)
            {
				Bitmap image = (Bitmap)Image.FromFile(open.FileName);
				pbImg.Image = (Bitmap)Image.FromFile(open.FileName);

				//read in file location
				//string text = System.IO.File.ReadAllText(open.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SaveFileDialog save = new SaveFileDialog();
			save.InitialDirectory = @"C:\Users\s171761\Desktop\New folder";
			save.Filter = "Text Files|*.txt";
			save.DefaultExt = "txt";

			if(save.ShowDialog() == DialogResult.OK)
			{
				//save a text file
				string text = "hellow world";
				File.WriteAllText(save.FileName, text);
			}
        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Global.uExit();
        }
    }
}
