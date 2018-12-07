using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Move : MonoBehaviour
{
    private float moveSpeed = 10.0f;
    private float rotSpeed = 100.0f;

    private float h = 0.0f;
    private float v = 0.0f;

    private Transform tr;
    
	// Use this for initialization
	void Start ()
    {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //if ()
        {
            //지금 자동차를 x,z를 반대로 만들어 놔서 앞으로 갈 경우 h, 옆으로 가는 경우 v를 사용해야 한다.
            tr.Translate(Vector3.forward * moveSpeed * Time.deltaTime * h, Space.Self);
            tr.Translate(Vector3.right * moveSpeed * Time.deltaTime * v, Space.Self);

            tr.Rotate(Vector3.up * rotSpeed * Time.deltaTime * h, Space.Self);
        }
	}
}
