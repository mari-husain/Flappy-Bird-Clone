using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	// public variables - can be accessed via the Inspector.
	public Vector2 velocity = new Vector2(-1, 0);
	public float range;

	void Start () {
		range = Random.Range (-.5f, .5f);
		GetComponent<Rigidbody2D> ().velocity = velocity;
		transform.position = new Vector3 (transform.position.x, transform.position.y + range, -1);
	}

	void Update () {

	}
}
