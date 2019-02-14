using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {
	public float speed = 5;
	public float smoothTime = 0.3f;
	Vector3 moveTarget;
	private Vector3 velocity = Vector3.zero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 moveTarget = new Vector3(
			transform.position.x + (Input.GetAxis("Mouse X") * speed), 
			transform.position.y + (Input.GetAxis("Mouse Y") * speed),
			transform.position.z 
		);

		transform.position = Vector3.Lerp(transform.position, moveTarget, smoothTime * Time.deltaTime);

         //transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
		/* Debug.Log(Input.GetAxis("Mouse X"));
		
		 // Define a target position above and behind the target transform
       

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, moveTarget, ref velocity, smoothTime); */
	}
}
