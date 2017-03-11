using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnGUI () {
		int w = Screen.width / 2;
		int h = Screen.height / 2;


		if (GUI.Button(new Rect(w-180, h+50, 120, 50), "ReStart")) Application.LoadLevel("1");
		if (GUI.Button(new Rect(w+60, h+50, 120, 50), "Exit"))  Application.Quit();
		
	
	}
}
