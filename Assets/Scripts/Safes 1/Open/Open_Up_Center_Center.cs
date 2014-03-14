using UnityEngine;
using System.Collections;

public class Open_Up_Center_Center : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				Up_Center_Center obj = hit.collider.GetComponent<Up_Center_Center>();
				if(obj)
				{
					obj.TrigerInteraction();
					
				}
			}
		}
	}
}
