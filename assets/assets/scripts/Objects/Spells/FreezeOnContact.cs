using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeOnContact : MonoBehaviour {

	public GameObject iceRaft;

	// when an object comes into contact with this object
	void OnCollisionEnter2D(Collision2D other) {
		BaseEnemy enemy = other.gameObject.GetComponent<BaseEnemy>();
		Water water = other.gameObject.GetComponent<Water>();

		if(enemy) {
			// freeze the enemy
			Destroy( this.gameObject );
		}

		// spawn an ice raft in water
		if (water) {
			Instantiate( iceRaft );
			Destroy( this.gameObject );
		}
	}

//	void OnDestroy(){}
}
