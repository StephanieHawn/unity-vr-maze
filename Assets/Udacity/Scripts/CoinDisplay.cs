using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour {

	public Text count;
	public Text allCoins;
	public static int coinCount = 0;


	// Use this for initialization
	void Start () {
		coinCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Text coins = GetComponent<Text> ();
		coins.text = "Coins Collected: " + coinCount;
		CoinText ();
	}

	public void CoinIncrement()
	{
		coinCount += 1;
		CoinText ();
		Debug.Log ("coin increment");
	}

	void CoinText()
	{
		if (coinCount >= 6) {
			count.text = "Coins " + coinCount + "/6";
			allCoins.text = "Bazinga!";
		} else {
			count.text = "Coins " + coinCount + "/6";
		}
	}
}
