using UnityEngine;
using System.Collections;

public class MainCameraMyDoor : MonoBehaviour {

	//private int toolbarInt = 0;
	//private string[] toolbarStrings = {"Toolbar1", "Toolbar2", "Toolbar3"};
	//private int selectedToolbar = 0;
	//private string[] toolbarStrings = {"One", "Two"};

	//public string Name1;
	void Start () {
	//	Name1=PlayerPrefs.GetString("Player1Name");
	}

	void Update () {
	
	}

		
		
		


	void OnGUI(){
		//Name1 = GUI.TextField (new Rect (380,500, 128, 32), Name1);
		//GUI.Button(new Rect(Screen.width * (1f/6.55f),Screen.height * (0.1f/6.3f),Screen.width * (4.8f/6.55f), Screen.height * (0.85f/6.3f)),"Click")
			if (GUI.Button(new Rect(Screen.width * (1.8f/6.55f),Screen.height * (5f/6.3f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Main Menu"))
						Application.LoadLevel (0);
		if (GUI.Button (new Rect (((Screen.width * (1.8f/6.55f))+Screen.width*(1f/9f)),Screen.height * (5f/6.3f),Screen.width * (1f/9f), Screen.height * (1f/16f)), "Level Coins"))
			Application.LoadLevel (4);
		if (GUI.Button (new Rect (((Screen.width * (1.8f/6.55f))+2*(Screen.width*(1f/9f))),Screen.height * (5f/6.3f),Screen.width * (1f/8f), Screen.height * (1f/16f)), "Leaderboard"))
			Application.LoadLevel (5);
		if (GUI.Button (new Rect (((Screen.width * (1.8f/6.55f))+2*(Screen.width*(1f/9f))+Screen.width*(1f/8f)),Screen.height * (5f/6.3f),Screen.width * (1f/12f), Screen.height * (1f/16f)), "Retry"))
			Application.LoadLevel (2);
		if (GUI.Button (new Rect (((Screen.width * (1.8f/6.55f))+2*(Screen.width*(1f/9f))+Screen.width*(1f/8f)+Screen.width*(1f/12f)),Screen.height * (5f/6.3f),Screen.width * (1f/12f), Screen.height * (1f/16f)), "Quit"))
						Application.Quit ();
	
/*toolbarInt = GUI.Toolbar (new Rect (25, 25, 250, 30), toolbarInt, toolbarStrings);

				// Determine which button is active, whether it was clicked this frame or not
				selectedToolbar = GUI.Toolbar (new Rect (50, 10, Screen.width - 100, 30), selectedToolbar, toolbarStrings);
				
				// If the user clicked a new Toolbar button this frame, we'll process their input
				if (GUI.changed)
				{
					Debug.Log("The toolbar was clicked");
					
					if (0 == selectedToolbar)
					{
						Debug.Log("First button was clicked");
					}
					else
					{
						Debug.Log("Second button was clicked");
					}
				}*/
			}
			


	}