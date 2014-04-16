﻿using UnityEngine;
using System.Collections;

public class Coin15 : MonoBehaviour {
	
	private int m_LastIndex;
	public float Seconds = 1;
	public GUIText Text_15;

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
		Text_15.guiText.material.color = Color.black;
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
				
				if(connect.o==1){
					Text_15.text = PlayerPrefs.GetString("Player1Name");
				}
				if(connect.o==2){
					Text_15.text = PlayerPrefs.GetString("Player2Name");
				}
				if(connect.o==3){
					Text_15.text = PlayerPrefs.GetString("Player3Name");
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
				Text_15.text = " ";
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
