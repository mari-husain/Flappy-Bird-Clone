using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	public GameObject pipes;

	void Start () {
		InvokeRepeating ("CreateObstacle", 1f, 1f);
	}

	void CreateObstacle () {
		GameObject clonePipe = Instantiate (pipes);
	}
}
