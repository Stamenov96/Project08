using UnityEngine;
using System.Collections;

public class Down_Left_Left : MonoBehaviour 
{
	
	public AudioClip open;
	public AudioClip X;
	public AudioClip V;
	public GUIText Text_6;
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

	void res6()
	{
		if(Screen.width==1366&&Screen.height==768){
			Text_6.transform.position = new Vector2(0.24f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==720){
			Text_6.transform.position = new Vector2(0.24f,0.51f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==640&&Screen.height==480){
			Text_6.transform.position = new Vector2(0.15f,0.51f);
			sum.transform.position = new Vector2 (0.345f,0.33f);
		}
		if(Screen.width==800&&Screen.height==600){
			Text_6.transform.position = new Vector2(0.155f,0.51f);
			sum.transform.position = new Vector2 (0.35f,0.33f);
		}
		if(Screen.width==512&&Screen.height==384){
			Text_6.transform.position = new Vector2(0.145f,0.51f);
			sum.transform.position = new Vector2 (0.3425f,0.33f);
		}
		if(Screen.width==1024&&Screen.height==768){
			Text_6.transform.position = new Vector2(0.155f,0.51f);
			sum.transform.position = new Vector2 (0.352f,0.33f);
		}
		if(Screen.width==640&&Screen.height==400){
			Text_6.transform.position = new Vector2(0.205f,0.51f);
			sum.transform.position = new Vector2 (0.37f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==600){
			Text_6.transform.position = new Vector2(0.285f,0.51f);
			sum.transform.position = new Vector2 (0.4075f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==768){
			Text_6.transform.position = new Vector2(0.225f,0.51f);
			sum.transform.position = new Vector2 (0.38f,0.33f);
		}
		if(Screen.width==1360&&Screen.height==768){
			Text_6.transform.position = new Vector2(0.24f,0.51f);
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
				if(asd.a1==6||asd.b1==6||asd.c1==6)
				{
					res6();
					Text_6.text = "X";
					if (animation.isPlaying) 
					{audio.PlayOneShot(X);}

					
				}
				else
				{
					res6();
					Text_6.text = ""+asd.reward6;
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
				animation.Play ("CloseLL");
				m_state = eInteractiveState.Inactive;
				Text_6.text = " ";
				Seconds = 2;
				break;
				
			case eInteractiveState.Inactive:
				if(asd.count==7||asd.x==2)
					break;
				animation.Play ("OpenRR");
				if (asd.a1 == 6 || asd.b1 == 6 || asd.c1 == 6) {
					asd.x += 1;			
					Debug.Log ("num of X : " + asd.x);
					if(asd.x==2){
						sum.text="GAME OVER: "+asd.sum;
 
					}
				}
				else{
					asd.sum+=asd.reward6;
					Debug.Log("the sum is: "+asd.sum);
					PlayerPrefs.SetInt("sum",asd.sum);
					asd.count+=1;
					if(asd.count==7){
						sum.text="YOU WON: "+asd.sum;
					 
 
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
