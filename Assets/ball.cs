using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour {

	public int speed = 20;

	void Start () {
		Rigidbody2D body = GetComponent<Rigidbody2D>();

		Vector2 vector;

		if (Random.RandomRange (0, 2) == 0) {
			vector = new Vector2 (1.0f * speed, Random.Range(-0.5f, 0.5f) * speed);
		} else {
			vector = new Vector2 (-1.0f * speed, Random.Range(-0.5f, 0.5f) * speed);

		}
		body.velocity = vector;
	
	}
}
