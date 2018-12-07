using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solve : MonoBehaviour
{
    public bool go = true;
    public int cnt = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(go)
        {
            gameObject.transform.Translate(0, 0, (float)-0.5);
            if (cnt == 100)
                go = false;
            cnt++;
        }
        else
        {
            gameObject.transform.Translate(0, 0, (float)0.5);
            if (cnt == 0)
                go = true;
            cnt--;
        }
	}
}
