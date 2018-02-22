using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDestroy : MonoBehaviour {

	public GameObject[] spawnObject;
	private Collider2D _spawnArea;

	// Use this for initialization
	void Start () {
		_spawnArea = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy() {
		if (spawnObject != null) {
			for( int i = 0; i < spawnObject.Length; i++ ) {
				float x = _spawnArea.bounds.center.x + _spawnArea.bounds.extents.x * Random.Range( -1, 1 );
				float y = _spawnArea.bounds.center.y + _spawnArea.bounds.extents.y * Random.Range( -1, 1 );

				Instantiate( spawnObject[ i ], new Vector2(x,y), Quaternion.identity );
			}
		}
	}
}
