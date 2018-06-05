using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour {

	[SerializeField] private float platformSpeed = 5f;

	[SerializeField] private float resetPosition = 51f;
	[SerializeField] private float startPosition = -36.62f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		transform.Translate(Vector3.right * (platformSpeed * Time.deltaTime));

		if (transform.localPosition.x >= resetPosition) {
			Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
