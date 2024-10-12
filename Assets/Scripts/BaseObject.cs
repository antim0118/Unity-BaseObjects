using UnityEngine;
using UnityEngine.UI;

namespace InlyIT
{
	public class BaseObject : MonoBehaviour
	{
		public string Name { get; set; }

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
			return $"Name: {Name}";
		}

		public void OnObjectSelect()
		{
			loader.SelectObject(this);
		}
	}
}