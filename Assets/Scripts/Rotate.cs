using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float mSpeed;
    // Start is called before the first frame update
    void Start()
    {
        mSpeed = 200.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //issue with the cub rotating up and down
        if (Input.GetKey(KeyCode.Slash))
            transform.Rotate(0, mSpeed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.Comma))
            transform.Rotate(0, -(mSpeed * Time.deltaTime), 0);
       // if (Input.GetKey(KeyCode.Colon))
           // transform.Rotate(mSpeed * Time.deltaTime, 0, 0);
       // if (Input.GetKey(KeyCode.Period))
            //transform.Rotate(-(mSpeed * Time.deltaTime), 0, 0);
    }
}
