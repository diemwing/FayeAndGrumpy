using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectible : MakesNoise {


	/// <summary>
	/// The trigger associated with this collectible
	/// </summary>
//	private Collider2D _trigger;

	public bool shiny;

	void Start() {
//		_trigger = GetComponent<Collider2D>();
	}

	void FixedUpdate() {
		if (shiny) {
			shine();
		}
	}

	protected virtual void shine() {
//		transform. = MyUtilities.SineWave( 1, 1, 0, Time.time );
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		// call the child object's Collect script
		collect( other.gameObject );

		// play the pick up sound
		playNoise();

		// turn off things
		this.GetComponent<SpriteRenderer>().enabled = false;
		this.GetComponent<Collider2D>().enabled = false;
		this.enabled = false;
	}

	/// <summary>
	/// The effect of picking up this object
	/// </summary>
	/// <param name="other">The object picking up this item.</param>
	protected abstract void collect( GameObject other );
}
