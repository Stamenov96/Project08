using UnityEngine;
using System.Collections;

public class Safe12 : MonoBehaviour 
{
	
	public AudioClip open;
	public AudioClip X;
	public AudioClip V;
	public GUIText Text_12;
	public GUIText sum;
	
	public float Seconds = 2;
	
	public GameObject otherGameObject;
	private Safe11 connection2;
	
	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;
	
	void res12(){
		
		if(Screen.width==1366&&Screen.height==768){
			Text_12.transform.position = new Vector2(0.389f,0.685f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==720){
			Text_12.transform.position = new Vector2(0.389f,0.685f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==640&&Screen.height==480){
			Text_12.transform.position = new Vector2(0.345f,0.685f);
			sum.transform.position = new Vector2 (0.345f,0.33f);
		}
		if(Screen.width==800&&Screen.height==600){
			Text_12.transform.position = new Vector2(0.35f,0.685f);
			sum.transform.position = new Vector2 (0.35f,0.33f);
		}
		if(Screen.width==512&&Screen.height==384){
			Text_12.transform.position = new Vector2(0.3425f,0.685f);
			sum.transform.position = new Vector2 (0.3425f,0.33f);
		}
		if(Screen.width==1024&&Screen.height==768){
			Text_12.transform.position = new Vector2(0.352f,0.685f);
			sum.transform.position = new Vector2 (0.352f,0.33f);
		}
		if(Screen.width==640&&Screen.height==400){
			Text_12.transform.position = new Vector2(0.37f,0.685f);
			sum.transform.position = new Vector2 (0.37f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==600){
			Text_12.transform.position = new Vector2(0.4075f,0.685f);
			sum.transform.position = new Vector2 (0.4075f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==768){
			Text_12.transform.position = new Vector2(0.38f,0.685f);
			sum.transform.position = new Vector2 (0.38f,0.33f);
		}
		if(Screen.width==1360&&Screen.height==768){
			Text_12.transform.position = new Vector2(0.389f,0.685f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		
		
	}
	
	void Awake()
	{
		connection2 = otherGameObject.GetComponent<Safe11> ();
	}
	
	void Start()
	{
		m_state = eInteractiveState.Inactive;	
	}
	
	void Update() 
	{
		if (m_state == eInteractiveState.Active) {
			if (Seconds <= 0) {
				Seconds = 2;
				
			} else {
				Seconds -= Time.deltaTime;
			}
			if (Seconds <= 0) {
				if (connection2.b==2) {
					res12 ();
					Text_12.text = "/2";
					if (animation.isPlaying) {
						audio.PlayOneShot (X);
					}
				} else {
					res12 ();
					Text_12.text = "x2";
					if (animation.isPlaying) 
					{audio.PlayOneShot (V);}
				}
			}
		}
	}
	public void TrigerInteraction()
	{
		
		if (!animation.isPlaying) 
		{
			Debug.Log ("Interactive object");
			switch (m_state) 
			{
			case eInteractiveState.Active:
				animation.Play ("CloseLR");
				m_state = eInteractiveState.Inactive;
				Text_12.text = " ";
				Seconds = 2;
				break;

			case eInteractiveState.Inactive:
				if(connection2.countingx==2||connection2.countingy==2)
					break;
				animation.Play ("OpenLR");
				if (connection2.b==2) {
					connection2.countingy++;		
					Debug.Log ("num of /2 : " + connection2.countingy);
					if(connection2.countingy==2){
						Debug.Log(""+PlayerPrefs.GetInt("sum"));
						PlayerPrefs.SetInt("sum",(PlayerPrefs.GetInt("sum")/2));
						sum.text="GAME OVER: "+PlayerPrefs.GetInt("sum");
						Application.LoadLevel(3);
					}
				}
				else{
					
					connection2.countingx++;
					if(connection2.countingx==2){
						PlayerPrefs.SetInt("sum",(PlayerPrefs.GetInt("sum")*2));
						sum.text="YOU WON: "+PlayerPrefs.GetInt("sum");
						
						Application.LoadLevel(3);
						
					}
				}

				m_state = eInteractiveState.Active;
				
				
				
				break;
			default:
				break;
			}
			
			audio.PlayOneShot(open);
		}
		
	}
}
