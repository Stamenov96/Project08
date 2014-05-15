using UnityEngine;
using System.Collections;

public class Count1 : MonoBehaviour {
	public GameObject otherGameObject;
	private Main connectto;
	public GameObject cube;
	public Material matirial1;
	public Material matirial2;

	
	public GUIText count1;
	
	public int a;

	bool chek = true;
	
	// Use this for initialization
	void Start () {
		a = 0;
		connectto = otherGameObject.GetComponent<Main> ();
		cube.renderer.material = matirial1;
	}

	// Update is called once per frame
	void Update () {
		if(chek)
			a++;
		if (a == 50)
			a = 1;
		count1.text = "" + a;
		
		if (connectto.count == 1) {
			chek = false;
			cube.renderer.material = matirial2;
		}
	}
}