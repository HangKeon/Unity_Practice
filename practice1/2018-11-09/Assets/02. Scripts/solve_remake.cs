using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solve_remake : MonoBehaviour
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
                cnt++;
            
        }
	}
}
