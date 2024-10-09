using System.Globalization;
using UnityEngine;

namespace InlyIT
{
	public static class Utils
	{
		/// <summary>Переводит строку формата "x y z" в Vector3</summary>
		public static Vector3 ToVector3(this string str)
		{
			string[] spl = str.Split(' ');
			float x = 0, y = 0, z = 0;
			if (spl.Length >= 1)
				float.TryParse(spl[0], NumberStyles.Number, NumberFormatInfo.InvariantInfo, out x);
			if (spl.Length >= 2)
				float.TryParse(spl[1], NumberStyles.Number, NumberFormatInfo.InvariantInfo, out y);
			if (spl.Length >= 3)
				float.TryParse(spl[2], NumberStyles.Number, NumberFormatInfo.InvariantInfo, out z);
			return new Vector3(x, y, z);
		}
	}
}
