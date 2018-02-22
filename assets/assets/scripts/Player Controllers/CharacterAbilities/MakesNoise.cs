using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakesNoise : MonoBehaviour
{


	public AudioClip sfx;

	protected AudioSource source;

	void Awake() {
		source = gameObject.AddComponent<AudioSource>();
		source.volume = 1;
		source.clip = sfx;
	}

	protected void playNoise() {

		if (sfx) {
			source.Play();
		}
	}
}

