using UnityEngine;

namespace Console
{
	public class Support : MonoBehaviour
	{
		public static GameObject CreateItem(GameObject prefab, Transform parent)
		{
			return Instantiate(prefab, parent);
		}
	}
}