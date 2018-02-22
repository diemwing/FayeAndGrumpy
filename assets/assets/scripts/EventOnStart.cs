using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnStart : MonoBehaviour {

	public GameEvent gameEvent;

	private bool activated = false;

	void Start() {
	}

	void LateUpdate() {
		if (!activated) {

			gameEvent.onActivation();
			activated = true;
		}

		gameEvent.onUpdate();
	}
}
