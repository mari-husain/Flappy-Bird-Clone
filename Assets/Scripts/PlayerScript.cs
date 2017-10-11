using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

	// public variables - can be accessed via Inspector.
	public Vector2 vertical = new Vector2(0, 150);

	void FixedUpdate () {

		// jump when the spacebar is pressed.
		if (Input.GetKeyDown ("space")) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			GetComponent<Rigidbody2D> ().AddForce (vertical);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			die ();
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		die ();
	}

	void die () {
		Scene s = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (s.name);
	}
}
