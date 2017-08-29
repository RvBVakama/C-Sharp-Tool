using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tool
{
	// list of items in the game.
	public enum EItemList
	{
		ENUM_SPIKES,
		ENUM_WALL,
		ENUM_FLOOR,
		ENUM_MOVEAB
	}

	class Items
	{
		static public void InitializeItemList()
		{
			// setting up the texture to match their enums in the dictionary.
			dictItemList.Add(EItemList.ENUM_SPIKES, Properties.Resources.Spikes);
			dictItemList.Add(EItemList.ENUM_WALL, Properties.Resources.Wall);
			dictItemList.Add(EItemList.ENUM_FLOOR, Properties.Resources.Floor);
			dictItemList.Add(EItemList.ENUM_MOVEAB, Properties.Resources.Move_AB);
		}

		static public Dictionary<EItemList, Bitmap> dictItemList = new Dictionary<EItemList, Bitmap>();

		// making EItemList a singleton to access it from Form1 (formMmaakpe)
		static public EItemList currentItem;
	}
}
