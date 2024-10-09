using System;
using UnityEngine;

namespace InlyIT
{
	[Serializable]
	public class CharacterJson
	{
		public CharacterInfo[] Characters;

		public static CharacterJson CreateFromJSON(string json)
		{
			return JsonUtility.FromJson<CharacterJson>(json);
		}
	}
}