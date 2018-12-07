using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public int count = 0;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Start~~~!");
	}
	
	// Update is called once per frame
	void Update ()
    {
        count += 1;
        Debug.Log(count + "번 째 프레임");

	}
}
