﻿using UnityEngine;
using System.Collections;

public class color4 : MonoBehaviour {
	
	public GameObject someGameObject;
	private Steps connection2;
	
	
	
	void Awake()
		
	{
		connection2 = someGameObject.GetComponent<Steps> ();
	}
	
	void Update () {
		if(connection2.steps_p1>=4){
			gameObject.renderer.material.color=Color.green;
		}
		
	}
	
}