using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float playerSpeed = 5.0f;

	// Use this for initialization
	void Start () {

		// Player Spawn Point
		transform.position = new Vector3 (9, -1, 6);

	}
	
	// Update is called once per frame
	void Update () {

		// Player Moving
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);
	
	}
}
