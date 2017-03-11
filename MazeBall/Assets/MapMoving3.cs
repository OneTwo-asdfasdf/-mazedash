using UnityEngine;
using System.Collections;

public class MapMoving3 : MonoBehaviour {
	
	
	
	int speed = 7;
	
	int HorSpeed = 9;
	int f;
	
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		int i;
		for(i=0; i<5; i++){
			
			
			
		}
		
		
		
		
		float moveSpeed = Time.smoothDeltaTime * speed;
		float moveHorSpeed = Time.smoothDeltaTime * HorSpeed;
		
		
		float KeyVer = Input.GetAxis ("Vertical");
		
		transform.Translate (Vector3.left * moveSpeed);
		
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			
			float y = Input.acceleration.y;
			
			
			if (y < -0.6f) {
				
				
				transform.Translate(Vector3.up * -moveHorSpeed);
			}
			else if (-0.6 < y && y < -0.4) {
				
			}else transform.Translate (Vector3.up * moveHorSpeed);
			
			
			
			
			
			
			
		}
		
		
		transform.Translate (Vector3.up * moveHorSpeed * KeyVer);
		
		
		transform.position = new Vector3 (transform.position.x,  Mathf.Clamp (transform.position.y, -2.8f, 2.8f),0);
		
		
		
		
	}
	
	
	
	
	
	
	
	
	
}
