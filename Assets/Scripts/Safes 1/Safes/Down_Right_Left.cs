using UnityEngine;
using System.Collections;

public class Down_Right_Left : MonoBehaviour 
{
	
	public AudioClip open;
	public AudioClip X;
	public AudioClip V;
	public GUIText Text_9;
	public GUIText sum;
	public int x2;
	
	public float Seconds = 2;
	
	public GameObject otherGameObject;
	private Down_Center_Center asd;
	
	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;

	void res9(){

		if(Screen.width==1366&&Screen.height==768){
			Text_9.transform.position = new Vector2(0.682f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==720){
			Text_9.transform.position = new Vector2(0.682f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==640&&Screen.height==480){
			Text_9.transform.position = new Vector2(0.74f,0.514f);
			sum.transform.position = new Vector2 (0.345f,0.33f);
		}
		if(Screen.width==800&&Screen.height==600){
			Text_9.transform.position = new Vector2(0.742f,0.514f);
			sum.transform.position = new Vector2 (0.35f,0.33f);
		}
		if(Screen.width==512&&Screen.height==384){
			Text_9.transform.position = new Vector2(0.735f,0.514f);
			sum.transform.position = new Vector2 (0.3425f,0.33f);
		}
		if(Screen.width==1024&&Screen.height==768){
			Text_9.transform.position = new Vector2(0.742f,0.514f);
			sum.transform.position = new Vector2 (0.352f,0.33f);
		}
		if(Screen.width==640&&Screen.height==400){
			Text_9.transform.position = new Vector2(0.695f,0.514f);
			sum.transform.position = new Vector2 (0.37f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==600){
			Text_9.transform.position = new Vector2(0.652f,0.514f);
			sum.transform.position = new Vector2 (0.4075f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==768){
			Text_9.transform.position = new Vector2(0.695f,0.512f);
			sum.transform.position = new Vector2 (0.38f,0.33f);
		}
		if(Screen.width==1360&&Screen.height==768){
			Text_9.transform.position = new Vector2(0.685f,0.512f);
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
				if(asd.a1==9||asd.b1==9||asd.c1==9)
				{
					res9();
					Text_9.text = "X";

					if (animation.isPlaying) 
					{audio.PlayOneShot(X);}


					
				}
				else 
				{
					if(asd.b1==1)
					{
						res9();
						Text_9.text = ""+asd.reward1;
					}
					if(asd.b1==2)
					{
						res9();
						Text_9.text = ""+asd.reward2;
					}					
					if(asd.b1==3)
					{
						res9();
						Text_9.text = ""+asd.reward3;
					}					
					if(asd.b1==4)
					{
						res9();
						Text_9.text = ""+asd.reward4;
					}					
					if(asd.b1==5)
					{
						res9();
						Text_9.text = ""+asd.reward5;
					}					
					if(asd.b1==6)
					{
						res9();
						Text_9.text = ""+asd.reward6;
					}					
					if(asd.b1==7)
					{
						res9();
						Text_9.text = ""+asd.reward7;
					}
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
				animation.Play ("CloseRL");
				m_state = eInteractiveState.Inactive;
				Text_9.text = " ";
				Seconds = 2;
				break;
				
			case eInteractiveState.Inactive:
				if(asd.count==7||asd.x==2)
					break;
				animation.Play ("OpenRL");
				if (asd.a1 == 9 || asd.b1 == 9 || asd.c1 == 9) {
					asd.x += 1;			
					Debug.Log ("num of X : " + asd.x);
					if(asd.x==2){
 						sum.text="GAME OVER: "+asd.sum;
						Application.LoadLevel(0);
					}
				}
				else{
					
					if(asd.b1==1){asd.sum+=asd.reward1;}
					if(asd.b1==2){asd.sum+=asd.reward2;}
					if(asd.b1==3){asd.sum+=asd.reward3;}
					if(asd.b1==4){asd.sum+=asd.reward4;}
					if(asd.b1==5){asd.sum+=asd.reward5;}
					if(asd.b1==6){asd.sum+=asd.reward6;}
					if(asd.b1==7){asd.sum+=asd.reward7;}
					Debug.Log("the sum is: "+asd.sum);
					asd.count+=1;
					if(asd.count==7){
						sum.text="YOU WON: "+asd.sum;
						 
						Application.LoadLevel(0);
						
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
