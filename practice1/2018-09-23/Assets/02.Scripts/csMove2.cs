using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMove2 : MonoBehaviour
{

    float speed = 3.0f;

	// Use this for initialization
	void Start ()
    {
        this.transform.position = new Vector3(0.5f, 0.5f, 0.5f);
	}
	
	// Update is called once per frame
	void Update ()
    {

        //키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동 거리 보정
        h = h * Time.deltaTime;
        v = v * Time.deltaTime;

        //실제 이동
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);










		/*if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -Time.deltaTime * speed));
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }*/
	}
}
