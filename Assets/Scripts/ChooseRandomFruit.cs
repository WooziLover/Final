using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomFruit : MonoBehaviour
{

    GameObject[] itemChoices;
    GameObject currentPoint;
    int randomChoice;

    // Start is called before the first frame update
    void Start()
    {
        itemChoices = GameObject.FindGameObjectsWithTag("point");
        randomChoice = Random.Range(0, itemChoices.Length);
        //next line holds the issue where there is a index out of bounds
      //  currentPoint = itemChoices[randomChoice];
//        print(currentPoint.name);
    }

    void Update()
    {
        
    }
}
