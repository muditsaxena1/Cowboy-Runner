using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	private Animator anim;



	void Awake () {
		anim = GetComponent<Animator>();
	}


	void OnCollisionEnter2D (Collision2D target) {
		if(target.gameObject.tag == "Obstacle"){
			anim.Play("Player Idle");
		}
	}

	void OnCollisionExit2D (Collision2D target) {
		if(target.gameObject.tag == "Obstacle"){
			anim.Play("Player Run");
		}
	}
}
