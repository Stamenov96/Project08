﻿using UnityEngine;
using System.Collections;

public class Open_Up_Left_Right : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				Up_Left_Right obj = hit.collider.GetComponent<Up_Left_Right>();
				if(obj)
				{
					obj.TrigerInteraction();
					
				}
			}
		}
	}
}