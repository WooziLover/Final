using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchHeld : MonoBehaviour
{
    public int inventoryCount;
    public float magnitude = 2.12f;
    Rigidbody rigidBody;
    public int userDist;
    int count = 0;
    public GameObject[] collectedObjects;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inventoryCount = InventoryScore.numberOfObjects;
        userDist = GameController.userDistance;
        collectedObjects = new GameObject[inventoryCount];

        if (Input.GetKey(KeyCode.T))
        {
            if (count < inventoryCount)
            {
                GameObject spawn = Instantiate(collectedObjects[count], transform.position, Quaternion.identity);
                rigidBody.AddForce(new Vector3(userDist, 8, 5) * magnitude);
                count++;
            }
        }
       
    }

  

}
