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
	public partial class formMapSize : Form
	{
        public static int tet = 0;

        public delegate void ButtonEvent(object sender, EventArgs e);

        public formMapSize()
		{
			InitializeComponent();
		}

        public void btnNewSet(ButtonEvent dd)
        {
            btnSet.Click += new EventHandler(dd);
        }

        private void btnSet_Click(object sender, EventArgs e)
		{
			Close();
            Global.MapSize.Show();
        }

        private void nudMapSize_ValueChanged(object sender, EventArgs e)
        {
           tet = Convert.ToInt32(Math.Round(nudMapSize.Value, 0));
        }
    }
}
