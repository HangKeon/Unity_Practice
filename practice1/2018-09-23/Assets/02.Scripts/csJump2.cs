using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csJump2 : MonoBehaviour {

    Vector3 velocity = new Vector3(0, 400.0f, 0);
	
	// Update is called once per frame
	void FixedUpdate ()
    {
	    if(Input.GetButtonUp("Jump"))
        {
            //질량이 2배인 Cube2는 같은 힘을 받아도 적게 점프한다.
            GetComponent<Rigidbody>().AddForce(velocity);
        }
	}
}
