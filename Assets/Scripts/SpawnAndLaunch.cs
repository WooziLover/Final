using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndLaunch : MonoBehaviour
{
    public GameObject[] itemChoices;
    public float magnitude = 2.12f;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        pick();
        //here to access the method in ChooseRandomFruit class
    }

    void Update()
    {
        launch();    
    }
    void pick()
    {
        int randomIndex = Random.Range(0, itemChoices.Length);
       GameObject spawn = Instantiate(itemChoices[randomIndex], transform.position, Quaternion.identity);
    }
  
    void launch()
    {
        if (Input.GetKey(KeyCode.L))
        {
            int x = Random.Range(-8, 8);//-1,1
            int z = Random.Range(-8, 8);//-1, 1
            rigidBody.AddForce(new Vector3(x, 1, z) * magnitude); 
        }
    }
}
