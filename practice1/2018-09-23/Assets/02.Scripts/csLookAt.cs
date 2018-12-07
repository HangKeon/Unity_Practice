using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csLookAt : MonoBehaviour
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
        //주시
        transform.LookAt(obj);
	}
}
