using UnityEngine;
using System.Collections;

public class MainCamLevelChoose : MonoBehaviour {
	public GUISkin skin;
	public GUISkin skinbuttons;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = skin;
		GUI.Label(new Rect(((Screen.width * (1.2f/5f))),Screen.height * (1f/40f),Screen.width * (3f/4f), Screen.height * (1f/2f)), "Choose a game");
		GUI.skin = skinbuttons;
		if (GUI.Button (new Rect (((Screen.width * (1f/7f))),Screen.height * (2f/5f),/*Screen.width * (2f/5f), Screen.height * (1f/8f)*/180,80), "SAFES"))
			Application.LoadLevel ("MyDoor");
		if (GUI.Button (new Rect (((Screen.width * (5.2f/7f))),Screen.height * (2f/5f),/*Screen.width * (1f/6f), Screen.height * (1f/8f)*/180,80), "COINS"))
			Application.LoadLevel ("Car");
		if (GUI.Button (new Rect (((Screen.width * (1.9f/5f))),Screen.height * (2f/3f),/*Screen.width * (1f/6f), Screen.height * (1f/8f)*/300,80), "SPHERES"))
			Application.LoadLevel ("Sphere");
		
	}


}
