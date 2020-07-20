using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{

	public Door door;
	public GameObject key;
	public float keySpeed;

	// Update is called once per frame
	void Update()
	{
		key.transform.Rotate(0, 0, keySpeed * Time.deltaTime);

	}
	public void OnKeyClicked()
	{
		Debug.Log("'Key.OnKeyClicked()' was called");
		door.Unlock();
		Destroy(key);
	}
}
