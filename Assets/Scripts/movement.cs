using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float torqueSpeed;
	public float movementSpeed;

	private Rigidbody rb;
	private bool colliding = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision collision) {
		colliding = true;
	}

	void OnCollisionExit(Collision collision) {
		colliding = false;
	}

	// Update is called once per frame
	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		if (colliding) {
			Vector3 torque = new Vector3 (y, 0f, -x);
			rb.AddTorque (torque * torqueSpeed);
		} else {
			Vector3 movement = new Vector3 (x, 0f, y);
			rb.AddForce (movement * movementSpeed);
		}
	}
}
