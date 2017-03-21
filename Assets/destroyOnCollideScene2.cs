using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class destroyOnCollideScene2 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		//renderer.enabled = false;
	}
	void OnTriggerEnter(Collider col){
		Destroy(gameObject);
		//Score.plscore++;
		GameObject.Find ("Plane").GetComponent<Score>().plscore ++;
		GameObject.Find ("Plane").GetComponent<Score>().scoreString = GameObject.Find ("Plane").GetComponent<Score>().plscore.ToString();
		if (GameObject.Find ("Plane").GetComponent<Score> ().plscore >= 3) {
			Application.LoadLevel (0);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
