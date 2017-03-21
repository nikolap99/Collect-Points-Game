using UnityEngine;
using System.Collections;


public class Move : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);﻿
		if (transform.position.x >= 5.5) {
			//transform.position.x = 2;
			transform.position += new Vector3(-1,0,0);﻿
		}
		else if (transform.position.x <= -5.5) {
			//transform.position.x = 2;
			Debug.Log ("proso");
			transform.position += new Vector3(1,0,0);﻿
		}
		if (transform.position.y >= 4.2) {
			//transform.position.x = 2;
			Debug.Log ("proso");
			transform.position += new Vector3(0,-1,0);﻿
		}
		else if (transform.position.y <= -2) {
			//transform.position.x = 2;
			Debug.Log ("proso");
			transform.position += new Vector3(0,1,0);﻿
		}

	}

	void OnTriggerEnter(Collider col){
			//Destroy(gameObject);
	}
}
