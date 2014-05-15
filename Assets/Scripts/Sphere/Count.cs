using UnityEngine;
using System.Collections;

public class Count : MonoBehaviour {
	public GUIText count1;
	public GUIText count2;
	int a,b;
	bool isTrue = true;


	// Use this for initialization
	void Start () {
		a = 0;
		b = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(isTrue)
		b++;
		if (a == 0 && b == 9) {
						a = 1;
						b = 0;
				}
		if (a == 1 && b == 9) {
			a = 2;
			b = 0;
		}
		if (a == 2 && b == 9) {
			a = 3;
			b = 0;
		}
		if (a == 3 && b == 9) {
			a = 4;
			b = 0;
		}
		if (a == 4 && b == 9) {
			a = 5;
			b = 0;
		}
		if (a == 5 && b == 0) {
			a = 0;
			b = 1;
			isTrue = false;
		}
		count1.text = "" + a;
		count2.text = "" + b;

	}
}
