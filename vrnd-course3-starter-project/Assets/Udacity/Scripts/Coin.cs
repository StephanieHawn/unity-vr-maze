using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;


    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located. Make sure the poof animates vertically
		GameObject poofInstance = (GameObject)Object.Instantiate(coinPoof, gameObject.transform.position, coinPoof.transform.rotation);
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
