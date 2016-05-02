using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float torqueSpeed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 torque = new Vector3 (Input.GetAxis ("Vertical"), 0f, -Input.GetAxis ("Horizontal"));
		rb.AddTorque (torque * torqueSpeed);
	}
}
