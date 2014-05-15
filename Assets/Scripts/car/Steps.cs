using UnityEngine;
using System.Collections;

public class Steps : MonoBehaviour {
	public GUISkin skin;
	public string steps;

	public bool isButtonsVisible=true;
	public bool movement=true;
	public bool movement2 = true;
	public bool movement3 = true;

	public GUIText p1;
	public GUIText p2;
	public GUIText p3;
	public GUIText CurrentPlayer;
	public GUIText Win;

	//public int step_p1;
	public int steps_p1=0;
//	public int step_p2;
	public int steps_p2=0;
//	public int step_p3;
	public int steps_p3=0;


	public GameObject otherGameObject;
	private Open1 connect;

	public GameObject Primary;
	private Primary connectPrimary;

	public GameObject MCC;
	private MainCameraCoins connectMainCam;


	void Start(){

		PlayerPrefs.SetInt ("steps", 0);

	}

	void Awake()

	{
		connect = otherGameObject.GetComponent<Open1> ();
		connectPrimary = Primary.GetComponent<Primary> ();
		connectMainCam = MCC.GetComponent<MainCameraCoins> ();
	}

	void OnGUI() {
				//	PlayerPrefs.SetInt ("steps", 0);
				if (connectMainCam.save==1) {
						if (isButtonsVisible) {
				GUI.skin=skin;
				GUI.Label (new Rect (((Screen.width * (2.25f/6f))),Screen.height * (1f/20f),Screen.width * (1f/4f), Screen.height * (1f/10f)), "GOGOGO");
				
				if (GUI.Button (new Rect (((Screen.width * (1f/4.5f))),Screen.height * (1f/6f),Screen.width * (1f/4f), Screen.height * (1f/20f)), "1")) {
										PlayerPrefs.SetInt ("steps", 1);
										isButtonsVisible = false;
										movement = false;
										movement2 = false;
										movement3 = false;			
								}
				if (GUI.Button (new Rect (((Screen.width * (1f/4.5f))+Screen.width*(1f/4f)),Screen.height * (1f/6f),Screen.width * (1f/4f), Screen.height * (1f/20f)), "2")) {

										PlayerPrefs.SetInt ("steps", 2);
										isButtonsVisible = false;
										movement = false;
										movement2 = false;
										movement3 = false;
								}
						}
				}
		}
/*	void Main(){

		if (PlayerPrefs.GetString ("CurrentMover") == "Player1") {
			PlayerPrefs.GetInt("steps");
		//	PlayerPrefs.SetInt("CurrentMoverSteps",(PlayerPrefs.GetInt("Pl1Steps")+PlayerPrefs.GetInt("steps")));
		//	Debug.Log("ALALALAL "+PlayerPrefs.GetInt("CuttentMoverSteps"));
			steps_p1+=PlayerPrefs.GetInt("steps");
			Debug.Log("Steps"+steps_p1);
		}
		if (PlayerPrefs.GetString ("CurrentMover") == "Player2") {
			PlayerPrefs.GetInt("steps");
//			PlayerPrefs.SetInt("CurrentMoverSteps",(PlayerPrefs.GetInt("Pl2Steps")+PlayerPrefs.GetInt("steps")));
//			Debug.Log("ALALALAL "+PlayerPrefs.SetInt("CurrentMoverSteps",(PlayerPrefs.GetInt("Pl2Steps")+PlayerPrefs.GetInt("steps"))));
			steps_p2+=PlayerPrefs.GetInt("steps");
			Debug.Log("Steps"+steps_p2);
		}
		if (PlayerPrefs.GetString ("CurrentMover") == "Player3") {
			PlayerPrefs.GetInt("steps");
//			PlayerPrefs.SetInt("CurrentMoverSteps",(PlayerPrefs.GetInt("Pl3Steps")+PlayerPrefs.GetInt("steps")));
//			Debug.Log("ALALALAL "+PlayerPrefs.SetInt("CurrentMoverSteps",(PlayerPrefs.GetInt("Pl3Steps")+PlayerPrefs.GetInt("steps"))));
			steps_p3+=PlayerPrefs.GetInt("steps");
			Debug.Log("Steps"+steps_p3);
		}
		//	Debug.Log(PlayerPrefs.GetString ("CurrentMover")+" ... "+PlayerPrefs.GetInt("CurrentMoverSteps"));


				        
	}
*/

}