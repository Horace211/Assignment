using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveP2 : MonoBehaviour {

    float speed = 0.5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;

        if (Input.GetMouseButton(0))
            pos.y += speed;

        if (Input.GetMouseButton(1))
            pos.y -= speed;

        transform.position = pos;


    }
}
