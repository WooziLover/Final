using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchHeld : MonoBehaviour
{
    public int inventoryCount;
    public float magnitude = 2.12f;
    Rigidbody rigidBody;
    int count = 0;
    public GameObject spherePrefab;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inventoryCount = InventoryScore.numberOfObjects;
        if (Input.GetKey(KeyCode.T))
        {
            if (count < inventoryCount)
            {
                transform.parent = null;
                GameObject spawn = Instantiate(spherePrefab, transform.position + transform.right + transform.right, Quaternion.identity);
                Launch();

            }
        }
    }

    void Launch()
    {
        rigidBody.AddForce(new Vector3(200, 100, 8) * magnitude);
    }

    /*public float magnitude = 2.12f;
    public float userDist;

    public int numberHeldRightNow = 0;
    public GameObject spherePrefab;
    
    private void Start()
    {
        
    }

    private void Update()
    {
       // InventoryScore.singleton.inventory.text = numberHeldRightNow.ToString() + " Spheres";

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (numberHeldRightNow > 0)
            {
                GameObject spawn = Instantiate(spherePrefab, transform.position + transform.forward + transform.forward, Quaternion.identity);
                Rigidbody spawnedSphereRigidbody = spawn.GetComponent<Rigidbody>();
                spawnedSphereRigidbody.AddForce(new Vector3(userDist, 8, 5) * magnitude);
            }
        }
}*/


}
