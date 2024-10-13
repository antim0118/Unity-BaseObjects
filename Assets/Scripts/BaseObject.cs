using UnityEngine;
using UnityEngine.UI;

namespace InlyIT
{
	public class BaseObject : MonoBehaviour
	{
		public BaseObjectInfo Info;

		Button button;
		internal ObjectListLoader loader;

		void Awake()
		{
			button = GetComponent<Button>();
		}

		void OnEnable()
		{
			button.onClick.AddListener(OnObjectSelect);
		}

		void OnDisable()
		{
			button.onClick.RemoveAllListeners();
		}

		public virtual void SetPreviewInfo(Text previewText)
		{
			previewText.text = GetDescription();
		}

		public virtual string GetDescription()
		{
			return $"Name: {Info.Name}";
		}

		public void OnObjectSelect()
		{
			loader.SelectObject(this);
		}
	}
}