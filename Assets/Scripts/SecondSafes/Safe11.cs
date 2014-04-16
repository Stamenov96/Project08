using UnityEngine;

public class Safe11 : MonoBehaviour 
{
	
	public AudioClip open;
	public AudioClip X;
	public AudioClip V;
	public GUIText Text_11;	
	public GUIText sum;
	public float Seconds = 2;
	private int i;
	public int a,b,c,d;
	public int countingx;
	public int countingy;
	int[] arrayToRandom = new int[] { 1,1,2,2};

	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;
	
	void res11(){
		if(Screen.width==1366&&Screen.height==768){
			Text_11.transform.position = new Vector2(0.25f,0.685f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==720){
			Text_11.transform.position = new Vector2(0.25f,0.685f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
		if(Screen.width==640&&Screen.height==480){
			Text_11.transform.position = new Vector2(0.165f,0.685f);
			sum.transform.position = new Vector2 (0.345f,0.33f);
		}
		if(Screen.width==800&&Screen.height==600){
			Text_11.transform.position = new Vector2(0.165f,0.685f);
			sum.transform.position = new Vector2 (0.35f,0.33f);
		}
		if(Screen.width==512&&Screen.height==384){
			Text_11.transform.position = new Vector2(0.16f,0.685f);
			sum.transform.position = new Vector2 (0.3425f,0.33f);
		}
		if(Screen.width==1024&&Screen.height==768){
			Text_11.transform.position = new Vector2(0.165f,0.685f);
			sum.transform.position = new Vector2 (0.352f,0.33f);
		}
		if(Screen.width==640&&Screen.height==400){
			Text_11.transform.position = new Vector2(0.22f,0.685f);
			sum.transform.position = new Vector2 (0.37f,0.33f);	
		}
		if(Screen.width==1280&&Screen.height==600){
			Text_11.transform.position = new Vector2(0.29f,0.685f);
			sum.transform.position = new Vector2 (0.4075f,0.33f);
		}
		if(Screen.width==1280&&Screen.height==768){
			Text_11.transform.position = new Vector2(0.234f,0.685f);
			sum.transform.position = new Vector2 (0.38f,0.33f);
		}
		if (Screen.width == 1360 && Screen.height == 768) {
			Text_11.transform.position = new Vector2 (0.25f, 0.685f);
			sum.transform.position = new Vector2 (0.389f,0.33f);
		}
	}


void Start()
	{
		m_state = eInteractiveState.Inactive;

		while(a==b||c==d){
			a = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			b = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			c = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			d = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
		}
		Debug.Log (a + " " + b + " " + c + " " + d);
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
								if (a == 2) {
										res11 ();
										Text_11.text = "/2";
										if (animation.isPlaying) {
												audio.PlayOneShot (X);
										}
								} else {
										res11 ();
										Text_11.text = "x2";
										if (animation.isPlaying) {
												audio.PlayOneShot (V);
										}
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
				Text_11.text = " ";
				Seconds = 2;
				break;
				
			case eInteractiveState.Inactive:
				if(countingx==2||countingy==2)
					break;
				animation.Play ("OpenRR");
				if (a==2) {
					countingy++;		
					Debug.Log ("num of /2 : " + countingy);
					if(countingy==2){
						PlayerPrefs.SetInt("sum",(PlayerPrefs.GetInt("sum")/2));
						sum.text="GAME OVER: "+PlayerPrefs.GetInt("sum");
					}
				}
				else{

					countingx++;
					if(countingx==2){
						PlayerPrefs.SetInt("sum",(PlayerPrefs.GetInt("sum")*2));
						sum.text="YOU WON: "+PlayerPrefs.GetInt("sum");
						
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
