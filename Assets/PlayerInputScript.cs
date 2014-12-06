using UnityEngine;
using System.Collections;

public class PlayerInputScript : MonoBehaviour {
	float baseSpeed = 15.0F;
	float inputDeadSquare = 0.13F * 0.13F;
	
	void Start () {
	
	}
	
	void OnCollisionEnter (Collision collision){
		Debug.Log("Player Collision Enter");
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		float xAxis = Input.GetAxis ("Horizontal");
		float zAxis = Input.GetAxis ("Vertical");
		Vector3 direction = Vector3.zero;
		if(xAxis * xAxis + zAxis * zAxis > inputDeadSquare){
			direction.x += xAxis * baseSpeed * Time.deltaTime;
			direction.z += zAxis * baseSpeed * Time.deltaTime;
			transform.rotation = Quaternion.LookRotation(direction);
		}
		transform.position += direction;
	
	}
}
