using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float playerSpeed = 5.0f;

	// Use this for initialization
	void Start () {

		// Player Spawn Point
		transform.position = new Vector3 (0, 3, 0);

	}
	
	// Update is called once per frame
	void Update () {

		// Player Moving
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);

		transform.Translate(Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
	
	}
}
