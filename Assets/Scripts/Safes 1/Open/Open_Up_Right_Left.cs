using UnityEngine;
using System.Collections;

public class Open_Up_Right_Left : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				Up_Right_Left obj = hit.collider.GetComponent<Up_Right_Left>();
				if(obj)
				{
					obj.TrigerInteraction();
					
				}
			}
		}
	}
}
