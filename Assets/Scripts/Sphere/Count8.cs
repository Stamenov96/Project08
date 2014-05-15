using UnityEngine;
using System.Collections;

public class Count8 : MonoBehaviour {
	public GameObject otherGameObject;
	private Main connectto;
	public GameObject otherGameObject1;
	private Count7 connectto1;
	public bool checkPrice=true;
	public bool checkWrong=true;
	
	
	public GUIText count1;
	
	public int a;
	bool chekStop = true;
	
	// Use this for initialization
	void Start () {
		a = 0;
		connectto = otherGameObject.GetComponent<Main> ();
		connectto1 = otherGameObject1.GetComponent<Count7> ();
	}
	
	// Update is called once per frame
	void Update () {// ne mislq po-skoro ak nqkva shit-nq ot update-a
		//Debug.Log ("Price: "+connectto.price+" Wrong: "+ connectto.wrong);
		if (chekStop)
			a++;
		if (a == 50)
			a = 1;
		// do tuk sushtoto qsno 
		count1.text = "" + a;
		
		if (connectto.count == 8 && chekStop){
			chekStop = false;
			
			Debug.Log ("7 is: " + connectto1.a + " 8 is: " + a);
			
			if(connectto1.a > a && connectto.countDown == 1 && connectto.countUpDown == 13)
			{
				Debug.Log("Vqrno h e po malko ot g");
				connectto.countDown = 0;
				
				if(checkPrice){
					connectto.price = connectto.price + 10000;
					connectto.countUpDown++;
					checkPrice = false;
				}
			}
			if(connectto1.a < a && connectto.countUp == 1 && connectto.countUpDown == 13)
			{
				Debug.Log("Vqrno h e po golqmo ot g");
				connectto.countUp = 0;
				if(checkPrice){
					connectto.price = connectto.price + 10000;
					connectto.countUpDown++;
					checkPrice = false;
				}
			}
			if(connectto1.a > a && connectto.countUp == 1 && connectto.countUpDown == 13)
			{
				Debug.Log("Greshno h e po malko ot g");
				connectto.countUp = 0;
				if(checkWrong){
					connectto.wrong++;
					connectto.countUpDown++;
					checkWrong = false;
				}
			}
			if(connectto1.a < a && connectto.countDown == 1 && connectto.countUpDown == 13)
			{
				Debug.Log("Greshno h e po golqmo ot g");
				connectto.countDown = 0;
				if(checkWrong){
					connectto.wrong++;
					connectto.countUpDown++;
					checkWrong = false;
				}
			}
		}
		
		
	}
}
