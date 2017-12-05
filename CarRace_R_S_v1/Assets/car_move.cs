using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_move : MonoBehaviour {


	void Start () {
		print ("Let us race!!!");
	}

	void Update () {
		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime*50, 0f, Input.GetAxis ("Vertical") * Time.deltaTime*50);
	}

	void OnCollisionEnter(Collision other) {
		
	}

}
