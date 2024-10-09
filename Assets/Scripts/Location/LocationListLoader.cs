using UnityEngine;
using UnityEngine.UI;

namespace InlyIT
{
	public class LocationListLoader : ObjectListLoader
	{
		public override void LoadList()
		{
			base.LoadList();

			string json = Resources.Load<TextAsset>("Locations").text;
			LocationInfo[] locations = LocationJson.CreateFromJSON(json).Locations;
			foreach (var loc in locations)
			{
				GameObject go = Instantiate(Prefab, ViewportContent);
				Location location = go.GetComponent<Location>();
				location.Name = loc.Name;
				location.Description = loc.Description;
				location.Preview = Resources.Load<Sprite>($"Locations/" + loc.PreviewImage);
				location.SceneId = loc.SceneId;
			}
		}

		public void SetPreviewImage(Sprite sprite)
		{
			Image img = PreviewImage.GetComponent<Image>();
			img.sprite = sprite;
		}
	}
}
