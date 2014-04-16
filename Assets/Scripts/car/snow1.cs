using UnityEngine;
using System.Collections;

public class snow1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
/*	private void InputMovement(){
		if (Input.GetMouseButton (0)) {	
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast (ray.origin, ray.direction, out hit, Mathf.Infinity)) {
				Player1 obj = hit.collider.GetComponent<Player> ();
				if (obj) {
					obj.TrigerInteraction ();				
				}
			}
		}
	}
*/
}
