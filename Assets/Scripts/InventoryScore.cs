using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryScore : MonoBehaviour
{
    public static int numberOfObjects = 0;
    Text inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Text>();  
    }

    // Update is called once per frame
    void Update()
    {
        if(numberOfObjects > 1)
        inventory.text = numberOfObjects + " " + "Spheres";
        else
        {
            inventory.text = numberOfObjects + " " + "Sphere";
        }
         
        if(numberOfObjects < 0)
            inventory.text = "0" + " " + "Sphere";
        if (Input.GetKey(KeyCode.T))
        {
            numberOfObjects--;
        }
    }
}
