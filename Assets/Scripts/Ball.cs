using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public float ballSpeed = 100.0f;
	private Rigidbody2D body;
	void Start ()
	{
		body = GetComponent<Rigidbody2D>();
		body.velocity = Vector2.up * ballSpeed;
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Racket")
		{
			float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);
			Vector2 dir = new Vector2(x, 1).normalized;
			GetComponent<Rigidbody2D>().velocity = dir * ballSpeed;
		}
	}
	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
	{
		return (ballPos.x - racketPos.x) / racketWidth;
	}
}
