using UnityEngine;
using System.Collections;

public class Count5 : MonoBehaviour {
	public GameObject otherGameObject;
	private Main connectto;
	public GameObject otherGameObject1;
	private Count4 connectto1;
	public bool checkPrice=true;
	public bool checkWrong=true;
	public Material matirial1;
	public Material matirial2;
	public Material matirial3;
	public GameObject cube;
	
	
	public GUIText count1;
	
	public int a;
	bool chekStop = true;
	
	// Use this for initialization
	void Start () {
		a = 0;
		connectto = otherGameObject.GetComponent<Main> ();
		connectto1 = otherGameObject1.GetComponent<Count4> ();
		cube.renderer.material = matirial1;
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
		
		if (connectto.count == 5 && chekStop){
			chekStop = false;
			
			Debug.Log ("4 is: " + connectto1.a + " 5 is: " + a);
			
			if(connectto1.a > a && connectto.countDown == 1 && connectto.countUpDown == 7)
			{
				Debug.Log("Vqrno e e po malko ot d");
				connectto.countDown = 0;
				cube.renderer.material = matirial2;
				
				if(checkPrice){
					connectto.price = connectto.price + 10000;
					connectto.countUpDown++;
					checkPrice = false;
					connectto.right++;
				}
			}
			if(connectto1.a < a && connectto.countUp == 1 && connectto.countUpDown == 7)
			{
				Debug.Log("Vqrno e e po golqmo ot d");
				connectto.countUp = 0;
				cube.renderer.material = matirial2;
				if(checkPrice){
					connectto.price = connectto.price + 10000;
					connectto.countUpDown++;
					checkPrice = false;
					connectto.right++;
				}
			}
			if(connectto1.a > a && connectto.countUp == 1 && connectto.countUpDown == 7)
			{
				Debug.Log("Greshno e e po malko ot d");
				connectto.countUp = 0;
				cube.renderer.material = matirial3;
				if(checkWrong){
					connectto.wrong++;
					connectto.countUpDown++;
					checkWrong = false;
				}
			}
			if(connectto1.a < a && connectto.countDown == 1 && connectto.countUpDown == 7)
			{
				Debug.Log("Greshno e e po golqmo ot d");
				connectto.countDown = 0;
				cube.renderer.material = matirial3;
				if(checkWrong){
					connectto.wrong++;
					connectto.countUpDown++;
					checkWrong = false;
				}
			}
		}
		
		
	}
}
