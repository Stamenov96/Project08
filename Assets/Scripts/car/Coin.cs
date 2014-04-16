using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	private int m_LastIndex;
	public float Seconds = 1;
	public GUIText Text_1;
	

	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;

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
			
					Text_1.text = "Player1";
				
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

				
				m_state = eInteractiveState.Active;
				
				
				
				break;
			default:
				break;
			}
			
	
		}

	}

		
}
