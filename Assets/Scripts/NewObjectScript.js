#pragma strict
var objectToSpawn : GameObject;
var waitTime = 4;
var shift = 4;

function Start () {
	while(true){
		var object: GameObject = Instantiate( objectToSpawn, Vector3(transform.position.x-shift,transform.position.y,transform.position.z), transform.rotation);
		var object2: GameObject = Instantiate( objectToSpawn, Vector3(transform.position.x+shift,transform.position.y,transform.position.z), transform.rotation);
		yield WaitForSeconds(waitTime);
	}
}

function Update () {


	
}