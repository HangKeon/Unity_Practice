using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float V = 0.0f;
    private float H = 0.0f;
    private Transform Player;
    //private Transform CameraView;
    public float moveSpeed = 10.0f;
    public float rotSpeed = 100.0f;
    private GameObject cameraObject;

    // Use this for initialization
    void Start ()
    {
        // Player = GetComponent<Transform>();
        //Player = gameObject.transform.Translate
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        H = Input.GetAxis("Horizontal");
        V = Input.GetAxis("Vertical");
        Debug.Log("Horizontal = " + H);
        Debug.Log("Vertical = " + V);

        Vector3 Move = (Vector3.forward * V) + (Vector3.right * H);
        Player.Translate(Move.normalized * moveSpeed * Time.deltaTime, Space.Self); //normalized : 대각선으로 가도 가는 길이 동일하게, spzce.self : 나를 기준으로 움직인다.

    }
}
