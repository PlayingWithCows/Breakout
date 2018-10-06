using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadMover : MonoBehaviour {

    public Vector2 moveSpeed;
    public Vector2 minMaxX, minMaxY;
   

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        MovePad();
	}

    private void MovePad()
    {
        float mouseMovementX = Input.GetAxis("Mouse X");
        float mouseMovementY = Input.GetAxis("Mouse Y");

        Debug.Log(mouseMovementY);

        //is new x position bigger or smaller than minMaxX
        if (transform.position.x + mouseMovementX > minMaxX.y && mouseMovementX >= 0) 
        {
            mouseMovementX = 0;
        }
        if (transform.position.x + mouseMovementX < minMaxX.x && mouseMovementX <= 0)
        {
            mouseMovementX = 0;
        }

        //is new y position bigger or smaller than minMaxY
        if (transform.position.z + mouseMovementY > minMaxY.y && mouseMovementY >= 0) 
        {
            mouseMovementY = 0;
        }
        if (transform.position.z + mouseMovementY < minMaxY.x && mouseMovementY <= 0)
        {
            mouseMovementY = 0;
        }
        //Debug.Log(mouseMovementX + " " + mouseMovementY);
        float newPosX = Mathf.Clamp(transform.position.x + (mouseMovementX * Time.deltaTime * moveSpeed.x), minMaxX.x, minMaxX.y);
        float newPosY = Mathf.Clamp(transform.position.z + (mouseMovementY * Time.deltaTime * moveSpeed.y), minMaxY.x, minMaxY.y);
       // Debug.Log(newPosX + " " + newPosY);
       // Debug.Log("--------");
        Vector3 newPos = new Vector3(newPosX, transform.position.y, newPosY);
        
        transform.position = newPos;

    }
}
