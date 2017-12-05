using UnityEngine;
using System.Collections;

public class moving_script : MonoBehaviour {

	public float moveSpeed;
	public float rotateSpeed;
	private Rigidbody rbody;
	// Use this for initialization
	void Start () {

		moveSpeed = 20f;
		rotateSpeed = 5f;
		rbody = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		rbody.AddForce (0f,rotateSpeed * Input.GetAxis ("Horizontal"),moveSpeed*Input.GetAxis ("Vertical") * Time.deltaTime);
		transform.Translate (0f,0f,moveSpeed*Input.GetAxis ("Vertical") * Time.deltaTime);
		transform.Rotate (0f, rotateSpeed * Input.GetAxis ("Horizontal"), 0f);

	}
}
