using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	//	var hideButtons = true;
	public string Name2;
	// Use this for initialization
	void Start () {
		Name2=PlayerPrefs.GetString("Player2Name");
		Debug.Log ("SEC");
	}
	
	void OnGUI(){
		Name2 = GUI.TextField (new Rect (500, 0, 128, 32), Name2);
		if (GUI.Button (new Rect (628, 0, 128, 32), "Save"))
			PlayerPrefs.SetString ("Player2Name", Name2);

		//	if (GUILayout.Button ("Toggle Buttons"))
		//		
		//					hideButtons = ! hideButtons;
		//	if (hideButtons) return;
	}
}
