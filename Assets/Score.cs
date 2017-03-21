using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	public int plscore = 0;
	public string scoreString;
	public int size = 30;
	public int leftScreen;
	// Use this for initialization
	void Start () {
		leftScreen = Screen.width - 100;
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.color = Color.black;
		GUI.skin.label.fontSize = size;
		GUI.Label(new Rect(leftScreen,2,400,200),scoreString);
	}
}
