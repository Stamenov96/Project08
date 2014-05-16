using UnityEngine;
using System.Collections;

public class Down_Right_Right : MonoBehaviour 
{
	
	public AudioClip open;
	public AudioClip X;
	public AudioClip V;
	public GUIText Text_10;	
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

	void resolution()
	{
		if(Screen.width==1366&&Screen.height==768){
			Text_10.transform.position = new Vector2(0.835f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==720){
			Text_10.transform.position = new Vector2(0.835f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==640&&Screen.height==480){
			Text_10.transform.position = new Vector2(0.935f,0.514f);
			sum.transform.position = new Vector2 (0.345f,0.33f);
		}
		if(Screen.width==800&&Screen.height==600){
			Text_10.transform.position = new Vector2(0.94f,0.514f);
			sum.transform.position = new Vector2 (0.35f,0.33f);
		}
		if(Screen.width==512&&Screen.height==384){
			Text_10.transform.position = new Vector2(0.94f,0.514f);
			sum.transform.position = new Vector2 (0.3425f,0.33f);
		}
		if(Screen.width==1024&&Screen.height==768){
			Text_10.transform.position = new Vector2(0.95f,0.514f);
			sum.transform.position = new Vector2 (0.352f,0.33f);
		}
		if(Screen.width==640&&Screen.height==400){
			Text_10.transform.position = new Vector2(0.87f,0.514f);
			sum.transform.position = new Vector2 (0.37f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==600){
			Text_10.transform.position = new Vector2(0.78f,0.514f);
			sum.transform.position = new Vector2 (0.4075f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==768){
			Text_10.transform.position = new Vector2(0.86f,0.512f);
			sum.transform.position = new Vector2 (0.38f,0.33f);
		}
		if(Screen.width==1360&&Screen.height==768){
			Text_10.transform.position = new Vector2(0.84f,0.512f);
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
				if(asd.a1==10||asd.b1==10||asd.c1==10)
				{
					resolution();
					Text_10.text = "X";
					if (animation.isPlaying) 
					{audio.PlayOneShot(X);}
					
				}
				else 
				{
					if(asd.c1==1)
					{
						resolution();
						Text_10.text = ""+asd.reward1;
					}
					if(asd.c1==2)
					{
						resolution();
						Text_10.text = ""+asd.reward2;
					}
					if(asd.c1==3)
					{
						resolution();
						Text_10.text = ""+asd.reward3;
					}
					if(asd.c1==4)
					{
						resolution();
						Text_10.text = ""+asd.reward4;
					}
					if(asd.c1==5)
					{
						resolution();
						Text_10.text = ""+asd.reward5;
					}
					if(asd.c1==6)
					{
						resolution();
						Text_10.text = ""+asd.reward6;
					}
					if(asd.c1==7)
					{
						resolution();
						Text_10.text = ""+asd.reward7;
					}


					if(asd.c1==8)
					{

						if(asd.a1==1)
						{
							resolution();
							Text_10.text = ""+asd.reward1;
						}
					if(asd.a1==2)
						{
							resolution();
							Text_10.text = ""+asd.reward2;
						}
					if(asd.a1==3)
						{
							resolution();
							Text_10.text = ""+asd.reward3;
						}
					if(asd.a1==4)
						{
							resolution();
							Text_10.text = ""+asd.reward4;
						}
					if(asd.a1==5)
						{
							resolution();
							Text_10.text = ""+asd.reward5;
						}
					if(asd.a1==6)
						{
							resolution();
							Text_10.text = ""+asd.reward6;
						}
					if(asd.a1==7)
						{
							resolution();
							Text_10.text = ""+asd.reward7;
						}

					}
					if(asd.c1==9)
					{
						
						if(asd.b1==1)
						{
							resolution();
							Text_10.text = ""+asd.reward1;
						}
						if(asd.b1==2)
						{
							resolution();
							Text_10.text = ""+asd.reward2;
						}
						if(asd.b1==3)
						{
							resolution();
							Text_10.text = ""+asd.reward3;
						}
						if(asd.b1==4)
						{
							resolution();
							Text_10.text = ""+asd.reward4;
						}
						if(asd.b1==5)
						{
							resolution();
							Text_10.text = ""+asd.reward5;
						}
						if(asd.b1==6)
						{
							resolution();
							Text_10.text = ""+asd.reward6;
						}
						if(asd.b1==7)
						{
							resolution();
							Text_10.text = ""+asd.reward7;
						}
						
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
				animation.Play ("ClosePivot");
				m_state = eInteractiveState.Inactive;
				Text_10.text = " ";
				Seconds = 2;
				break;
				
			case eInteractiveState.Inactive:
				if(asd.count==7||asd.x==2)
					break;
				animation.Play ("Open");
				if (asd.a1 == 10 || asd.b1 == 10 || asd.c1 == 10) {
					asd.x += 1;			
					Debug.Log ("num of X : " + asd.x);
					if(asd.x==2){
 						sum.text="GAME OVER: "+asd.sum;
 
					}
				}
				else{
					
					if(asd.c1==1){asd.sum+=asd.reward1;}
					if(asd.c1==2){asd.sum+=asd.reward2;}
					if(asd.c1==3){asd.sum+=asd.reward3;}
					if(asd.c1==4){asd.sum+=asd.reward4;}
					if(asd.c1==5){asd.sum+=asd.reward5;}
					if(asd.c1==6){asd.sum+=asd.reward6;}
					if(asd.c1==7){asd.sum+=asd.reward7;}
					if(asd.c1==8){
						if(asd.a1==1){asd.sum+=asd.reward1;}
						if(asd.a1==2){asd.sum+=asd.reward2;}
						if(asd.a1==3){asd.sum+=asd.reward3;}
						if(asd.a1==4){asd.sum+=asd.reward4;}
						if(asd.a1==5){asd.sum+=asd.reward5;}
						if(asd.a1==6){asd.sum+=asd.reward6;}
						if(asd.a1==7){asd.sum+=asd.reward7;}
					}
					if(asd.c1==9){
						if(asd.b1==1){asd.sum+=asd.reward1;}
						if(asd.b1==2){asd.sum+=asd.reward2;}
						if(asd.b1==3){asd.sum+=asd.reward3;}
						if(asd.b1==4){asd.sum+=asd.reward4;}
						if(asd.b1==5){asd.sum+=asd.reward5;}
						if(asd.b1==6){asd.sum+=asd.reward6;}
						if(asd.b1==7){asd.sum+=asd.reward7;}
						
					}
					PlayerPrefs.SetInt("sum",asd.sum);
					asd.count+=1;
					if(asd.count==7){
						sum.text="YOU WON: "+asd.sum;
						 
 
						
					}
					//Debug.Log("the sum is: "+asd.sum);
					//sum.text = ""+asd.sum;

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
