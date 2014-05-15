using UnityEngine;
using System.Collections;

public class Count1 : MonoBehaviour {
	public GameObject otherGameObject;
	private Main connectto;



	public GUIText count1;

	public int a;
	bool chek = true;
	
	// Use this for initialization
	void Start () {
		a = 0;
	
		connectto = otherGameObject.GetComponent<Main> ();

	}

	// Update is called once per frame
	void Update () {
				if (chek)
						a++;
				if (a == 50)
						a = 1;

				count1.text = "" + a;
				if (connectto.count == 1) {
						chek = false;
				} // tva tuk kakto ti kazah..  ako count ot toq fail mi e 1 demek ako e natisnato 1 put.. da spre 1viq
				// hahahhah ok :D shto haha? shot vmesto da go napraish kat bql chovek s bool go praish po nqkuv 
				// izvraten nachin s broqch :D e nishto ;d inache za stop-a nqma kak bez broqch shtoto ako mi e 2 trqa 2ri ako 3 3ti t.n. 
		// da da verno 
	}
}