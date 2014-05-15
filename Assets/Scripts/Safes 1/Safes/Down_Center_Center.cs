using UnityEngine;
using System.Collections;

public class Down_Center_Center : MonoBehaviour 
{



	public AudioClip open;
	public AudioClip openX;
	public AudioClip openV;
	public GUIText Text_8;
	public GUIText sum8;
	
	private float Seconds = 2;
	
	private int a;
	private int b;
	private int c;
	public int a1;
	public int b1;
	public int c1;
	public int x=0;
	public int sum = 0;
	public int count=0;
	public int reward1;
	public int reward2;
	public int reward3;
	public int reward4;
	public int reward5;
	public int reward6;
	public int reward7;
	int[] arrayToRandom = new int[] { 8000,5000,4000,3000,2000,1500,1000 };
	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;
	
	void res8()
	{
		if(Screen.width==1366&&Screen.height==768){
			Text_8.transform.position = new Vector2(0.538f,0.51f);
			sum8.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==720){
			Text_8.transform.position = new Vector2(0.538f,0.51f);
			sum8.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==640&&Screen.height==480){
			Text_8.transform.position = new Vector2(0.54f,0.514f);
			sum8.transform.position = new Vector2 (0.345f,0.33f);
		}
		if(Screen.width==800&&Screen.height==600){
			Text_8.transform.position = new Vector2(0.54f,0.514f);
			sum8.transform.position = new Vector2 (0.35f,0.33f);
		}
		if(Screen.width==512&&Screen.height==384){
			Text_8.transform.position = new Vector2(0.54f,0.514f);
			sum8.transform.position = new Vector2 (0.3425f,0.33f);
		}
		if(Screen.width==1024&&Screen.height==768){
			Text_8.transform.position = new Vector2(0.54f,0.514f);
			sum8.transform.position = new Vector2 (0.352f,0.33f);
		}
		if(Screen.width==640&&Screen.height==400){
			Text_8.transform.position = new Vector2(0.538f,0.514f);
			sum8.transform.position = new Vector2 (0.37f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==600){
			Text_8.transform.position = new Vector2(0.53f,0.514f);
			sum8.transform.position = new Vector2 (0.4075f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==768){
			Text_8.transform.position = new Vector2(0.54f,0.512f);
			sum8.transform.position = new Vector2 (0.38f,0.33f);
		}
		if(Screen.width==1360&&Screen.height==768){
			Text_8.transform.position = new Vector2(0.538f,0.512f);
			sum8.transform.position = new Vector2 (0.389f,0.33f);
		}
	
	
	
	
	}

	void Start()
	{
		m_state = eInteractiveState.Inactive;
		a = Random.Range (1, 10);
		b = Random.Range (1, 10);
		c = Random.Range (1, 10);	


		while (reward1==reward2||reward1==reward3||reward2==reward3||reward1==reward4||reward2==reward4||reward3==reward4||reward1==reward5||reward2==reward5||reward3==reward5||reward4==reward5||reward1==reward6||reward2==reward6||reward3==reward6||reward4==reward6||reward5==reward6||reward1==reward7||reward2==reward7||reward3==reward7||reward4==reward7||reward5==reward7||reward6==reward7) {
			reward1 = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			reward2 = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			reward3 = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			reward4 = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			reward5 = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			reward6 = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			reward7 = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
		}

		Debug.Log ("result is "+ reward1+" "+ reward2+" "+ reward3+" "+ reward4+" "+ reward5+" "+ reward6+" "+ reward7);
		while (a==b||a==b+1||b==a+1||b==c||b==c+1||c==b+1||a==c||c==a+1||a==c+1||a==b+5||b==a+5||b==c+5||c==b+5||c==a+5||a==c+5) {
			a = Random.Range (1, 10);
			b = Random.Range (1, 10);
			c = Random.Range (1, 10);
		}

		if (a > b && a > c)
			c1 = a;
		if (b > a && b > c)
			c1 = b;
		if (c > a && c > b)
		    c1 = c;
		if (a < b && a < c)
			a1 = a;
		if (b < a && b < c)
			a1 = b;
		if (c < a && c < b)
			a1 = c;
		if ((a > b && a < c)||(a > c && a < b))
			b1 = a;
		if ((b > a && b < c)||(b > c && b < a))
			b1 = b;
		if ((c > a && c < b)||(c > b && c < a))
			b1 = c;
		Debug.Log (a+""+b+""+c+"nai golqmoto e: "+c1+" "+"srednoto e: "+b1+" "+"nai malkoto e: "+a1);
		Debug.Log("Resolution is "+Screen.width+"x"+Screen.height);
	//	spas++;
	//	Debug.Log ("spas: " + spas);
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
				if(a1==8||b1==8||c1==8)
				{
					res8();
					Text_8.text = "X";
					if (animation.isPlaying) 
					{audio.PlayOneShot(openX);}
				}
				else 
				{
					if(a1==1)
					{
						res8();
						Text_8.text = ""+reward1;
					}
					if(a1==2)
					{
						res8();
						Text_8.text = ""+reward2;
					}					
					if(a1==3)
					{
						res8();
						Text_8.text = ""+reward3;
					}					
					if(a1==4)
					{
						res8();
						Text_8.text = ""+reward4;
					}					
					if(a1==5)
					{
						res8();
						Text_8.text = ""+reward5;
					}					
					if(a1==6)
					{
						res8();
						Text_8.text = ""+reward6;
					}					
					if(a1==7)
					{
						res8();
						Text_8.text = ""+reward7;
					}
					if (animation.isPlaying) 
					{audio.PlayOneShot(openV);}

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

				animation.Play ("CloseCC");
				m_state = eInteractiveState.Inactive;
				Text_8.text = " ";
				Seconds = 2;
				break;
				
			case eInteractiveState.Inactive:
				if(count==7||x==2)
					break;
				animation.Play ("OpenCC");
				if (a1 == 8 || b1 == 8 || c1 == 8) {
					x += 1;			
					Debug.Log ("num of X : " + x);
					if(x==2){
						sum8.text="GAME OVER: "+sum;
						Application.LoadLevel(0);
					}
				}
				else{
					if(a1==1){sum+=reward1;}
					if(a1==2){sum+=reward2;}
					if(a1==3){sum+=reward3;}
					if(a1==4){sum+=reward4;}
					if(a1==5){sum+=reward5;}
					if(a1==6){sum+=reward6;}
					if(a1==7){sum+=reward7;}
					Debug.Log("the sum is: "+sum);

					count+=1;
					if(count==7){
						sum8.text="YOU WON: "+sum;
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
