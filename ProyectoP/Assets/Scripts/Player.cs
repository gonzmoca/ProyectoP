using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 1f;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mov = new Vector3 (
			Input.GetAxisRaw ("Horizontal"),
			Input.GetAxisRaw ("Vertical"),
			0		
		);

		transform.position = Vector3.MoveTowards (
			transform.position,
			transform.position + mov,
			speed + Time.deltaTime
		);

		anim.SetFloat ("MovX", mov.x);
		anim.SetFloat ("MovY", mov.y);
		
	}
}

