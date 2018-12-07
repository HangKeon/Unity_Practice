using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotate2 : MonoBehaviour
{

    float speed = 50.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동 거리 보정
        h = h * Time.deltaTime * speed;
        v = v * Time.deltaTime * speed;

        //회전 #1
        //transform.Rotate(Vector3.forward * h);        Horizontal - Z axis
        //transform.Rotate(Vector3.right * v);          Vertical - X axis

        //회전 #2
        //Horizontal - Z axis
        transform.rotation *= Quaternion.AngleAxis(h, Vector3.forward);

        //Vertical - X axis
        transform.rotation *= Quaternion.AngleAxis(v, Vector3.right);
	}
}
