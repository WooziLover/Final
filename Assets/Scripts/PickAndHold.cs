using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAndHold : MonoBehaviour
{
    //public Transform player;
    //public Transform playerCamera;
    public float magnitude = 2.12f;
    bool isPlayer = false;
    bool isHeld = false;
    bool isTouched = false;
    Rigidbody rigidBody;

    void Start()
    {
        rigidBody.GetComponent<Rigidbody>();
        Debug.Log("start works");
    }

    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, Camera.main.gameObject.transform.position);
        if(distance <= magnitude)
            isPlayer = true;
            else{
                isPlayer = false;
                //only works to here!
            }
    }        
       /*       if(isPlayer && Input.GetButtonDown("Use"))
            {
                Debug.Log("this works?");
                rigidBody.isKinematic = true;
            
                
                transform.parent = playerCamera;
                isHeld = true;
            }
            if(isHeld)
            {
                if(isTouched)
                {
                    rigidBody.isKinematic = false;
                    transform.parent = null;
                    isHeld = false;
                    isTouched = false;
                }
                if(Input.GetMouseButtonDown(0))
                {
                    rigidBody.isKinematic = false;
                    transform.parent = null;
                    isHeld = false;
                    rigidBody.AddForce(playerCamera.forward * magnitude);
                }
                else
                {
                    if(Input.GetMouseButtonDown(1))
                    {
                        rigidBody.isKinematic = false;
                        transform.parent = null;
                        isHeld = false; 
                    }
                }
            }
        
    }
    */
}
