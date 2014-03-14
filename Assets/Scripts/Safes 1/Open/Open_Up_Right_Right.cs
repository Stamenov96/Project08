using UnityEngine;
using System.Collections;

public class Open_Up_Right_Right : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				Up_Right_Right obj = hit.collider.GetComponent<Up_Right_Right>();
				if(obj)
				{
					obj.TrigerInteraction();
					
				}
			}
		}
	}
}
