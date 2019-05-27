using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float distanceToGround = 0.5f;
    public float jumpHeight = 10f;
    //public bool isGrounded;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    { 
          rigidBody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isGrounded())
        {
            Vector3 jump = new Vector3(0, jumpHeight, 0);
            rigidBody.velocity += jump;
        }
    }

    bool isGrounded()
    {

        return Physics.Raycast(transform.position, Vector3.down, distanceToGround);
    }
}
