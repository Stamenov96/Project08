using UnityEngine;
using System.Collections;

public class Open1 : MonoBehaviour 
{

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
				}

				Coin2 obj2 = hit.collider.GetComponent<Coin2>();
				if(obj2)
				{
					obj2.PlayCoinAnimation();
				}

				Coin3 obj3 = hit.collider.GetComponent<Coin3>();
				if(obj3)
				{
					obj3.PlayCoinAnimation();
				}

				Coin4 obj4 = hit.collider.GetComponent<Coin4>();
				if(obj4)
				{
					obj4.PlayCoinAnimation();
				}

				Coin5 obj5 = hit.collider.GetComponent<Coin5>();
				if(obj5)
				{
					obj5.PlayCoinAnimation();
				}

				Coin6 obj6 = hit.collider.GetComponent<Coin6>();
				if(obj6)
				{
					obj6.PlayCoinAnimation();
				}

				Coin7 obj7 = hit.collider.GetComponent<Coin7>();
				if(obj7)
				{
					obj7.PlayCoinAnimation();
				}

				Coin8 obj8 = hit.collider.GetComponent<Coin8>();
				if(obj8)
				{
					obj8.PlayCoinAnimation();
				}

				Coin9 obj9 = hit.collider.GetComponent<Coin9>();
				if(obj9)
				{
					obj9.PlayCoinAnimation();
				}

				Coin10 obj10 = hit.collider.GetComponent<Coin10>();
				if(obj10)
				{
					obj10.PlayCoinAnimation();
				}

				Coin11 obj11 = hit.collider.GetComponent<Coin11>();
				if(obj11)
				{
					obj11.PlayCoinAnimation();
				}

				Coin12 obj12 = hit.collider.GetComponent<Coin12>();
				if(obj12)
				{
					obj12.PlayCoinAnimation();
				}

				Coin13 obj13 = hit.collider.GetComponent<Coin13>();
				if(obj13)
				{
					obj13.PlayCoinAnimation();
				}

				Coin14 obj14 = hit.collider.GetComponent<Coin14>();
				if(obj14)
				{
					obj14.PlayCoinAnimation();
				}

				Coin15 obj15 = hit.collider.GetComponent<Coin15>();
				if(obj15)
				{
					obj15.PlayCoinAnimation();
				}

			}
		}
	}
}
