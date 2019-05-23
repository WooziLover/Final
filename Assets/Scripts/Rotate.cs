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
        if(Input.GetKey(KeyCode.A))
            rigidBody.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            rigidBody.transform.RotateAround(Vector3.zero, Vector3.down, 20 * Time.deltaTime);

        /*if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(point, Vector3.up, 20 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
            transform.RotateAround(point, -Vector3.up, 20 * Time.deltaTime);*/
    }
}
