using UnityEngine;
using System.Collections;

public class BarScript : MonoBehaviour {

	public float rotateSpeed = 90f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.back, rotateSpeed * Time.deltaTime);
	}
}
