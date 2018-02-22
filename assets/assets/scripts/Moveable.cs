using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An object which can be moved by other objects. 
/// Use this for when simply adding or setting the velocity isn't a valid solution.
/// </summary>
public class Moveable : MonoBehaviour {

	/// <summary>
	/// This object's rigidbody.
	/// </summary>
	protected Rigidbody2D _rigidbody;

	/// <summary>
	/// The movement vector for this frame.
	/// </summary>
	protected Vector2 _moveVector = Vector2.zero;

	// initialization
	void Awake () {
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	/// <summary>
	/// Moves the object.
	/// </summary>
	private void move(){
		_rigidbody.velocity += _moveVector;
		_moveVector = Vector2.zero;
	}


	/// <summary>
	/// Moves the object by a given vector
	/// </summary>
	/// <param name="moveVector">How to move the object.</param>
	public Vector2 moveVector {
		set{ _moveVector = value; }
	}
}
