﻿using UnityEngine;
using System.Collections;

public class MainCameraMyDoor : MonoBehaviour {

	//public string Name1;
	void Start () {
	//	Name1=PlayerPrefs.GetString("Player1Name");
	}

	void Update () {
	
	}
	
	void OnGUI(){
		//Name1 = GUI.TextField (new Rect (380,500, 128, 32), Name1);
		if (GUI.Button (new Rect (405, 500, 130, 32), "Main Menu"))
						Application.LoadLevel (0);
		if (GUI.Button (new Rect (535, 500, 130, 32), "Level Coins"))
			Application.LoadLevel (4);
		if (GUI.Button (new Rect (665, 500, 130, 32), "Leaderboard"))
			Application.LoadLevel (5);
		if (GUI.Button (new Rect (795, 500, 130, 32), "Retry"))
			Application.LoadLevel (2);
		if (GUI.Button (new Rect (925, 500, 130, 32), "Quit"))
						Application.Quit ();
	}


}