using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public Door doorObject;
	public GameObject keyPoof;
	bool keyCollected = true;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		GameObject poofInstance = (GameObject)Object.Instantiate (keyPoof);
        
        // Call the Unlock() method on the Doorå
		doorObject.GetComponent<Door>().Unlock();

        // Set the Key Collected Variable to true
		keyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
