#pragma strict
var objectToSpawn : GameObject;
var waitTime = 4;
var shift = 4;
var randomNumber = 0;

function Start () {

	while(true){
		var object: GameObject = Instantiate( objectToSpawn, Vector3(transform.position.x-shift,transform.position.y,transform.position.z), transform.rotation);
		object.transform.Rotate (Vector3.back, Random.Range(-180,180));
		var object2: GameObject = Instantiate( objectToSpawn, Vector3(transform.position.x+shift,transform.position.y,transform.position.z), transform.rotation);
		object.transform.Rotate (Vector3.back, Random.Range(-180,180));
		yield WaitForSeconds(waitTime);
	}
}

function Update () {


	
}