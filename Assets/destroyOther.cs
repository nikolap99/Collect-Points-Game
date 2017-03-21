using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOther : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		Destroy(col.gameObject);
		GameObject.Find ("Plane").GetComponent<Score>().leftScreen = Screen.width/2-100;
		GameObject.Find ("Plane").GetComponent<Score>().scoreString = "GAME OVER";
		GameObject.Find ("Plane").GetComponent<Score>().size = 40;
		Application.Quit();
	}
}
