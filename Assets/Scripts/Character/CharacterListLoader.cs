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
				character.Name = ch.Name;
				character.Level = ch.Level;
				character.Model = Resources.Load<GameObject>($"Models/" + ch.Model);
				character.Avatar = Resources.Load<Sprite>($"Models/" + ch.Avatar);
				character.PreviewPos = ch.PreviewPos.ToVector3();
				character.PreviewAng = ch.PreviewAng.ToVector3();
			}
		}
	}
}
