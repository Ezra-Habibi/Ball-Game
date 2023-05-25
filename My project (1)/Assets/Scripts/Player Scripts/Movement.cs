using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float movementForce;
    public float jumpHeight = 500;
    public bool onGround = false;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space)){
            rb.AddForce(0,jumpHeight * Time.deltaTime,0,ForceMode.VelocityChange);
            onGround = false;
        }

        if(onGround == false){
            jumpHeight = 0f;
        }


        if(Input.GetKey("a")){
            rb.AddForce(-movementForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        
        if(Input.GetKey("d")){
            rb.AddForce(movementForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

    }

    void OnCollisionEnter(Collision collision){
        Invoke("JumpDelay", 0.001f);
    }

    void JumpDelay()
    {
        onGround = true;
        jumpHeight = 500;
    }
}
