using UnityEngine;

namespace InlyIT
{
	public class RotateObject : MonoBehaviour
	{
		void FixedUpdate()
		{
			transform.Rotate(Vector3.up);
		}
	}
}
