﻿using System;
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
		public formMmaakpe()
		{
			InitializeComponent();

			ucMainMenu.btnNewSet(ucMapCreation.btnNewGet);
			formMapSize.btnNewSet(ucMapCreation.btnNewGet);
		}
				
        private void formMmaakpe_Load(object sender, EventArgs e)
        {
            ucMapCreation.Hide();
        }
	}
}
