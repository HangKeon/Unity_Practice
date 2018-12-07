using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMove1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //트랜스폼 포지션 세팅 : 이동
        //해당 Vector의 값으로 이동하여 위치하게 함.
        this.transform.position = new Vector3(0.0f, 0.5f, 0.0f);

        //이동
        //현재 위치에서 주어진 값만큼 이동
        //this.transform.Translate(new Vector3(0.0f, 0.0f, 1.0f));
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //this.transform.Translate(Vector3.forward * 1.0f);
            this.transform.Translate(new Vector3(0.0f, 0.0f, 1.0f));
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0.0f, 0.0f, -1.0f));
        }
    }
}
