using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jin : MonoBehaviour
{
    public int a = 0,b=0;

    // Use this for initialization
    void Start ()
    {
        b = a;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (a<43 && b==0)
        {
            gameObject.transform.Translate(0, 0, -1.0f);
            a++;
            //b = a;
        }
        else if(a==43)
        {
            b = a;
            a = -1;
        }
        else if(a<43 && b<=43)
        {
            gameObject.transform.Translate(0, 0, (float)1);
            b--;
           // a = b;
        }
        else if(b==0)
        {
            a = b;
            b = -1;
        }

	}
}
