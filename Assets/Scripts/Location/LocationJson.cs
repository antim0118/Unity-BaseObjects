using System;
using UnityEngine;

namespace InlyIT
{
	[Serializable]
	public class LocationJson
	{
		public LocationInfo[] Locations;

		public static LocationJson CreateFromJSON(string json)
		{
			return JsonUtility.FromJson<LocationJson>(json);
		}
	}
}