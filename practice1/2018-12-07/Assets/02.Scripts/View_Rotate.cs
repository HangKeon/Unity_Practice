using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_Rotate : MonoBehaviour
{
    private Transform Player;
    private Transform CameraView;
    public float moveSpeed = 10.0f;
    public float rotSpeed = 100.0f;

   // private GameObject cameraObject;

   // public float h = 0.0f;
   // public float v = 0.0f;

	// Use this for initialization
	void Start ()
    {
        Player = GetComponent<Transform>();
        //cameraObject = GameObject.Find("Main Camera");
       // CameraView = cameraObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //h = Input.GetAxis("Horizontal");
        //v = Input.GetAxis("Vertical");

        //CameraView.Rotate(Vector3.up * h * rotSpeed * Input.GetAxis("Mouse X") * Time.deltaTime);
        Player.Rotate(Vector3.up * rotSpeed * Input.GetAxis("Mouse X") * Time.deltaTime);
    }
}
