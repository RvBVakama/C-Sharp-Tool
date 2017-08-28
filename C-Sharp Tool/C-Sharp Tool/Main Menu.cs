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
    public partial class Main_Menu : UserControl
    {
		public delegate void ButtonEvent(object sender, EventArgs e);

		public Main_Menu()
        {
            InitializeComponent();
		}

		public void btnNewSet(ButtonEvent dd)
		{
			btnNew.Click += new EventHandler(dd);
		}

        private void btnNew_Click(object sender, EventArgs e)
        {
			Hide();
			Global.MapSize.Show();
		}

		private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			Global.uExit();
		}

		private void lblTitle_Click(object sender, EventArgs e)
        {

        }

		private void Main_Menu_Load(object sender, EventArgs e)
		{

		}
	}
}
