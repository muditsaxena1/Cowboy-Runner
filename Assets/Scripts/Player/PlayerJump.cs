using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {

	[SerializeField]
	private AudioClip jumpClip;

	private float jumpForce = 12f, forwardForce = 0f;

	private Rigidbody2D myBody;

	private bool canJump;

	private Button jumpButton;

	void Awake () {
		myBody = GetComponent<Rigidbody2D>();

		jumpButton = GameObject.Find("Jump Button").GetComponent<Button>();

		jumpButton.onClick.AddListener(() => Jump());
	}


	public void Jump () {
		if (canJump){
			canJump = false;

			//AudioSource.PlayClipAtPoint(jumpClip, transform.position);

			if(transform.position.x < 0){
				forwardForce = 1f;	
			}
			else{
				forwardForce = 0f;
			}

			myBody.velocity = new Vector2(forwardForce, jumpForce);
		}

	}

	void Update(){
		if(Mathf.Abs(myBody.velocity.y) == 0){
			canJump = true;
		}
	}
}
