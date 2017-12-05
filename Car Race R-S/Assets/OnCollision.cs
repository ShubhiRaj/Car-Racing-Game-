﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {

	void OnCollisionEnter (Collision collision) {
		Debug.Log ("Enter Called");
	}

	void OnCollisionStay (Collision collision)
	{
		Debug.Log ("Stay");

	}

	void OnCollisionExit (Collision collision){
		Debug.Log ("Exit");
	}
		
}
