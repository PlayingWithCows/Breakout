using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public bool isReleased;
    public float attractionToBottom = 1;
    public float maxSpeed = 5f;


    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (isReleased)
        {
            float currentSpeed = rb.velocity.sqrMagnitude;


            rb.AddForce(0, -attractionToBottom * Time.deltaTime, 0, ForceMode.Impulse);

        }
    }
}
