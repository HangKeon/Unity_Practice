using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Cube1 : MonoBehaviour {

    private float h = 0.0f;
    private float v = 0.0f;

    private Transform tr;                   //transform이라는 클래스에 있는 멤버를 사용할 수 있음.

    public float rotSpeed = 150.0f;
   // public float moveSpeed = 1000.0f;

    // Use this for initialization
    void Start ()
    {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
      //  h = Input.GetAxis("Horizontal");
      //  v = Input.GetAxis("Vertical");

        //키보드로 움직이는 것
     //   tr.Translate(Vector3.forward * moveSpeed * v * Time.deltaTime, Space.Self); //앞, 뒤로 이동
     //   tr.Translate(Vector3.right * moveSpeed * h * Time.deltaTime, Space.Self); //오른쪽, 왼쪽 이동

        //마우스로 회전하는 것
       // tr.Rotate(Vector3.up * rotSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));       //높이를 기준으로 회전
        tr.Rotate(Vector3.left * 50 * Time.deltaTime * Input.GetAxis("Mouse Y"));      //가로를 기준으로 회전   

    }
}
