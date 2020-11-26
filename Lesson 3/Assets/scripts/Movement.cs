using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float SideForce = 100;
    public float JumpForce = 50;
    public float ForwardForce = 200;

    void FixedUpdate()
    {
        if (Input.GetKey("left") || Input.GetKey("a")){
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("right") || Input.GetKey("d")){
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

       /* if (Input.GetKey("up") || Input.GetKey("space"))
        {
            rb.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        */
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if(rb.position.y < -1f)
        {
            FindObjectOfType<SpelHanteraren>().gameOver();
        }

    }
}
