using System.Windows.Forms;
namespace C_Sharp_Tool
{
	class Global
	{
		static public formMapSize MapSize = new formMapSize();

		static public void uExit()
		{
			DialogResult exitornot = MessageBox.Show("Are you certain that you would like to exit Mmaakpe", "Exit", MessageBoxButtons.YesNo);
			if (exitornot == DialogResult.Yes)
			{
				Application.Exit();
			}

			else if (exitornot == DialogResult.No)
			{
				//nada
			}
		}
	}
}
