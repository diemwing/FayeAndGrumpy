using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWhenMoving : MonoBehaviour {

	Rigidbody2D _rigidbody;

	[Range(0,1)]
	public float drag;
	public float spinSpeed;

	// Use this for initialization
	void Awake () {
		_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (drag != 0) {
			_rigidbody.velocity *= 1 / drag;
		}

		_rigidbody.angularVelocity = _rigidbody.velocity.x * - spinSpeed;
	}
}
