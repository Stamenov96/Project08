using UnityEngine;
using System.Collections;

public class Down_Left_Right : MonoBehaviour 
{
	
	public AudioClip open;
	public AudioClip X;
	public AudioClip V;
	public GUIText Text_7;
	public GUIText sum;
	
	public float Seconds = 2;
	
	public GameObject otherGameObject;
	private Down_Center_Center asd;
	
	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;

	void res7(){

		if(Screen.width==1366&&Screen.height==768){
			Text_7.transform.position = new Vector2(0.389f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==720){
			Text_7.transform.position = new Vector2(0.389f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==640&&Screen.height==480){
			Text_7.transform.position = new Vector2(0.345f,0.51f);
			sum.transform.position = new Vector2 (0.345f,0.33f);
		}
		if(Screen.width==800&&Screen.height==600){
			Text_7.transform.position = new Vector2(0.35f,0.51f);
			sum.transform.position = new Vector2 (0.35f,0.33f);
		}
		if(Screen.width==512&&Screen.height==384){
			Text_7.transform.position = new Vector2(0.3425f,0.51f);
			sum.transform.position = new Vector2 (0.3425f,0.33f);
		}
		if(Screen.width==1024&&Screen.height==768){
			Text_7.transform.position = new Vector2(0.352f,0.51f);
			sum.transform.position = new Vector2 (0.352f,0.33f);
		}
		if(Screen.width==640&&Screen.height==400){
			Text_7.transform.position = new Vector2(0.37f,0.51f);
			sum.transform.position = new Vector2 (0.37f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==600){
			Text_7.transform.position = new Vector2(0.4075f,0.51f);
			sum.transform.position = new Vector2 (0.4075f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==768){
			Text_7.transform.position = new Vector2(0.38f,0.51f);		
			sum.transform.position = new Vector2 (0.38f,0.33f);
		}
		if(Screen.width==1360&&Screen.height==768){
			Text_7.transform.position = new Vector2(0.389f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
	
	
	
	}

	void Awake()
	{
		asd = otherGameObject.GetComponent<Down_Center_Center> ();
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
			if (Seconds <= 0)
			{
				if(asd.a1==7||asd.b1==7||asd.c1==7)
				{
					res7();
					Text_7.text = "X";
					if (animation.isPlaying) 
					{audio.PlayOneShot(X);}
					
				}
				else
				{
					res7();
					Text_7.text = ""+asd.reward7;
					if (animation.isPlaying) 
					{audio.PlayOneShot(V);}
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
				Text_7.text = " ";
				Seconds = 2;
				break;
				
			case eInteractiveState.Inactive:
				if(asd.count==7||asd.x==2)
					break;
				animation.Play ("OpenLR");
				if (asd.a1 == 7 || asd.b1 == 7 || asd.c1 == 7) {
					asd.x += 1;			
					Debug.Log ("num of X : " + asd.x);
					if(asd.x==2){
 						sum.text="GAME OVER: "+asd.sum;

						Application.LoadLevel(2);
					}
				}
				else{
					
					asd.sum+=asd.reward7;
					Debug.Log("the sum is: "+asd.sum);
					PlayerPrefs.SetInt("sum",asd.sum);
					asd.count+=1;
					if(asd.count==7){
						sum.text="YOU WON: "+asd.sum;
						 
						Application.LoadLevel(2);						
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
