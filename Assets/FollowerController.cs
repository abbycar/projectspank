using UnityEngine;
using System.Collections;

public class FollowerController : MonoBehaviour {
	
	public bool jump = false;
	
	public float PlayerSpeed;
	public float MaxSpeed;
	public float JumpForce;
	public bool OnGround;
	

	// Use this for initialization
	void Start () {
		OnGround = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		//		float moveVertical = Input.GetAxis("Vertical");
		//		float moveHorizontal = Input.GetAxis("Horizontal");
		
		
		//		Vector2 controlMovement = new Vector2(moveHorizontal * PlayerSpeed, moveVertical);
		
		//		rigidbody2D.AddForce(controlMovement);

		PlayerController Leader = GetComponent<PlayerController> ();
		if (Mathf.Abs (Leader.transform.position.x - this.transform.position.x) > 5) {
			rigidbody2D.AddForce(new Vector2(0f, JumpForce));
		}

	}
	
	void FixedUpdate() {
		float h = Input.GetAxis ("Horizontal");
		
		if (h * rigidbody2D.velocity.x < MaxSpeed) {
			rigidbody2D.AddForce(Vector2.right * h * PlayerSpeed);
		}
//		
//		if (Mathf.Abs (rigidbody2D.velocity.x) > MaxSpeed) {
//			rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * MaxSpeed, rigidbody2D.velocity.y);
//		}
//		
//		if (jump) {
//			rigidbody2D.AddForce(new Vector2(0f, JumpForce));
//			
//			jump = false;
//		}
	}
}
