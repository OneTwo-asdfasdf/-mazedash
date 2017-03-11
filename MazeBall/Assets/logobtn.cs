using UnityEngine;
using System.Collections;

public class logobtn : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
		Debug.Log ("" + PlayerPrefs.GetInt("Stage"));
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnGUI () {
		int w = Screen.width / 2;
		int h = Screen.height / 2;
		
		
		if (GUI.Button (new Rect (w - 180, h + 50, 120, 50), "Start")) {
		

			switch (PlayerPrefs.GetInt("Stage")) {

			case 0 : // nil
				Application.LoadLevel ("1");
				break;

			case 2 :
				Application.LoadLevel ("2");
				break;

			case 3 :
				Application.LoadLevel ("3");
				break;

			case 4 :
				Application.LoadLevel ("4");
				break;

			case 5 : 
				Application.LoadLevel ("5");
				break;
			}



		}

		if (GUI.Button(new Rect(w+60, h+50, 120, 50), "Exit"))  Application.Quit();
		
		
	}
}
