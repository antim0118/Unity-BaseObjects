using UnityEngine;

namespace InlyIT
{
	public class CharacterListLoader : ObjectListLoader
	{
		public override void LoadList()
		{
			base.LoadList();

			string json = Resources.Load<TextAsset>("Characters").text;
			CharacterInfo[] characters = CharacterJson.CreateFromJSON(json).Characters;
			foreach (var ch in characters)
			{
				GameObject go = Instantiate(Prefab, ViewportContent);
				Character character = go.GetComponent<Character>();
				character.loader = this;
				character.Info = ch;
			}
		}
	}
}
