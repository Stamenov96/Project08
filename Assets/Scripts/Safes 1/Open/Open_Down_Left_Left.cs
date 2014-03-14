using UnityEngine;
using System.Collections;

public class Open_Down_Left_Left : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				Down_Left_Left obj = hit.collider.GetComponent<Down_Left_Left>();
				if(obj)
				{
					obj.TrigerInteraction();
					
				}
			}
		}
	}
}
