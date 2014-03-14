using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour 
{

	public AudioClip open;
	public GUIText winText;
	public float Seconds = 5;
	public float Minutes = 0;


	public enum eInteractiveState
	{
		Active, //Open
		Inactive,//Close
	}
	private eInteractiveState m_state;

	void Start()
	{
		m_state = eInteractiveState.Inactive;

	}

	void Update() 
	{
				if (m_state == eInteractiveState.Active) {
						if (Seconds <= 0) {
								Seconds = 2;
								if (Minutes >= 1) {
										Minutes--;
								} else {
										Minutes = 0;
										Seconds = 0;
								}
						} else {
								Seconds -= Time.deltaTime;
						}
						if (Seconds <= 0)
								winText.text = "1000";
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
				winText.text = " ";
				Seconds = 2;
				break;

			case eInteractiveState.Inactive:
				animation.Play ("Open");

				m_state = eInteractiveState.Active;

				//count = 1;


				break;
			default:
				break;
			}

			audio.PlayOneShot(open);
		}

	}
}
