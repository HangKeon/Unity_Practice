using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotateAround : MonoBehaviour
{
    Transform obj = null;

	// Use this for initialization
	void Start ()
    {
        //찾기
        obj = GameObject.Find("Cube2").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //주변 돌기1
        //transform.RotateAround(Vector3.zero, Vector3.up, 40 * Time.deltaTime);

        //주변 돌기2
        transform.RotateAround(obj.position, Vector3.up, 40 * Time.deltaTime);

        transform.LookAt(obj);
	}
}
