using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomFruit : MonoBehaviour
{

    GameObject[] itemChoices;
    Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        pick();
        
    }

    void pick()
    {
        int randomIndex = Random.Range(0, itemChoices.Length + 1);
        GameObject spawn = Instantiate(itemChoices[randomIndex], transform.position, Quaternion.identity);
    }         
}
