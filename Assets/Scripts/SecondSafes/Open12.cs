using UnityEngine;
using System.Collections;

public class Open12 : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				Safe12 obj = hit.collider.GetComponent<Safe12>();
				if(obj)
				{
					obj.TrigerInteraction();
					
				}
			}
		}
	}
}
