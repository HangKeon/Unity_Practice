using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour {

    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))   //앞
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime); //y축으로 이동 -> 즉 카메라 시점 앞으로 이동
        }
        if (Input.GetKey(KeyCode.RightArrow))   //오른쪽
        {
            this.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))    //왼쪽
        {
            this.transform.Translate(speed * Time.deltaTime*(-1), 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))    //뒤쪽
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime*(-1));
        }
        if (Input.GetKey(KeyCode.W))            //위
        {
            this.transform.Translate(0, speed * Time.deltaTime, 0 );
        }
        if (Input.GetKey(KeyCode.S))            //아래
        {
            this.transform.Translate(0, speed * Time.deltaTime * (-1), 0);
        }
    }
}
