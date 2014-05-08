using UnityEngine;
using System.Collections;

public class Snowman3 : MonoBehaviour {
	
	public GameObject otherGameObject;
	private Steps connect;
	private	int a,b,c,d,e,f,g,h,i,j=0;
	
	
	
	void Awake(){
		
		connect = otherGameObject.GetComponent<Steps> ();
	}
	
	
	
	void Update(){
		if (connect.movement3 == true) {
			if (connect.steps_p3 == 1 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (a == 0) {
					animation.Play ("snow31");
					a++;
				}
				
			}
			if ( connect.steps_p3 == 2 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (b == 0) {
					animation.Play ("snow32");
					b++;
				}
				
			}
			if ( connect.steps_p3 == 3 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (c == 0) {
					animation.Play ("snow33");
					c++;
				}
				
			}
			if ( connect.steps_p3 == 4 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (d == 0) {
					animation.Play ("snow34");
					d++;
				}
				
			}
			if ( connect.steps_p3 == 5 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (e == 0) {
					animation.Play ("snow35");
					e++;
				}
				
			}
			if ( connect.steps_p3 == 2 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (f == 0) {
					animation.Play ("snow36");
					f++;
				}
				
			}
			if ( connect.steps_p3 == 3 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (g == 0) {
					animation.Play ("snow37");
					g++;
				}
				
			}
			if ( connect.steps_p3 == 4 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (h == 0) {
					animation.Play ("snow38");
					h++;
				}
				
			}
			if ( connect.steps_p3 == 5 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (i == 0) {
					animation.Play ("snow39");
					i++;
				}
				
			}
			if ( connect.steps_p3 == 6 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (j == 0) {
					animation.Play ("snow35");
					j++;
				}
				
			}
		}
		
	}
	
	
	
	
	
	
}
