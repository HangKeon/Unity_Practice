using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csJump3 : MonoBehaviour
{
    float gravity = 0.0f;           //gravity value
    Vector3 velocity;               //current stored height of character

	// Use this for initialization
	void Start ()
    {
        velocity = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
		//Jump
        if(Input.GetButtonDown("Jump"))
        {
            gravity = 10.0f;
        }
        velocity.y += gravity * Time.deltaTime;

        transform.position = velocity;

        gravity -= 0.5f;

        if (velocity.y<0.5f)
        {
            velocity.y = 0.5f;
            gravity = 0.0f;
        }
	}
}
