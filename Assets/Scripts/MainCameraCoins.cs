using UnityEngine;
using System.Collections;

public class MainCameraCoins : MonoBehaviour {
	public string Name1,Name2,Name3;
	public int save=0;

	void Start () {
		}
	void Update () {
	}

	void OnGUI(){
		if (save==0) {
		Name1 = GUI.TextField (new Rect (((Screen.width * (1f/6f))+Screen.width*(1f/9f)),Screen.height * (1f/60f),Screen.width * (1f/9f), Screen.height * (1f/20f)), Name1);
		Name2 = GUI.TextField (new Rect (((Screen.width * (1f/6f))+2*Screen.width*(1f/9f)),Screen.height * (1f/60f),Screen.width * (1f/9f), Screen.height * (1f/20f)), Name2);
		Name3 = GUI.TextField (new Rect (((Screen.width * (1f/6f))+3*Screen.width*(1f/9f)),Screen.height * (1f/60f),Screen.width * (1f/9f), Screen.height * (1f/20f)), Name3);

		GUI.Label(new Rect(((Screen.width * (1f/6f))),Screen.height * (1f/40f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Players Names : ");


			if (GUI.Button (new Rect (((Screen.width * (1f/6f))+4*Screen.width*(1f/9f)),Screen.height * (1f/60f),Screen.width * (1f/9f), Screen.height * (1f/20f)), "Save")) {
								PlayerPrefs.SetString ("Player1Name", Name1);
								PlayerPrefs.SetString ("Player2Name", Name2);
								PlayerPrefs.SetString ("Player3Name", Name3);
								save=1;
							}
				}

		if (GUI.Button (new Rect (((Screen.width * (1f/4.5f))),Screen.height * (6.6f/8f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Main Menu"))
				Application.LoadLevel (0);
		if (GUI.Button (new Rect (((Screen.width * (1f/4.5f)+Screen.width*(1f/9f))),Screen.height * (6.6f/8f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Level Safes"))
				Application.LoadLevel (2);
		if (GUI.Button (new Rect (((Screen.width * (1f/4.5f)+2*Screen.width*(1f/9f))),Screen.height * (6.6f/8f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Leaderboard"))
				Application.LoadLevel (5);
		    if (GUI.Button (new Rect (((Screen.width * (1f/4.5f)+3*Screen.width*(1f/9f))),Screen.height * (6.6f/8f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Retry"))
				Application.LoadLevel (4);
		    if (GUI.Button (new Rect (((Screen.width * (1f/4.5f)+4*Screen.width*(1f/9f))),Screen.height * (6.6f/8f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Quit"))
				Application.Quit ();

	
	
	}


}
