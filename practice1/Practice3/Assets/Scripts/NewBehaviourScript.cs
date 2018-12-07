using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int timer = 0;
    public GameObject capsule;
    public float speed = 3.0f;

	// Use this for initialization
	void Start () {
        Debug.Log("초기화가 이루어졌습니다.");
        capsule = GameObject.Find("Capsule");
	}
	
	// Update is called once per frame
	void Update () {
        timer = timer + 1;
        Debug.Log(timer + "번 째 업데이트");
        capsule.GetComponent<Transform>().Translate(Vector3.forward * speed * Time.deltaTime);
        //this.transform.Translate(Vector3.forward * speed * Time.deltaTime);   //이건 capsule=GameObject.Find("Capsule"); 가 없는 경우!!
    }
}
