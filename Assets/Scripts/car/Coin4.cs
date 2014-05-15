using UnityEngine;
using System.Collections;

public class Coin4 : MonoBehaviour {
	
	private int m_LastIndex;
	public float Seconds = 1;
	public GUIText Text_4;

	public GameObject otherGameObject;
	private Primary connect;
	
	
	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;

	void Awake()
		
	{
		connect = otherGameObject.GetComponent<Primary> ();
	}
	
	void Start(){
		Text_4.guiText.material.color = Color.black;
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
				
				if(connect.d==1){
					Text_4.text = PlayerPrefs.GetString("Player1Name");
				}
				if(connect.d==2){
					Text_4.text = PlayerPrefs.GetString("Player2Name");
				}
				if(connect.d==3){
					Text_4.text = PlayerPrefs.GetString("Player3Name");
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
				Text_4.text = " ";
				Seconds = 1;
				break;
				
			case eInteractiveState.Inactive:
				
				animation.Play ("Open1");
 
				m_state = eInteractiveState.Active;
				
				
				
				break;
			default:
				break;
			}
			
			
		}
		
	}
	
	
}
