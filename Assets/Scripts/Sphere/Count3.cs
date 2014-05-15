using UnityEngine;
using System.Collections;

public class Count3 : MonoBehaviour {
	public GameObject otherGameObject;
	private Main connectto;
	public GameObject otherGameObject1;
	private Count2 connectto2;
	
	
	public GUIText count1;
	int a;
	private bool checkStop = true;
	private bool checkPrice = true;
	private bool checkWrong = true;
	
	// Use this for initialization
	void Start () {
		a = 0;
	
		connectto = otherGameObject.GetComponent<Main> ();
		connectto2 = otherGameObject1.GetComponent<Count2> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(checkStop)
			a++;
		if (a == 50)
			a = 1;

		count1.text = "" + a;
		if (connectto.count == 3) {
			checkStop = false;
			
			Debug.Log ("2 is: " + connectto2.a + " 3 is: " + a);
			
			if(connectto2.a > a && connectto.countDown == 1)
			{
				Debug.Log("Vqrno c e po malko ot b");
				connectto.countDown = 0;
				if(checkPrice){
					connectto.price = connectto.price + 10000;
					checkPrice = false;
				}
			}
			if(connectto2.a < a && connectto.countUp == 1)
			{
				Debug.Log("Vqrno c e po golqmo ot b");
				connectto.countUp = 0;
				if(checkPrice){
					connectto.price = connectto.price + 10000;
					checkPrice = false;
				}
			}
			if(connectto2.a > a && connectto.countUp == 1)
			{
				Debug.Log("Greshno c e po malko ot b");
				connectto.countUp = 0;
				if(checkWrong){
					connectto.wrong++;
					checkWrong = false;
				}
			}
			if(connectto2.a < a && connectto.countDown == 1)
			{
				Debug.Log("Greshno c e po golqmo ot b");
				connectto.countDown = 0;
				if(checkWrong){
					connectto.wrong++;
					checkWrong = false;
				}
			}
		}

	}
}