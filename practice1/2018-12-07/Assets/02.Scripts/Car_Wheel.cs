using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Wheel : MonoBehaviour {

    private float Rotspeed = 10.0f;
    private Transform tr;

	// Use this for initialization
	void Start ()
    {
        tr.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        tr.Rotate(Vector3.right * Rotspeed * Time.deltaTime, Space.Self);	
	}
}
