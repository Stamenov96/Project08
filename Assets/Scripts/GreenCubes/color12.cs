﻿using UnityEngine;
using System.Collections;

public class color12 : MonoBehaviour {
	
	public GameObject someGameObject;
	private Steps connection2;
	
	
	
	void Awake()
		
	{
		connection2 = someGameObject.GetComponent<Steps> ();
	}
	
	void Update () {
		if(connection2.steps_p3>=2){
			gameObject.renderer.material.color=Color.red;
		}
		
	}
	
}
