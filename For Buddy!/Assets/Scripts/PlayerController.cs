using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float sensitivity;

	private Rigidbody rb;

	//gets the rigidbody
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	//Movement control
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float lookLeft = Input.GetAxis ("Mouse X");
		float lookUp = Input.GetAxis ("Mouse Y");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
		//Vector3 rotation = new Vector3 (0, lookLeft, 0);
		//rb.AddTorque (rotation * sensitivity);
	}
}