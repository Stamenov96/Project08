using UnityEngine;
using System.Collections;

public class Open1 : MonoBehaviour 
{
	public int	OpenCoin1;
	public int 	OpenCoin2;
	public int 	OpenCoin3;
	public int 	OpenCoin4;
	public int 	OpenCoin5;
	public int 	OpenCoin6;
	public int 	OpenCoin7;
	public int 	OpenCoin8;
	public int 	OpenCoin9;
	public int 	OpenCoin10;
	public int 	OpenCoin11;
	public int 	OpenCoin12;
	public int 	OpenCoin13;
	public int 	OpenCoin14;
	public int 	OpenCoin15;


	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				Debug.Log ("hit");
				Coin1 obj1 = hit.collider.GetComponent<Coin1>();
				if(obj1)
				{
					obj1.PlayCoinAnimation();
					OpenCoin1 = 1;
				}

				Coin2 obj2 = hit.collider.GetComponent<Coin2>();
				if(obj2)
				{
					obj2.PlayCoinAnimation();
					OpenCoin2 = 1;
				}

				Coin3 obj3 = hit.collider.GetComponent<Coin3>();
				if(obj3)
				{
					obj3.PlayCoinAnimation();
					OpenCoin3 = 1;
				}

				Coin4 obj4 = hit.collider.GetComponent<Coin4>();
				if(obj4)
				{
					obj4.PlayCoinAnimation();
					OpenCoin4 = 1;
				}

				Coin5 obj5 = hit.collider.GetComponent<Coin5>();
				if(obj5)
				{
					obj5.PlayCoinAnimation();
					OpenCoin5 = 1;
				}

				Coin6 obj6 = hit.collider.GetComponent<Coin6>();
				if(obj6)
				{
					obj6.PlayCoinAnimation();
					OpenCoin6 = 1;
				}

				Coin7 obj7 = hit.collider.GetComponent<Coin7>();
				if(obj7)
				{
					obj7.PlayCoinAnimation();
					OpenCoin7 = 1;
				}

				Coin8 obj8 = hit.collider.GetComponent<Coin8>();
				if(obj8)
				{
					obj8.PlayCoinAnimation();
					OpenCoin8 = 1;
				}

				Coin9 obj9 = hit.collider.GetComponent<Coin9>();
				if(obj9)
				{
					obj9.PlayCoinAnimation();
					OpenCoin9 = 1;
				}

				Coin10 obj10 = hit.collider.GetComponent<Coin10>();
				if(obj10)
				{
					obj10.PlayCoinAnimation();
					OpenCoin10 = 1;
				}

				Coin11 obj11 = hit.collider.GetComponent<Coin11>();
				if(obj11)
				{
					obj11.PlayCoinAnimation();
					OpenCoin11 = 1;
				}

				Coin12 obj12 = hit.collider.GetComponent<Coin12>();
				if(obj12)
				{
					obj12.PlayCoinAnimation();
					OpenCoin12 = 1;
				}

				Coin13 obj13 = hit.collider.GetComponent<Coin13>();
				if(obj13)
				{
					obj13.PlayCoinAnimation();
					OpenCoin13 = 1;
				}

				Coin14 obj14 = hit.collider.GetComponent<Coin14>();
				if(obj14)
				{
					obj14.PlayCoinAnimation();
					OpenCoin14 = 1;
				}

				Coin15 obj15 = hit.collider.GetComponent<Coin15>();
				if(obj15)
				{
					obj15.PlayCoinAnimation();
					OpenCoin15 = 1;
				}

			}
		}
	}
}
