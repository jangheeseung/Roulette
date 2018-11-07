using UnityEngine;
using System.Collections;

public class RouletteController : MonoBehaviour {
	float rotSpeed;

	// Use this for initialization
	void Start () {
		rotSpeed=0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			this.rotSpeed = 1;
		} else if (Input.GetMouseButton(0)) {
			this.rotSpeed *= 1.02f;
		} else {
			this.rotSpeed *= 0.96f;
		}
		transform.Rotate (0, 0, this.rotSpeed);

	}
}
