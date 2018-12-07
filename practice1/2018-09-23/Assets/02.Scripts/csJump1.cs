using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csJump1 : MonoBehaviour
{


	// Update is called once per frame
	void FixedUpdate ()
    {
		if(Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0);
        }
	}
}
