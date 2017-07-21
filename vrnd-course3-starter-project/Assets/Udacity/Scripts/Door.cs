using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	bool locked;
    // Create a boolean value called "opening" that can be checked in Update() 
	bool opening;

	public AudioSource openDoor;
	public AudioSource lockDoor;

	void Start()
	{
		locked = true;
		opening = false;
		lockDoor = GetComponent<AudioSource>();
	}

    void Update() {
		if (opening == true) {
			Debug.Log ("update - opening = true");
			if(transform.position.y < 4.1){transform.Translate (0, 4 * Time.deltaTime, 0, Space.World);}

		}
        // If the door is opening and it is not fully raised
            // Animate the door raising up
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
		if (locked == true) {
			// Set the "opening" boolean to true
			Debug.Log("if called - one door clicked");
			lockDoor.Play ();
		} else {
			// Play a sound to indicate the door is locked
			Debug.Log("else called");
			opening = true;
			openDoor.Play ();
		}    
    }

    public void Unlock()
    {
 		// You'll need to set "locked" to false here
		locked = false;
		Debug.Log("door unlock from door.cs");
    }
}
