using UnityEngine;
using System.Collections;

public class BabyScript : MonoBehaviour {
	
	float blood = 100f;
	float wall	= 1.2f;
	float metaBlood = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		var pos1 = GameObject.Find("Sphere1").transform.position;
		var pos2 = GameObject.Find("Sphere2").transform.position;
		transform.position = new Vector3 ((pos1.x + pos2.x) / 2f, (pos1.y + pos2.y) / 2f, (pos1.z + pos2.z) / 2f);
		if (transform.position.x > wall)
			transform.position = new Vector3(wall,transform.position.y,transform.position.z);
		if (transform.position.x < -wall)
			transform.position = new Vector3(-wall,transform.position.y,transform.position.z);
	}


	void OnCollisionStay2D (Collision2D col)
	{
		blood -= metaBlood * Time.deltaTime;
		Debug.Log (blood);
		
	}
}
