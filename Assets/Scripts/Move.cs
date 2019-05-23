using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rigidBody;
    public float mSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        mSpeed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            rigidBody.transform.Translate(0f, 0f, Input.GetAxis("Vertical") * mSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            rigidBody.transform.Translate(Input.GetAxis("Horizontal") * mSpeed * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(KeyCode.R))
        {
            mSpeed += 2.0f;
            rigidBody.transform.Translate(Input.GetAxis("Horizontal") * mSpeed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * 
                mSpeed * Time.deltaTime);
        }
        else
        {
            mSpeed = 1.0f;
        }
            
    }
}


