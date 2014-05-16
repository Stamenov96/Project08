using UnityEngine;
using System.Collections;

public class Count3 : MonoBehaviour {
	public GameObject otherGameObject;
	private Main connectto;
	public GameObject otherGameObject1;
	private Count2 connectto1;
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
		connectto1 = otherGameObject1.GetComponent<Count2> ();
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
		
		if (connectto.count == 3 && chekStop){
			chekStop = false;
			
			Debug.Log ("2 is: " + connectto1.a + " 3 is: " + a);
			
			if(connectto1.a > a && connectto.countDown == 1 && connectto.countUpDown == 3)
			{
				Debug.Log("Vqrno c e po malko ot b");
				connectto.countDown = 0;
				cube.renderer.material = matirial2;
				
				if(checkPrice){
					connectto.price = connectto.price + 10000;
					connectto.countUpDown++;
					checkPrice = false;
					connectto.right++;
				}
			}
			if(connectto1.a < a && connectto.countUp == 1 && connectto.countUpDown == 3)
			{
				Debug.Log("Vqrno c e po golqmo ot b");
				connectto.countUp = 0;
				cube.renderer.material = matirial2;
				if(checkPrice){
					connectto.price = connectto.price + 10000;
					connectto.countUpDown++;
					checkPrice = false;
					connectto.right++;
				}
			}
			if(connectto1.a > a && connectto.countUp == 1 && connectto.countUpDown == 3)
			{
				Debug.Log("Greshno c e po malko ot b");
				connectto.countUp = 0;
				cube.renderer.material = matirial3;
				if(checkWrong){
					connectto.wrong++;
					connectto.countUpDown++;
					checkWrong = false;
				}
			}
			if(connectto1.a < a && connectto.countDown == 1 && connectto.countUpDown == 3)
			{
				Debug.Log("Greshno c e po golqmo ot b");
				cube.renderer.material = matirial3;
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
