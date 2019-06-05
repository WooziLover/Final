using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAndHold : MonoBehaviour
{
    Rigidbody rigidBody;
    Transform player;
    Vector3 vector;

    //You have to use the Translate Function so it goes to the camera. 

     // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();  
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            rigidBody.transform.Translate(rigidBody.position.x, rigidBody.position.y, rigidBody.position.z);
        }   
    }
}
