using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

	bool locked = true;

	bool opening = false;


	public Canvas endingScreen;

	public GameObject Flocking;

	public Door door;

	public AudioSource DoorOpening;

	bool hasBeenClicked=false;


	public void OnDoorClicked()
	{

		Debug.Log("'Door.OnDoorClicked()' was called");
		if (locked == false && hasBeenClicked==false)
		{
			opening = true;
			door.GetComponent<Animation>().Play();
			hasBeenClicked = true;
			endingScreen.gameObject.SetActive(true);
			Flocking.gameObject.SetActive(true);
			DoorOpening.GetComponent<AudioSource>().Play();

		}
		if (locked == false && hasBeenClicked == true)
		{
		}

	}

	public void Unlock()
	{

		Debug.Log("'Door.Unlock()' was called");
		locked = false;
	}


}

