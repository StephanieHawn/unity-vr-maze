using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

	public float speed = 10f;
	public bool rotate = false;

	void Start ()
	{
		//maybe add in start function to rotate camera facing the maze when it starts
	}

	void Update ()
	{
		//transform.Rotate(Vector3.up, speed * Time.deltaTime);

	}

	public void RotateOnClick ()
	{
		// ...also rotate around the World's Y axis
		//transform.Rotate(0, 0, -180 * Time.deltaTime, Space.World);
		transform.Rotate(0, 0, -180);
		Debug.Log ("test");
	}

	public void RotateOnStartIcon ()
	{
		transform.Rotate(0, -180, 0);
		Debug.Log ("test-start");
	}

}
