using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float PlayerSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//float moveVertical = Input.GetAxis("Vertical");
		float moveHorizontal = Input.GetAxis("Horizontal");
		
		
		Vector2 controlMovement = new Vector2(moveHorizontal * PlayerSpeed, rigidbody2D.velocity.y);
		
		rigidbody2D.velocity = controlMovement;

	}
}
