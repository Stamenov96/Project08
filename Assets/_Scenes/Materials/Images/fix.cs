using UnityEngine;
using System.Collections;

public class fix : MonoBehaviour
{
	public float m_NativeRatio = 1.3333333333333F;
	
	void Start ()
	{
		float currentRatio = (float)Screen.width / (float)Screen.height;
		Vector3 scale = transform.localScale;
		scale.x *= m_NativeRatio / currentRatio;
		transform.localScale = scale;
	}
	
}