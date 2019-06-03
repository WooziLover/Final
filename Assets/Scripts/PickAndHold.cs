using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAndHold : MonoBehaviour
{
    public Transform mDestination;
    Rigidbody rigidBody;

    //You have to use the Translate Function so it goes to the camera. 

    void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = mDestination.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }
     // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();  
    }
    
    // Update is called once per frame
    void Update()
    {   
    }
}
