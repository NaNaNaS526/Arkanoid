using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
	public float RacketSpeed = 100f;
	public string axis = "Horizontal";
	private Rigidbody2D body;
	void Start()
	{
		body = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate()
	{
		float v = Input.GetAxisRaw(axis);
		body.velocity = new Vector2(v, 0) * RacketSpeed;
	}
}
