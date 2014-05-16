using UnityEngine;
using System.Collections;

public class MainCamMainMenu : MonoBehaviour {

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
		GUI.Label(new Rect(((Screen.width * (1f/6f))),Screen.height * (1f/10f),Screen.width * (3f/4f), Screen.height * (1f/2f)), "National Lottary");
		GUI.skin = skinbuttons;
		if (GUI.Button (new Rect (((Screen.width * (2f/6f))),Screen.height * (1f/2f),/*Screen.width * (2f/5f), Screen.height * (1f/8f)*/350,80), "PLAY GAME"))
			Application.LoadLevel ("LevelChooseMenu");
		if (GUI.Button (new Rect (((Screen.width * (2f/5f))),Screen.height * (2/3f),/*Screen.width * (1f/6f), Screen.height * (1f/8f)*/220,80), "QUIT"))
			Application.Quit ();

	}



}
