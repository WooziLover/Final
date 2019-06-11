using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchHeld : MonoBehaviour
{
    /*
    public int inventoryCount;
    public float magnitude = 2.12f;
    Rigidbody rigidBody;
    public int userDist;
    int count = 0;
    public GameObject[] collectedObjects;

    public List<GameObject> objectList = new List<GameObject>();

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        collectedObjects = new GameObject[inventoryCount];
    }

    void Update()
    {
        inventoryCount = InventoryScore.numberOfObjects;

        userDist = GameController.userDistance;

        if (Input.GetKeyUp(KeyCode.T))
        {
            if (count < inventoryCount)
            {
                GameObject spawn = Instantiate(collectedObjects[count], transform.position, Quaternion.identity);
                rigidBody.AddForce(new Vector3(userDist, 8, 5) * magnitude);
                count++;
            }
        }
       
    }
    */

    public float magnitude = 2.12f;//2.12
    public float userDist;

    public int numberHeldRightNow = 0;
    public GameObject spherePrefab;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        InventoryScore.singleton.inventory.text = numberHeldRightNow.ToString() + " Spheres";

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (numberHeldRightNow > 0)
            {
                userDist = GameController.userDistance;
            
                GameObject spawn = Instantiate(spherePrefab, transform.position + transform.forward, Quaternion.identity);
                Rigidbody spawnedSphereRigidbody = spawn.GetComponent<Rigidbody>();
                spawnedSphereRigidbody.AddForce(new Vector3(userDist, 8, 5) * magnitude);
            }
        }
    }


}
