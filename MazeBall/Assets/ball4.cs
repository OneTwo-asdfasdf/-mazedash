using UnityEngine;
using System.Collections;

public class ball4 : MonoBehaviour {
	
	public AudioClip expSound;
	public Transform exploson;
	bool isDead;
	public Transform expBig;
	int HP = 1;
	int rotX;
	int rotY;
	int rotZ;
	
	
	// Use this for initialization
	void Start () {
		HP = 1;
		
		isDead = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		rotX = Random.Range (-90, 90);
		rotY = Random.Range (-90, 90);
		rotZ = Random.Range (-90, 90);
		transform.Rotate (new Vector3 (rotX, rotY, rotZ));
		
		
		
		
		transform.position = new Vector3 (-8, 0, 0);
		if (Input.GetKeyDown (KeyCode.Escape)) {
			
			Application.Quit ();
		}
		
		
		
		
		
		
		
		if (isDead)
			
			return;
		
	}
	
	void OnTriggerEnter (Collider coll) {
		
		
		AudioSource.PlayClipAtPoint (expSound, transform.position);
		Instantiate (exploson, transform.position, Quaternion.identity);
		
		if (coll.tag == "WALL") {
			
			

			
			
			HP--;
			if (HP <=0) {
				

				DestroyBall ();
				
				
				
			}
			
			
		}
		if (coll.tag == "FINAL") {

			PlayerPrefs.SetInt("Stage", 5);
			PlayerPrefs.Save();
			
			Application.LoadLevel("5");
		}
	}
	
	
	
	
	
	
	void DestroyBall () {
		
		Instantiate (expBig, transform.position, Quaternion.identity);
		transform.position = new Vector3 (0, -1, -20);
		Time.timeScale = 0;
		
		isDead = true;
		
		
	}
	
	
	void OnGUI () {
		int w = Screen.width / 2;
		int h = Screen.height / 2;
		GUI.Label (new Rect (w-50, 10, 120, 50), "Round4");
		
		
		
		if (!isDead)
			return;
		if (GUI.Button(new Rect(w-60, h-50, 120, 50), "GameRestart")) Application.LoadLevel("4");
		if (GUI.Button(new Rect(w-60, h+50, 120, 50), "QuitGame"))  Application.LoadLevel("Logo");
		
	}
	
}
