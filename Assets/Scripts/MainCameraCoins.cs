using UnityEngine;
using System.Collections;

public class MainCameraCoins : MonoBehaviour {
	public string Name1,Name2,Name3;

	void Start () {
		}
	void Update () {
	}

	void OnGUI(){
		Name1 = GUI.TextField (new Rect (360, 0, 130, 32), Name1);
		Name2 = GUI.TextField (new Rect (490, 0, 128, 32), Name2);
		Name3 = GUI.TextField (new Rect (620, 0, 128, 32), Name3);

		GUI.Label(new Rect(260, 5, 100, 20), "Players Names : ");


		if (GUI.Button (new Rect (750, 0, 128, 32), "Save")) {
						PlayerPrefs.SetString ("Player1Name", Name1);
						PlayerPrefs.SetString ("Player2Name", Name2);
						PlayerPrefs.SetString ("Player3Name", Name3);
				}

		if (GUI.Button (new Rect (405, 500, 130, 32), "Main Menu"))
				Application.LoadLevel (0);
			if (GUI.Button (new Rect (535, 500, 130, 32), "Level Safes"))
				Application.LoadLevel (2);
			if (GUI.Button (new Rect (665, 500, 130, 32), "Leaderboard"))
				Application.LoadLevel (5);
			if (GUI.Button (new Rect (795, 500, 130, 32), "Retry"))
				Application.LoadLevel (4);
			if (GUI.Button (new Rect (925, 500, 130, 32), "Quit"))
				Application.Quit ();

	
	
	}


}
