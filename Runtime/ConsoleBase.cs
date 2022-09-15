using System;
using UnityEngine;
using UnityEngine.UI;

namespace Console
{
	public class ConsoleBase
	{
		private InputField _inputField;
		private Transform _content;
		private GameObject _prefab;

		public ConsoleBase()
		{
			
		}
		
		
		public ConsoleBase(InputField inputField, Transform content, GameObject prefab, Action enter)
		{
			_inputField = inputField;
			_content = content;
			_prefab = prefab;
		}
		
		
	}
}