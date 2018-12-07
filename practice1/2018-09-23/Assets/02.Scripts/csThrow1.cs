using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csThrow1 : MonoBehaviour
{
    float power = 800.0f;
    Vector3 velocity = new Vector3(0.5f, 0.5f, 0.0f);

    //만약 몇 개의 프레임들에 힘을 적용하고 싶다면
    //Update 대신에 FixedUpdate를 사용해야 한다.
    void FixedUpdate()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            velocity *= power;

            GetComponent<Rigidbody>().AddForce(velocity);
        }
    }
	
}
