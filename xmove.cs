
using UnityEngine;
using System.Collections;

public class xmove : MonoBehaviour
{

	public float sx, sy;


	void Update()
	{
		float x = sx * (Time.deltaTime);
		float y = sy * (Time.deltaTime);

		//Debug.Log (transform.position.x);
		//Debug.Log (transform.position.y);
		if (transform.position.x > 13f) {
			Vector3 temp;
			temp.y=transform.position.y;
			temp.x=-13f;
			temp.z=transform.position.z;
			transform.position=temp;
		}
		transform.Translate(x, y, 0);
	}
}