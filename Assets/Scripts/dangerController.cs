using UnityEngine;
using System.Collections;

public class dangerController : MonoBehaviour
{
    public float zMove;             // object's z movement: adjust in Inspector

    private float length;           // length of object

	//public bool isDrinking = false;
	public float speed;				// will be used to call speedUp or slowDown function

    // Use this for initialization
    void Start()
    {
        // fetch the object's length.  we'll use this to determine
        // if we've past our camera...
        length = renderer.bounds.size.z * 2;

		//determine if the enemy needs to speed up or slow down
		speed = Input.GetAxis ("Vertical");

		while (speed > 0)			//plus sign is being pressed				
			speedUp ();
		if (speed < 0) 			//minus sign is being pressed
			slowDown ();

    }
	
	//speed up the enemy
	void speedUp(){
		zMove -= 95;
		Debug.Log("speedUp function called");
		}

	//slow down the enemy
	void slowDown(){
		zMove += 25;
		//isDrinking = true;
		Debug.Log("slowDown function called");
		}

    // Fixed Update is our Physics update, use when moving rigidbodies...
    void FixedUpdate()
    {

        // apply a constant value to z velocity to
        // move towards or away from player
        rigidbody.velocity = new Vector3(0.0f, 0.0f, zMove);

        // if our object's length is past our camera, then...
        if (rigidbody.position.z < -length)
        {
            // delete our object
            Destroy(gameObject);
        }
    }
}
