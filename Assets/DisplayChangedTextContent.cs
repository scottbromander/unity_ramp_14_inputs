using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayChangedTextContent : MonoBehaviour {
	private InputField inputField;

	// Use this for initialization
	void Start () {
		inputField = GetComponent<InputField>();
	}
	
	// Update is called once per frame
	public void PrintNewValue () {
		string msg = "new content = '" + inputField.text + "'";
		print(msg);
	}
}
