using UnityEngine;
using UnityEngine.UI;

namespace InlyIT
{
	public class ObjectListLoader : MonoBehaviour
	{
		[SerializeField] internal GameObject Prefab;
		[SerializeField] internal Transform ViewportContent;
		[SerializeField] internal Text PreviewText;
		[SerializeField] internal GameObject PreviewImage;

		BaseObject selectedObject;

		public void SelectObject(BaseObject obj)
		{
			selectedObject = obj;
			obj.SetPreviewInfo(PreviewText);
		}

		void Start()
		{
			LoadList();
		}

		public virtual void LoadList()
		{
			Debug.Log("Loading objects to list...");
		}
	}
}