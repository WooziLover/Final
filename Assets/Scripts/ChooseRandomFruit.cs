    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomFruit : MonoBehaviour
{
    //Is no class using this?

    GameObject[] itemChoices;
    Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        pick();
        
    }

    void pick()
    {
        int randomIndex = Random.Range(0, itemChoices.Length);
        GameObject spawn = Instantiate(itemChoices[2], transform.position, Quaternion.identity);
    }         
}