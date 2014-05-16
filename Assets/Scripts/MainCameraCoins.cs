using UnityEngine;
using System.Collections;

public class MainCameraCoins : MonoBehaviour {
	public string Name1,Name2,Name3;
	public int save=0;
	public GUISkin Label;
	public GUISkin skinbuttons;
	public GUISkin txtf;

	void Start () {
		}
	void Update () {
	}

	void OnGUI(){
		if (save==0) {
		
			GUI.skin=Label;

			GUI.Label(new Rect(((Screen.width * (1f/9f))),Screen.height * (1f/20f),/*Screen.width * (1f/2f), Screen.height * (1f/2f)*/850,100), "Enter Players Names");
	
			GUI.skin=txtf;

		Name1 = GUI.TextField (new Rect (((Screen.width * (1f/6f))+Screen.width*(1f/9f)),Screen.height * (1.2f/5f),Screen.width * (1f/9f), Screen.height * (1f/20f)), Name1);
		Name2 = GUI.TextField (new Rect (((Screen.width * (1f/6f))+2*Screen.width*(1f/9f)),Screen.height * (1.2f/5f),Screen.width * (1f/9f), Screen.height * (1f/20f)), Name2);
		Name3 = GUI.TextField (new Rect (((Screen.width * (1f/6f))+3*Screen.width*(1f/9f)),Screen.height * (1.2f/5f),Screen.width * (1f/9f), Screen.height * (1f/20f)), Name3);

		


			if (GUI.Button (new Rect (((Screen.width * (1f/6f))+4*Screen.width*(1f/9f)),Screen.height * (1.2f/5f),Screen.width * (1f/9f), Screen.height * (1f/20f)), "GO")) {
								PlayerPrefs.SetString ("Player1Name", Name1);
								PlayerPrefs.SetString ("Player2Name", Name2);
								PlayerPrefs.SetString ("Player3Name", Name3);
								save=1;
							}
				}

		GUI.skin = skinbuttons;
		
		if (GUI.Button(new Rect(Screen.width * (1f/7f),Screen.height * (5.5f/7f),/*Screen.width * (1f/9f), Screen.height * (1f/16f)*/150,60), "Main Menu"))
			Application.LoadLevel ("MainMenu");
		if (GUI.Button (new Rect (((Screen.width * (1f / 7f)) + 150), Screen.height * (5.5f / 7f), /*Screen.width * (1f / 9f), Screen.height * (1f / 16f)*/150,60), "Safes"))
			Application.LoadLevel ("MyDoor");
		if (GUI.Button (new Rect (((Screen.width * (1f / 7f)) + 300), Screen.height * (5.5f / 7f), /*Screen.width * (1f / 12f), Screen.height * (1f / 16f)*/130, 60), "Spheres"))
			Application.LoadLevel ("Sphere");
		if (GUI.Button (new Rect (((Screen.width * (1f / 7f)) + 430), Screen.height * (5.5f / 7f), /*Screen.width * (1f / 8f), Screen.height * (1f / 16f)*/180,60), "Leaderboard"))
			Application.LoadLevel ("Unity3D-Leaderboard");
		if (GUI.Button (new Rect (((Screen.width * (1f / 7f)) + 610), Screen.height * (5.5f / 7f), /*Screen.width * (1f / 12f), Screen.height * (1f / 16f)*/100,60), "Retry"))
			Application.LoadLevel ("Car");
		if (GUI.Button (new Rect (((Screen.width * (1f/7f))+710),Screen.height * (5.5f/7f),/*Screen.width * (1f/12f), Screen.height * (1f/16f)*/100,60), "Quit"))
			Application.Quit ();
	}


}
