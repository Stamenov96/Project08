using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {


	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;

	public string Name1;
	void Start () {
		Name1=PlayerPrefs.GetString("Player1Name");
	}
	
	void OnGUI(){
		Name1 = GUI.TextField (new Rect (130, 0, 128, 32), Name1);
		if (GUI.Button (new Rect (260, 0, 128, 32), "Save"))
			PlayerPrefs.SetString ("Player1Name", Name1);

	//	if (GUILayout.Button ("Toggle Buttons"))
	//		
	//					hideButtons = ! hideButtons;
	//	if (hideButtons) return;
	}

	public void TrigerInteraction()
	{
		
		if (!animation.isPlaying) 
		{
			Debug.Log ("Interactive object");
			switch (m_state) 
			{
			case eInteractiveState.Active:
				animation.Play ("snow1");
				m_state = eInteractiveState.Inactive;
				//Text_5.text = " ";
				//Seconds = 2;
				break;
				
			case eInteractiveState.Inactive:
			//	if(asd.count==7||asd.x==2)
			//		break;
				animation.Play ("snow2");
			/*	if (asd.a1 == 5 || asd.b1 == 5 || asd.c1 == 5) {
					asd.x += 1;			
					Debug.Log ("num of X : " + asd.x);
					if(asd.x==2){
						sum.text="GAME OVER: "+asd.sum;
						
 
					}
				}
				else{
					
					asd.sum+=asd.reward5;
					Debug.Log("the sum is: "+asd.sum);
					asd.count+=1;
					if(asd.count==7){
						sum.text="YOU WON: "+asd.sum;
						
 
						
					}
				}*/
				
				m_state = eInteractiveState.Active;
				
				
				
				break;
			default:
				break;
			}

		}
		
	}


}
