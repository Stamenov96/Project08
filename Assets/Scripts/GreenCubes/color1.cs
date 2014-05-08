using UnityEngine;
using System.Collections;

public class color1 : MonoBehaviour {

	public GameObject someGameObject;
	private Steps connection2;



	void Awake()
		
	{
		connection2 = someGameObject.GetComponent<Steps> ();
	}

	void Update () {
		if(connection2.steps_p1>=1){
			gameObject.renderer.material.color=Color.green;
		}

	}

}
