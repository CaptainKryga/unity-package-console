using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Console
{
	public class CustomConsole
	{
		private GameObject console;
		private TMP_InputField inputField;
		private ScrollRect scrollRect;
		private RectTransform content;
		private GameObject prefab;
		private bool isVisible;
		
		public bool IsVisible { get => isVisible; set => isVisible = value; }

		public CustomConsole(TMP_InputField inputField, GameObject prefab, Transform content, GameObject console)
		{
			this.console = console;
			this.inputField = inputField;
			this.content = (RectTransform)content;
			this.prefab = prefab;

			scrollRect = content.GetComponentInParent<ScrollRect>();

			Support.CreateItem(prefab, content);
			inputField.text = "init";
		}

		public void UpdateVisibleConsole()
		{
			console.SetActive(isVisible);
		}

		public void CreateNewMessage(string message)
		{
			TMP_Text mess = Support.CreateItem(prefab, content).GetComponent<TMP_Text>();
			mess.text = message;

			scrollRect.verticalScrollbar.value = 0;
		}	
		
		public void CreateNewMessage(string message, Color color)
		{
			TMP_Text mess = Support.CreateItem(prefab, content).GetComponent<TMP_Text>();
			mess.color = color;
			mess.text = message;
			
			scrollRect.verticalScrollbar.value = 0;
		}

		public string GetNewCommand()
		{
			string res = inputField.text;
			CreateNewMessage("> " + res);
			inputField.text = "";
			return res;
		}

		//human message
		//system message
	}
}