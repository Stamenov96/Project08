﻿using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public int count = 0;
	public int countDown= 0;
	public int countUp = 0;
	public int countUpDown = 0;
	public int price = 0;
	public int wrong = 0;

	public GUIText priceText;
	public GUIText wrongText;

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

	}

	void OnGUI(){
		if (GUI.Button (new Rect (300, 400, 128, 32), "Less")) {
			countDown++; //tova mi e kato boolean nz shto sum go napravil s int ;d
			countUpDown++;

		}
		if (GUI.Button (new Rect (500, 400, 128, 32), "Great")) {
			countUp++; // i tva do tuk qsno li ti e shto gode da
			countUpDown++;

		}
		if (GUI.Button (new Rect (400, 500, 128, 32), "Stop")) {
			count++;
			//tuk v toq fail prosto si imam 3 butona i suotvetno 3 boqcha kum tqh 
		}
		
	}
}
