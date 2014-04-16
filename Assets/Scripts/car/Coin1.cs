using UnityEngine;
using System.Collections;

public class Coin1 : MonoBehaviour {

	
	private int m_LastIndex;
	public float Seconds = 1;
	public GUIText Text_1;
	
	public GameObject otherGameObject;
	public GameObject otherGameObject1;
	private Primary connect;
//	private MenuCar connect1;

	//string Name1 = "ssss";
	

	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;


	void Awake()

	{
		connect = otherGameObject.GetComponent<Primary> ();
//		connect1 = otherGameObject1.GetComponent<MenuCar> ();
	}

	
	void Start(){
		Text_1.guiText.material.color = Color.black;
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
				if(connect.a==1){
					Text_1.text = PlayerPrefs.GetString("Player1Name");
				}
				if(connect.a==2){
					Text_1.text = PlayerPrefs.GetString("Player3Name");
				}
				if(connect.a==3){
					Text_1.text = PlayerPrefs.GetString("Player3Name");
				}
			}
		}
	}
	
	public void PlayCoinAnimation (){
		if (!animation.isPlaying) 
		{
			Debug.Log ("Interactive object");
			switch (m_state) 
			{
			case eInteractiveState.Active:
				m_state = eInteractiveState.Inactive;
				Text_1.text = " ";
				Seconds = 1;
				break;
				
			case eInteractiveState.Inactive:
				
				animation.Play ("Open1");
				connect.coinscounter++;
				if(connect.coinscounter==15){
					Application.LoadLevel(4);
				}
				
				m_state = eInteractiveState.Active;
				
				
				
				break;
			default:
				break;
			}
			
			
		}
		
	}
	
	
}
