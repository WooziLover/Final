using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float mSpeed;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        mSpeed = 3.0f;
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rigidBody.transform.Rotate(0, 20 * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.D))
            rigidBody.transform.Rotate(0, -20 * Time.deltaTime, 0);

        /*if (Input.GetKey(KeyCode.W))
            rigidBody.transform.Rotate(0, 0, 20 * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            rigidBody.transform.Rotate(0, 0, -20 * Time.deltaTime);*/    
    }
}
