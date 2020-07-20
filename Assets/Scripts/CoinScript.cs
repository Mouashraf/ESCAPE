using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

	public GameObject coin;
	public float coinSpeed;
	public Text countText;
	public static int count=0;

	// Update is called once per frame
	void Update()
	{
		coin.transform.Rotate(0, coinSpeed * Time.deltaTime, 0);


	}

	public void OnCoinClicked()
	{
		count = count+1;
		Destroy(coin);
		setCountText();


	}

	public void setCountText()
	{
		countText.text = "You've Collected " + count + " Out of 4 Coins";
	}
}
