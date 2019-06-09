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
        inventory.text = numberOfObjects + " " + "Spheres";
    }
}
