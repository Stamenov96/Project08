using UnityEngine;
using System.Collections;

public class Snowman2 : MonoBehaviour {
	
	public GameObject otherGameObject;
	private Steps connect;
	private	int a,b,c,d,e,f,g,h,i,j=0;
	
	
	
	void Awake(){
		
		connect = otherGameObject.GetComponent<Steps> ();
	}
	
	
	
	void Update(){
		if (connect.movement2 == true) {
			if (connect.steps_p2 == 1 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (a == 0) {
					animation.Play ("snow21");
					a++;
				}
				
			}
			if ( connect.steps_p2 == 2 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (b == 0) {
					animation.Play ("snow22");
					b++;
				}
				
			}
			if ( connect.steps_p2 == 3 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (c == 0) {
					animation.Play ("snow23");
					c++;
				}
				
			}
			if ( connect.steps_p2 == 4 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (d == 0) {
					animation.Play ("snow24");
					d++;
				}
				
			}
			if ( connect.steps_p2 == 5 && PlayerPrefs.GetInt ("steps") == 1) {
				
				if (e == 0) {
					animation.Play ("snow25");
					e++;
				}
				
			}
			if ( connect.steps_p2 == 2 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (f == 0) {
					animation.Play ("snow26");
					f++;
				}
				
			}
			if ( connect.steps_p2 == 3 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (g == 0) {
					animation.Play ("snow27");
					g++;
				}
				
			}
			if ( connect.steps_p2 == 4 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (h == 0) {
					animation.Play ("snow28");
					h++;
				}
				
			}
			if ( connect.steps_p2 == 5 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (i == 0) {
					animation.Play ("snow29");
					i++;
				}
				
			}
			if ( connect.steps_p2 == 6 && PlayerPrefs.GetInt ("steps") == 2) {
				
				if (j == 0) {
					animation.Play ("snow25");
					j++;
				}
				
			}
		}
		
	}
	
	
	
	
	
	
}
