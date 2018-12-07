using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public string text = "쌤";
    public int num = 1;

	// Use this for initialization
	void Start () {
        Debug.Log("시작했떠여");
	}
	
	// Update is called once per frame
	void Update () {
        num += 100;
        Debug.Log(num + "번 째!");
	}
}
