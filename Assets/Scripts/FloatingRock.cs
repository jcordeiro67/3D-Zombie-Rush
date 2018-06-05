using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingRock : MyObject {

	public float travelSpeed = 2f;
	public float changeDirectionWait;

	[SerializeField] private Vector3 topPosition;
	[SerializeField] private Vector3 bottomPosition;

	// Use this for initialization
	void Start () {

		StartCoroutine(Move(transform.localPosition));
	}
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();
	}

	IEnumerator Move(Vector3 target){

		while (Mathf.Abs((target - transform.localPosition).y) > 0.20f) {

			Vector3 direction = target.y == topPosition.y ? Vector3.up : Vector3.down;
			transform.localPosition += direction * travelSpeed* Time.deltaTime;

			yield return null;
		}

		print("Reached the Target"); 
		yield return new WaitForSeconds(changeDirectionWait);

		Vector3 newTarget = target.y == topPosition.y ? bottomPosition : topPosition;

		StartCoroutine(Move(newTarget));
	}
}
