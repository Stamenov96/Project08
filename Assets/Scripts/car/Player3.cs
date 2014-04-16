using UnityEngine;
using System.Collections;

public class Player3 : MonoBehaviour {
	//	var hideButtons = true;
	public string Name3;
	// Use this for initialization
	void Start () {
		Name3=PlayerPrefs.GetString("Player3Name");
		Debug.Log ("SEC");
	}
	
	void OnGUI(){
		Name3 = GUI.TextField (new Rect (800, 0, 128, 32), Name3);
		if (GUI.Button (new Rect (928, 0, 128, 32), "Save"))
			PlayerPrefs.SetString ("Player3Name", Name3);
		

	}
}
