using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 1f;
	Animator anim;
	bool enMovimiento = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(!enMovimiento){
			if (Input.GetKey ("up") && !enMovimiento) {
				anim.SetBool ("movTop", true);
				enMovimiento = true;
				transform.position = new Vector3 (
					transform.position.x, 
					transform.position.y + speed * Time.deltaTime, 
					transform.position.z);
			} else {
				anim.SetBool ("movTop", false);
			}

			if(Input.GetKey("down") && !enMovimiento){
				anim.SetBool ("movBot", true);
				enMovimiento = true;
				transform.position = new Vector3 (
					transform.position.x, 
					transform.position.y - speed * Time.deltaTime, 
					transform.position.z);
			}else {
				anim.SetBool ("movBot", false);
			}

			if(Input.GetKey("right") && !enMovimiento){
				anim.SetBool ("movRight", true);
				enMovimiento = true;
				transform.position = new Vector3 (
					transform.position.x + speed * Time.deltaTime, 
					transform.position.y, 
					transform.position.z);
			}else {
				anim.SetBool ("movRight", false);
			}

			if(Input.GetKey("left") && !enMovimiento){
				anim.SetBool ("movLeft", true);
				enMovimiento = true;
				transform.position = new Vector3 (
					transform.position.x - speed * Time.deltaTime, 
					transform.position.y, 
					transform.position.z);
			}else {
				anim.SetBool ("movLeft", false);
			}

		}else{
			enMovimiento = false;
		}				
	}
}

