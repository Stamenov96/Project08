using UnityEngine;
using System.Collections;

public class Steps : MonoBehaviour {
	public string steps;

	public GUIText p1;
	public GUIText p2;
	public GUIText p3;
	public GUIText CurrentPlayer;
	public GUIText WrongChoice;

	public int step_p1;
	public int steps_p1;
	public int step_p2;
	public int steps_p2;
	public int step_p3;
	public int steps_p3;
	private int clicks;

	private bool check1 = true;
	private bool check2 = true;


	public GameObject otherGameObject;
	private Open1 connect;

	public GameObject Primary;
	private Primary connectPrimary;

	void Awake()

	{
		connect = otherGameObject.GetComponent<Open1> ();
		connectPrimary = Primary.GetComponent<Primary> ();
		clicks = 0;
		PlayerPrefs.SetString ("Steps", "0");
	}

	void OnGUI() {

		steps = GUI.TextField (new Rect (400, 150, 128, 32), steps);
		if (GUI.Button (new Rect (540, 150, 128, 32), "Go")) {
						PlayerPrefs.SetString ("Steps", steps);


					if(int.Parse(steps) == 1 || int.Parse(steps) == 2)	{
						clicks++;
						WrongChoice.text = "";
					}
					else
						WrongChoice.text = "Wrong Choice!";
				}
	}

	void Update() 
	{
						p1.text = PlayerPrefs.GetString ("Player1Name") + steps_p1;
						p2.text = PlayerPrefs.GetString ("Player2Name") + steps_p2;
						p3.text = PlayerPrefs.GetString ("Player3Name") + steps_p3;
						
					if (clicks == 0)
						CurrentPlayer.text = PlayerPrefs.GetString ("Player1Name") + ": Chose '1' or '2' steps:";
					if (clicks == 1)
						CurrentPlayer.text = PlayerPrefs.GetString ("Player2Name") + ": Chose '1' or '2' steps:";
					if (clicks == 2)
						CurrentPlayer.text = PlayerPrefs.GetString ("Player3Name") + ": Chose '1' or '2' steps:";
		if (check1) {
			//if(clicks >= 0)	{
				if(connect.OpenCoin1 == 1) {
					
						if(connectPrimary.a == 1) {
							steps_p1 = steps_p1 + int.Parse(PlayerPrefs.GetString("Steps"));
						}
						if(connectPrimary.a == 2) {
							steps_p2 = steps_p2 + int.Parse(PlayerPrefs.GetString("Steps"));
						}
						if(connectPrimary.a == 3) {
							steps_p3 = steps_p3 + int.Parse(PlayerPrefs.GetString("Steps"));
						}
			
					}
			check1 = false;
		}
		if (check2) {
			if(connect.OpenCoin2 == 1) {
				
				if(connectPrimary.b == 1) {
					steps_p1 = steps_p1 + int.Parse(PlayerPrefs.GetString("Steps"));
				}
				if(connectPrimary.b == 2) {
					steps_p2 = steps_p2 + int.Parse(PlayerPrefs.GetString("Steps"));
				}
				if(connectPrimary.b == 3) {
					steps_p3 = steps_p3 + int.Parse(PlayerPrefs.GetString("Steps"));
				}
			}
			//	}
			
			
			check2 = false;
			check1 = true;
		}

		if (clicks == 3)
						clicks = 0;
		Debug.Log(steps_p1+" "+clicks);

			
	}


}