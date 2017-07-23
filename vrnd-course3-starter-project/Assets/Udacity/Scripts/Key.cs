using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public GameObject doorPre;
	bool keyCollected = true;

	void Update()
	{
		transform.Rotate( 0, 0, 90 * Time.deltaTime);
	}

	public void OnKeyClicked()
	{
		// Instatiate the KeyPoof Prefab where this key is located. Make sure the poof animates vertically
		//GameObject poofInstance = (GameObject)Object.Instantiate(keyPoof);
		GameObject poofInstance = (GameObject)Object.Instantiate(keyPoof, gameObject.transform.position, keyPoof.transform.rotation);
        // Call the Unlock() method on the Doorå
		doorPre.GetComponent<Door> ().Unlock ();
        // Set the Key Collected Variable to true
		keyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
