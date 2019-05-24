using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float mSpeed;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        mSpeed = 5.0f;
        rigidBody = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidBody.detectCollisions)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rigidBody.velocity = Vector3.up * mSpeed;
            }
            else
            {
                rigidBody.AddForce( ,ForceMode.Impulse);
            }
        }
    }
}
