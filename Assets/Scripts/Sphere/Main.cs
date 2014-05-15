using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public int count = 0;
	public int countDown= 0;
	public int countUp = 0;
	public int countUpDown = 0;
	public int price = 0;
	public int wrong = 0;
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
		if (count > 11)
			count = 0;
		Debug.Log (count);
		Debug.Log ("upanddown"+countUpDown);

		priceText.text = "Price: " + price;
		wrongText.text = "Wrong: " + wrong;

		if (wrong == 2) {
			check = 0;
			winText.text = "You win: " + price/2;
		}
		if (price == 100000) {
			winText.text = "You win: " + price;
			check = 0;
		}

	}

	void OnGUI(){
		if (check == 2) {
			if ( GUI.Button(new Rect(Screen.width/2 - buttonWidth - 20, Screen.height/2 - buttonHeight/2 + spacing, buttonWidth, buttonHeight), "Less") ) {
								countDown++; //tova mi e kato boolean nz shto sum go napravil s int ;d
								countUpDown++;
								check = 1;

						}
			if ( GUI.Button(new Rect(Screen.width/2 + 20 , Screen.height/2 - buttonHeight/2 + spacing, buttonWidth, buttonHeight), "Great") ) {
								countUp++; // i tva do tuk qsno li ti e shto gode da
								countUpDown++;
							check = 1;
		
				}

		}
		if (check == 1) {
			if ( GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - buttonHeight/2 + spacing, buttonWidth, buttonHeight), "Stop") ) {
								count++;
								//tuk v toq fail prosto si imam 3 butona i suotvetno 3 boqcha kum tqh 
							check = 2;
						}

				}
		
	}
}
