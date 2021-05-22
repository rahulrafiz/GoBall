
using UnityEngine;
using System.Collections;

public class ymove : MonoBehaviour
{

	public float sx, sy;
	float axce=.05f;
	float p;

	void Update()
	{
		float x = sx * (Time.deltaTime);
		float y = sy * (Time.deltaTime);

		//Debug.Log (transform.position.x);
		//Debug.Log (transform.position.y);
		if (transform.position.y > 5f) {
			Vector3 temp;
			p = Random.Range(-8, 8);
			temp.x=p;
			temp.y=-5f;
			temp.z=transform.position.z;
			transform.position=temp;

			sy = sy+axce;
        }
        
		transform.Translate(x, y, 0);
	}
}