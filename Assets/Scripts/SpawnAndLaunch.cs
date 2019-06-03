using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndLaunch : MonoBehaviour
{
    public GameObject[] itemChoices;
    int direction = 4;
    Rigidbody rigidBody;

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
       GameObject spawn = Instantiate(itemChoices[randomIndex], transform.position, Quaternion.identity);
    }
  
    void Launch()
    {
        if (Input.GetKey(KeyCode.L))
        {
            int x = Random.Range(-360, 360);
            int y = Random.Range(-360, 360);
            Vector3 newForce = new Vector3(x, 0, y);
            rigidBody.AddForce(newForce);// newForce * 5
        }
    }
}
