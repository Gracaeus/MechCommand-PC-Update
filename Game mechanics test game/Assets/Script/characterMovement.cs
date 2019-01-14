using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour {

	public float speed = 5f;
	private float xMove;
	private float yMove;
	public Rigidbody gameObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		xMove = Input.GetAxis("Vertical");
		yMove = Input.GetAxis("Horizontal");
	}

	void FixedUpdate()
	{
		MoveVertical();
		MoveHorizontal();
	}
	void MoveVertical()
	{
		Vector3 movement = transform.forward * xMove * speed * Time.deltaTime;

		gameObject.MovePosition(gameObject.position + movement);
	}
	void MoveHorizontal()
	{
		Vector3 movement = transform.right * yMove * speed * Time.deltaTime;

		gameObject.MovePosition(gameObject.position + movement);
	}

}
