using UnityEngine;
using System.Collections;

public class Open13 : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				Safe13 obj = hit.collider.GetComponent<Safe13>();
				if(obj)
				{
					obj.TrigerInteraction();
					
				}
			}
		}
	}
}
