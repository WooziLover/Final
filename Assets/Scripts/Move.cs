using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rigidBody;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
             transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime);
         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
             transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
       // if (Input.GetKey(KeyCode.R))
           // rigidBody.velocity = speed * Time.deltaTime;
             //rigidBody.velocity = transform.forward * speed;
       
    }
}
