using UnityEngine;
using System.Collections;

public class Sphere2Script : MonoBehaviour {
	
	//	public float speed = 10f;
	//	public Vector2 maxVelocity = new Vector2(3, 5);
	
	public float metaSpeed = 0.1f;
	// Update is called once per frame
	void Update () {
		//		var forceX = 0f;
		//		var forceY = 0f;
		
		
		//		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		
		if (Input.GetKey ("right")) {
			
			//			if(absVelX < maxVelocity.x)
			//				forceX = speed;
			transform.position = new Vector3(transform.position.x+metaSpeed, transform.position.y, transform.position.z);
			
		} else if (Input.GetKey ("left")) {
			
			//			if(absVelX < maxVelocity.x)
			//				forceX = -speed;
			transform.position = new Vector3(transform.position.x-metaSpeed, transform.position.y, transform.position.z);
			
		}
		
		var absVelY = Mathf.Abs (rigidbody2D.velocity.y);
		
		if (Input.GetKey ("up")) {
			
			//			if(absVelY < maxVelocity.y)
			//				forceY = speed;
			transform.position = new Vector3(transform.position.x, transform.position.y+metaSpeed, transform.position.z);
			
		} else if (Input.GetKey ("down")) {
			
			//			if(absVelY < maxVelocity.y)
			//				forceY = -speed;
			transform.position = new Vector3(transform.position.x, transform.position.y-metaSpeed, transform.position.z);
		}
		
		//		rigidbody2D.AddForce (new Vector2 (forceX, forceY));
	}
}
