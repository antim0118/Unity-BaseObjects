using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace InlyIT
{
	public class Character : BaseObject
	{
		[SerializeField] Image AvatarObject;
		[SerializeField] Text NameTextObject;

		public int Level;
		public Sprite Avatar;
		public GameObject Model;
		public Vector3 PreviewPos, PreviewAng;

		void Start()
		{
			AvatarObject.sprite = Avatar;
			NameTextObject.text = Name;
		}

		public override string GetDescription()
		{
			return $"Name: {Name}\n" +
				$"Level: {Level}";
		}

		public override void SetPreviewInfo(Text previewText)
		{
			base.SetPreviewInfo(previewText);
			Debug.Log("Called SetPreviewInfo: " + Name + "\n" +
				"Pos:" + PreviewPos + "\n" +
				"Ang:" + PreviewAng);

			//удалить имеющиеся превью-модели со сцены
			GameObject.FindGameObjectsWithTag("PreviewModel").ToList().ForEach(m => Destroy(m));

			//поместить модель перед камерой
			GameObject previewModel = new GameObject("PreviewModel");
			previewModel.tag = "PreviewModel";
			GameObject model = Instantiate(Model, previewModel.transform);
			model.transform.localPosition = PreviewPos;
			model.transform.localEulerAngles = PreviewAng;
			previewModel.AddComponent<RotateObject>();
		}
	}
}
