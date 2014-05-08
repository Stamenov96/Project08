using UnityEngine;
using System.Collections;

public class snowMAN1 : MonoBehaviour {

public GameObject otherGameObject;
private Steps connect;
private	int a,b,c,d,e,f,g,h,i,j=0;



	void Awake(){

		connect = otherGameObject.GetComponent<Steps> ();
	}



	void Update(){
	if (connect.movement == true) {
						if (connect.steps_p1 == 1 && PlayerPrefs.GetInt ("steps") == 1) {

								if (a == 0) {
										animation.Play ("snow1");
										a++;
								}

						}
						if (connect.steps_p1 == 2 && PlayerPrefs.GetInt ("steps") == 1) {
			
								if (b == 0) {
										animation.Play ("snow2");
										b++;
								}
			
						}
						if (connect.steps_p1 == 3 && PlayerPrefs.GetInt ("steps") == 1) {
			
								if (c == 0) {
										animation.Play ("snow3");
										c++;
								}
			
						}
						if (connect.steps_p1 == 4 && PlayerPrefs.GetInt ("steps") == 1) {
			
								if (d == 0) {
										animation.Play ("snow4");
										d++;
								}
			
						}
						if (connect.steps_p1 == 5 && PlayerPrefs.GetInt ("steps") == 1) {
			
								if (e == 0) {
										animation.Play ("snow5");
										e++;
								}
			
						}
						if (connect.steps_p1 == 2 && PlayerPrefs.GetInt ("steps") == 2) {
			
								if (f == 0) {
										animation.Play ("snow6");
										f++;
								}
			
						}
						if (connect.steps_p1 == 3 && PlayerPrefs.GetInt ("steps") == 2) {
			
								if (g == 0) {
										animation.Play ("snow7");
										g++;
								}
			
						}
						if (connect.steps_p1 == 4 && PlayerPrefs.GetInt ("steps") == 2) {
			
								if (h == 0) {
										animation.Play ("snow8");
										h++;
								}
			
						}
						if (connect.steps_p1 == 5 && PlayerPrefs.GetInt ("steps") == 2) {
			
								if (i == 0) {
										animation.Play ("snow9");
										i++;
								}
			
						}
						if (connect.steps_p1 == 6 && PlayerPrefs.GetInt ("steps") == 2) {
			
								if (j == 0) {
										animation.Play ("snow5");
										j++;
								}
			
						}
				}

	}
	





}
