using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game attributes for this object
/// </summary>
public class Attributes : MonoBehaviour {

	[Tooltip("Whether this object can be carried.")]
	public bool carriable = false;

	[Tooltip("Whether the blob can stick to this object.")]
	public bool sticky = false;

	[Tooltip("Whether this object does not ground characters.")]
	public bool unGroundable = false;

	[Tooltip("Whether this object is bait for enemies.")]
	public bool bait;

	[Tooltip("If the object should be subject to additional drag on a button.")]
	public bool slowOnButton;

	[Tooltip("The Color of this object (for buttons).")]
	public string color;

}
