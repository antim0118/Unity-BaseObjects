using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

namespace InlyIT
{
	public class Character : BaseObject
	{
		static GameObject previewModel;

		[SerializeField] Image AvatarObject;
		[SerializeField] Text NameTextObject;

		public new CharacterInfo Info
		{
			get => (CharacterInfo)base.Info;
			set => base.Info = value;
		}

		Sprite Avatar;
		GameObject Model;
		Vector3 PreviewPos, PreviewAng;

		void Start()
		{
			Model = Resources.Load<GameObject>($"Models/" + Info.Model);
			Avatar = Resources.Load<Sprite>($"Models/" + Info.Avatar);
			PreviewPos = Info.PreviewPos.ToVector3();
			PreviewAng = Info.PreviewAng.ToVector3();

			AvatarObject.sprite = Avatar;
			NameTextObject.text = Info.Name;
		}

		public override string GetDescription()
		{
			return $"Name: {Info.Name}\n" +
				$"Level: {Info.Level}";
		}

		public override void SetPreviewInfo(Text previewText)
		{
			base.SetPreviewInfo(previewText);
			Debug.Log("Called SetPreviewInfo: " + Info.Name + "\n" +
				"Pos:" + PreviewPos + "\n" +
				"Ang:" + PreviewAng);

			//поместить модель перед камерой
			if (previewModel != null)
				Destroy(previewModel);
			previewModel = new GameObject("PreviewModel");
			GameObject model = Instantiate(Model, previewModel.transform);
			model.transform.localPosition = PreviewPos;
			model.transform.localEulerAngles = PreviewAng;
			previewModel.AddComponent<RotateObject>();
		}
	}
}
