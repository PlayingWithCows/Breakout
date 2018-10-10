using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public bool isReleased;
    public float attractionToBottom = 200;
    public float maxSpeed = 5f;


    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {

    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, 0, -attractionToBottom*3f * Time.deltaTime), ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Pad"))
        {
            rb.AddForce(rb.velocity * 1.3f, ForceMode.VelocityChange);
        }

        if (collision.collider.CompareTag("Death"))
        {
            rb.AddForce(rb.velocity * 1.3f, ForceMode.VelocityChange);
        }
    }
}

