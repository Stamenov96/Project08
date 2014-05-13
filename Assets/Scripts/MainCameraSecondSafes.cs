using UnityEngine;
using System.Collections;

public class MainCameraSecondSafes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		//Name1 = GUI.TextField (new Rect (380,500, 128, 32), Name1);
		if (GUI.Button (new Rect (((Screen.width * (1f/4f))),Screen.height * (4f/6f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Main Menu"))
			Application.LoadLevel (0);
		if (GUI.Button (new Rect (((Screen.width * (1f/4f))+Screen.width*(1f/9f)),Screen.height * (4f/6f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Level Coins"))
			Application.LoadLevel (4);
		if (GUI.Button (new Rect (((Screen.width * (1f/4f))+2*Screen.width*(1f/9f)),Screen.height * (4f/6f),Screen.width * (1f/8f), Screen.height * (1f/16f)), "Leaderboard"))
			Application.LoadLevel (5);
		if (GUI.Button (new Rect (((Screen.width * (1f/4f))+2*Screen.width*(1f/9f))+Screen.width * (1f/8f),Screen.height * (4f/6f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Quit"))
			Application.Quit ();
	}



}
