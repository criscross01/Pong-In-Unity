using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

	public float speed;
	private float upLimit=4.4f;
	private float downLimit = -4.4f;

	Transform trans;

	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform> ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w") && trans.position.y < upLimit) {
			trans.Translate (0.0f, speed, 0.0f);
		} else if (Input.GetKey ("s") && trans.position.y > downLimit) {
			trans.Translate (0.0f, -speed, 0.0f);
		}
	}
}