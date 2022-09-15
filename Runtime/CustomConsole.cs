using TMPro;
using UnityEngine;

namespace Console
{
	public class CustomConsole
	{
		private GameObject console;
		private TMP_InputField inputField;
		private Transform content;
		private GameObject prefab;
		private bool isVisible;
		
		public bool IsVisible { get => isVisible; set => isVisible = value; }

		public CustomConsole(TMP_InputField inputField, GameObject prefab, Transform content, GameObject console)
		{
			this.console = console;
			this.inputField = inputField;
			this.content = content;
			this.prefab = prefab;

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
		}

		public string GetNewCommand()
		{
			string res = inputField.text;
			CreateNewMessage("> " + res);
			inputField.text = "";
			return res;
		}
	}
}