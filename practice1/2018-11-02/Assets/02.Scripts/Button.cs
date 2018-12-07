using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public string text = "쌤";
    public int num = 1;
    public bool show = false;

	// Use this for initialization
	void Start () {
        Debug.Log("시작");
	}
	
	// Update is called once per frame
	void Update () {
		if(show)
        {
            num += 1;
            Debug.Log(num + text);
        }
	}

    public void OnBTClick()
    {
        show = true;
    }
}
