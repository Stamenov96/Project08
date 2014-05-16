using UnityEngine;
using System.Collections;

public class MainCameraSecondSafes : MonoBehaviour {
	//public Texture buton;
	// Use this for initialization
	public GUISkin skin;
	public GUISkin skinbuttons;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.skin = skinbuttons;
		
		if (GUI.Button(new Rect(Screen.width * (1f/7f),Screen.height * (5.5f/7f),/*Screen.width * (1f/9f), Screen.height * (1f/16f)*/150,60), "Main Menu"))
			Application.LoadLevel ("MainMenu");
		if (GUI.Button (new Rect (((Screen.width * (1f / 7f)) + 150), Screen.height * (5.5f / 7f), /*Screen.width * (1f / 9f), Screen.height * (1f / 16f)*/150,60), "Level Coins"))
			Application.LoadLevel ("Car");
		if (GUI.Button (new Rect (((Screen.width * (1f / 7f)) + 300), Screen.height * (5.5f / 7f), /*Screen.width * (1f / 12f), Screen.height * (1f / 16f)*/130, 60), "Spheres"))
			Application.LoadLevel ("Sphere");
		if (GUI.Button (new Rect (((Screen.width * (1f / 7f)) + 430), Screen.height * (5.5f / 7f), /*Screen.width * (1f / 8f), Screen.height * (1f / 16f)*/180,60), "Leaderboard"))
			Application.LoadLevel ("Unity3D-Leaderboard");
		if (GUI.Button (new Rect (((Screen.width * (1f/7f))+610),Screen.height * (5.5f/7f),/*Screen.width * (1f/12f), Screen.height * (1f/16f)*/100,60), "Quit"))
			Application.Quit ();



	}
}