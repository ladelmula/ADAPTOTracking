using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStyles
{
	public static class Utils
	{
		public static void ImagenesCarpetas( ref ImageList dynamicImageList)
		{
			var resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, true, false);
			if (resourceSet != null)
			{
				foreach (DictionaryEntry entry in resourceSet)
				{
					var value = entry.Value as Bitmap; //only get images
					if (value != null && entry.Key.ToString().StartsWith("Carpeta"))
					{
						dynamicImageList.Images.Add((string)entry.Key, value);
					}
				}
			}

		}
	}
}
