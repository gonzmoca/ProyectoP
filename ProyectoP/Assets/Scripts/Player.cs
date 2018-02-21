using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 1f;
	Animator anim;
	//bool enMovimiento = false;
	Rigidbody2D rigit;
	Vector2 mov;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rigit = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Alpha1)) {
			anim.SetBool ("atack", true);
		} else {
			anim.SetBool ("atack", false);
		}

		mov = new Vector2 (
			Input.GetAxisRaw("Horizontal"),
			Input.GetAxisRaw("Vertical")
		);

		if (mov != Vector2.zero) {
			anim.SetBool ("Walk", true);
			//Restruccion a sin diagonales
			if (Input.GetAxisRaw ("Horizontal") != 0) {
				mov = new Vector2 (
					Input.GetAxisRaw ("Horizontal"),
					0
				);
			} else if (Input.GetAxisRaw ("Vertical") != 0) {
				mov = new Vector2 (
					0,
					Input.GetAxisRaw ("Vertical")
				);
			}

			//Movimiento con diagonales
			/*mov = new Vector2 (
				Input.GetAxisRaw("Horizontal"),
				Input.GetAxisRaw("Vertical")
			);*/
			anim.SetFloat ("movX", mov.x);
			anim.SetFloat ("movY", mov.y);
		} else {
			anim.SetBool ("Walk", false);
		}



	}


	void FixedUpdate (){
		
		rigit.MovePosition (rigit.position + mov * speed * Time.deltaTime);
	}
}

