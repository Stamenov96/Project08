using UnityEngine;
using System.Collections;

public class Coin8 : MonoBehaviour {
	
	private int m_LastIndex;
	public float Seconds = 1;
	public GUIText Text_8;
	public GUIText Win;
 	public GameObject otherGameObject;
	public GameObject otherGameObject1;
	private Primary connect;
	private Steps connect1;
	
	
	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;

	void Awake()

	{
		connect = otherGameObject.GetComponent<Primary> ();
		connect1 = otherGameObject1.GetComponent<Steps> ();
	}
	
	void Start(){
		Text_8.guiText.material.color = Color.black;
		m_state = eInteractiveState.Inactive;
	}
	
	void Update() 
	{
		if (m_state == eInteractiveState.Active) {
			if (Seconds <= 0) {
				Seconds = 1;
				
			} else {
				Seconds -= Time.deltaTime;
			}
			if (Seconds <= 0) {
				
				if(connect.h==1){
					Text_8.text = PlayerPrefs.GetString("Player1Name");
				}
				if(connect.h==2){
					Text_8.text = PlayerPrefs.GetString("Player2Name");
				}
				if(connect.h==3){
					Text_8.text = PlayerPrefs.GetString("Player3Name");
				}
				
			}
		}
	}
	
	public void PlayCoinAnimation (){
	if (connect1.Coin) {
						if (!animation.isPlaying) {
								Debug.Log ("Interactive object");
								switch (m_state) {
								case eInteractiveState.Active:
										m_state = eInteractiveState.Inactive;
										Text_8.text = " ";
										Seconds = 1;
										break;
				
								case eInteractiveState.Inactive:
				
										animation.Play ("Open1");
										if (connect.h == 1) {
												connect1.movement = true;
												PlayerPrefs.SetString ("CurrentMover", "Player1");
												connect1.steps_p1 += PlayerPrefs.GetInt ("steps");
												Debug.Log ("Steps" + connect1.steps_p1);
												if (connect1.steps_p1 >= 5) {
														Win.text = PlayerPrefs.GetString ("Player1Name") + " win!";
														connect1.Coin=false;
														connect1.isButtonsVisible=false;
												}
										}
										if (connect.h == 2) {
												connect1.movement2 = true;
												PlayerPrefs.SetString ("CurrentMover", "Player2");
												connect1.steps_p2 += PlayerPrefs.GetInt ("steps");
												Debug.Log ("Steps2" + connect1.steps_p2);
												if (connect1.steps_p2 >= 5) {
														Win.text = PlayerPrefs.GetString ("Player2Name") + " win!";
														connect1.Coin=false;
														connect1.isButtonsVisible=false;
												}
										}
										if (connect.h == 3) {
												connect1.movement3 = true;
												PlayerPrefs.SetString ("CurrentMover", "Player3");
												connect1.steps_p3 += PlayerPrefs.GetInt ("steps");
												Debug.Log ("Steps3" + connect1.steps_p3);
												if (connect1.steps_p3 >= 5) {
														Win.text = PlayerPrefs.GetString ("Player3Name") + " win!";
														connect1.Coin=false;
														connect1.isButtonsVisible=false;
												}
										}
										Debug.Log ("CurRrent Mover .. : " + PlayerPrefs.GetString ("CurrentMover") + " steps " + PlayerPrefs.GetInt ("steps"));
				
 
				
										m_state = eInteractiveState.Active;
				
										connect1.isButtonsVisible = true;

				
										break;
								default:
										break;
								}
			
			
						}
			connect1.Coin=false;
				}	
	}
	
	
}
