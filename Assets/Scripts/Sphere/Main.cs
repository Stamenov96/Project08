using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public GUISkin Text;
	public GUISkin Buttons;


	public int count = 0;
	public int countDown= 0;
	public int countUp = 0;
	public int countUpDown = 0;
	public int price = 0;
	public int wrong = 0;
	public int right=0;
	private int check = 1;
	private int spacing = 100;
	private int buttonWidth = 128;
	private int buttonHeight = 32;


	public GUIText priceText;
	public GUIText wrongText;
	public GUIText winText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (right >= 9 && wrong !=0) {
			check=3;	
				count = 0;
				}
		Debug.Log (count);
		Debug.Log ("upanddown"+countUpDown);

		priceText.text = "Price: " + price;
		wrongText.text = "Wrong: " + wrong;

		if (wrong == 2) {
			check = 0;
			winText.text = "You win: " + price/2;
			PlayerPrefs.SetInt("sum",price/2);
		}
		if (price==100000||(price==90000 && wrong==1)) {
			winText.text = "You win: " + price;
			PlayerPrefs.SetInt("sum",price);
			check = 0;
		}

	}

	void OnGUI(){
		GUI.skin = Buttons;
		if (check == 2) {
			if ( GUI.Button(new Rect(Screen.width/2 - buttonWidth - 20, Screen.height/2 - buttonHeight/2 + spacing, buttonWidth, buttonHeight), "Less") ) {
								countDown++; 
								countUpDown++;
								check = 1;

						}
			if ( GUI.Button(new Rect(Screen.width/2 + 20 , Screen.height/2 - buttonHeight/2 + spacing, buttonWidth, buttonHeight), "Great") ) {
								countUp++; 
								countUpDown++;
							check = 1;
		
				}

		}
		if (check == 1) {
			if ( GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - buttonHeight/2 + spacing, buttonWidth, buttonHeight), "Stop") ) {
								count++; 
							check = 2;
						}

				}
		
	}
}
