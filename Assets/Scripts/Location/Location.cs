using UnityEngine;
using UnityEngine.UI;

namespace InlyIT
{
	public class Location : BaseObject
	{
		[SerializeField] Image IconImage;

		LocationInfo locationInfo => (LocationInfo)base.Info;
		public new LocationInfo Info
		{
			get => (LocationInfo)base.Info;
			set => base.Info = value;
		}

		Sprite Preview;

		void Start()
		{
			IconImage.sprite = Preview = Resources.Load<Sprite>($"Locations/" + locationInfo.PreviewImage);
		}

		public override string GetDescription()
		{
			return $"Name: {locationInfo.Name}\n" +
				$"Description: {locationInfo.Description}";
		}

		public override void SetPreviewInfo(Text previewText)
		{
			base.SetPreviewInfo(previewText);
			Debug.Log("Called SetPreviewInfo: " + Info.Name + "\n" +
				"Description:" + locationInfo.Description + "\n" +
				"SceneName:" + locationInfo.SceneName);

			LocationListLoader loader = (LocationListLoader)this.loader;
			loader.SetPreviewImage(Preview);
		}
	}
}