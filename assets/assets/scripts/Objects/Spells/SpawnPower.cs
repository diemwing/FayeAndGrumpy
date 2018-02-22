using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// A characters special power that spawns an object, which they then pickup
/// </summary>
public class SpawnPower : MonoBehaviour
{

	/// <summary>
	/// The object to spawn when the player activates this power.
	/// </summary>
	[Tooltip("The object to spawn when the player activates this power.")]
	public GameObject spawnable;
	protected Character _character;
	protected GrabAndCarry _grabAndCarry;

	public bool onlySpawnOne = false;

	protected GameObject lastObjectSpawned;


	protected void Awake() {

		awakeRoutine();

	}

	/// <summary>
	/// The routine to run on Awake().
	/// </summary>
	protected virtual void awakeRoutine() {

		_character = GetComponent<Character>();
		_grabAndCarry = _character.GetComponent<GrabAndCarry>();

		if (!_grabAndCarry) {
			Destroy( this );
		}
	}

	void Update() {
//		Debug.Log(_character.controllingPlayer.powerButtonPressed);

		if (_character.controllingPlayer.powerButtonPressed) {
//		if (_character.controllingPlayer.powerButtonHeld) {
			Spawn();
		}
	}

	protected void Spawn() {

		GameObject newSpawn = Instantiate( spawnable, _character.transform.parent );

		// give to _grabAndCarry or destroy
		if (!_grabAndCarry.give( newSpawn )) {
			Destroy( newSpawn );
			// destroy other if only one should be spawned	
		} else if (onlySpawnOne) {
			if (lastObjectSpawned) {
				Destroy( lastObjectSpawned );
			}

			lastObjectSpawned = newSpawn;
		}
	}
}

