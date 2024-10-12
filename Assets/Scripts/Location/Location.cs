using UnityEngine;
using UnityEngine.UI;

namespace InlyIT
{
	public class Location : BaseObject
	{
		[SerializeField] Image PreviewImage;

		public string Description;
		public Sprite Preview;
		public string SceneName;

		void Start()
		{
			PreviewImage.sprite = Preview;
		}

		public override string GetDescription()
		{
			return $"Name: {Name}\n" +
				$"Description: {Description}";
		}

		public override void SetPreviewInfo(Text previewText)
		{
			base.SetPreviewInfo(previewText);
			Debug.Log("Called SetPreviewInfo: " + Name + "\n" +
				"Description:" + Description + "\n" +
				"SceneName:" + SceneName);

			LocationListLoader loader = (LocationListLoader)this.loader;
			loader.SetPreviewImage(Preview);
		}
	}
}