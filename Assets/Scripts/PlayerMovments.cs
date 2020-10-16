using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovments : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardForce = 2000f;
    public float slidewaysForce = 500f;
    public float jumpForce = 50f;



    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime) ;

        if (Input.GetKey("d"))
        {
            rb.AddForce(slidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-slidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 50f * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -30f * Time.deltaTime, ForceMode.VelocityChange);
        }


        if (rb.position.y < 0.9f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (rb.position.z > 1500)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
