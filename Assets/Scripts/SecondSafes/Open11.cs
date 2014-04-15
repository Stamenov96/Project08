using UnityEngine;
using System.Collections;

public class Open11 : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
			 Safe11 obj = hit.collider.GetComponent<Safe11>();
				if(obj)
				{
					obj.TrigerInteraction();
					
				}
			}
		}
	}
}
