using UnityEngine;
using System.Collections;

public class Count2 : MonoBehaviour {
	public GameObject otherGameObject;
	private Main connectto;
	public GameObject otherGameObject1;
	private Count1 connectto1;
	private bool checkPrice=true;
	private bool checkWrong=true;
	
	
	public GUIText count1;

	public int a;
	bool chekStop = true;
	
	// Use this for initialization
	void Start () {
		a = 0;
		connectto = otherGameObject.GetComponent<Main> ();
		connectto1 = otherGameObject1.GetComponent<Count1> ();
	}
	
	// Update is called once per frame
	void Update () {// ne mislq po-skoro ak nqkva shit-nq ot update-a
		Debug.Log ("Price: "+connectto.price+" Wrong: "+ connectto.wrong);
		if (chekStop)
			a++;
		if (a == 50)
			a = 1;
		// do tuk sushtoto qsno 
		count1.text = "" + a;

		if (connectto.count == 2) {
						chekStop = false;
						
						Debug.Log ("1 is: " + connectto1.a + " 2 is: " + a);
						
						if(connectto1.a > a && connectto.countDown == 1)
						{
							Debug.Log("Vqrno b e po malko ot a");
							connectto.countDown = 0;
							if(checkPrice){
								connectto.price = connectto.price + 10000;
								checkPrice = false;
							}
						}
						if(connectto1.a < a && connectto.countUp == 1)
						{
							Debug.Log("Vqrno b e po golqmo ot a");
							connectto.countUp = 0;
							if(checkPrice){
								connectto.price = connectto.price + 10000;
								checkPrice = false;
							}
						}
						if(connectto1.a > a && connectto.countUp == 1)
						{
							Debug.Log("Greshno b e po malko ot a");
							connectto.countUp = 0;
							if(checkWrong){
								connectto.wrong++;
								checkWrong = false;
							}
						}
						if(connectto1.a < a && connectto.countDown == 1)
						{
							Debug.Log("Greshno b e po golqmo ot a");
							connectto.countDown = 0;
							if(checkWrong){
								connectto.wrong++;
								checkWrong = false;
							}
						}
				}


	}
}