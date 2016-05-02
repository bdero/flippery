using UnityEngine;
using System.Collections;

public class followcam : MonoBehaviour {
	public GameObject follow;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = follow.transform.position + offset;
	}
}
