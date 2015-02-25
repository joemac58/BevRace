using UnityEngine;
using System.Collections;

public class ChaserController : MonoBehaviour {


	public float zMove;             // object's z movement: adjust in Inspector
	
	private float length;           // length of object
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		length = renderer.bounds.size.z * 2;
	}
	
	void OnTriggerEnter(Collider collisions)
	{

		//destroys the player
		Destroy (gameObject);
	}

	void FixedUpdate()
	{

		//use to determine if chaser moves forwards or backwards
		speed = Input.GetAxis ("Vertical");
				
		if (speed >= 0) 
			{
				zMove -= 0.1f;
			}

		if(speed < 0)
			{	
				zMove += 0.3f;
			}

		// apply a constant value to z velocity to
		// move towards or away from player
		rigidbody.velocity = new Vector3(0.0f, 0.0f, zMove);
		//set the range for the z position.
		rigidbody.position = new Vector3(rigidbody.position.x,rigidbody.position.y,Mathf.Clamp(rigidbody.position.z, -165, -95));


	}
}
