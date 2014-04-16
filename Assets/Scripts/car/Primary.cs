using UnityEngine;
using System.Collections;

public class Primary : MonoBehaviour {



	public int a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,a1,b1,c1;
	//public int coinscounter;
	int[] arrayToRandom = new int[] { 1,2,3 }; 

	void Start () {

		while (a==b||a==c||b==c||d==e||d==f||e==f||g==h||g==i||h==i||j==k||j==l||k==l||m==n||m==o||n==o) {
			a = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			b = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			c = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			d = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			e = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			f = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			g = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			h = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			i = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			j = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			k = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			l = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			m = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			n = arrayToRandom [Random.Range (0, arrayToRandom.Length)];
			o = arrayToRandom [Random.Range (0, arrayToRandom.Length)];


		}



		Debug.Log (a+" "+b+" "+c+" "+d+" "+e+" "+f+" "+g+" "+h+" "+i+" "+j+" "+k+" "+l+" "+m+" "+n+" "+o);
	}


}
