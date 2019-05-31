using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndLaunch : MonoBehaviour
{
    public GameObject[] itemChoices;
    int direction = 4;
    Rigidbody rigidBody;
    GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Pick();
        Launch();
    }

    void Pick()
    {
        int randomIndex = Random.Range(0, itemChoices.Length);
       spawn = Instantiate(itemChoices[randomIndex], transform.position, Quaternion.identity);
    }
  
    void Launch()
    {
        
      /*  float randomDistance = Random.Range(0, GetComponent<Plane>().distance);
        switch (direction)
        {
            case 0:
                rigidBody.AddForce(Vector3.up);
                break;

            case 1:
                rigidBody.AddForce(Vector3.left);
                break;

            case 2:
                rigidBody.AddForce(Vector3.right);
                break;

            case 3:
                rigidBody.AddForce(Vector3.down);
                break;
        }*/
    }
}
