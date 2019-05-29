using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndLaunch : MonoBehaviour
{
    public GameObject[] itemChoices;
    // Start is called before the first frame update
    void Start()
    {
        Pick();
    }

    void Pick()
    {
        int randomIndex = Random.Range(0, itemChoices.Length);
        GameObject spawn = Instantiate(itemChoices[randomIndex], transform.position, Quaternion.identity);
    }
  
    void Launch()
    {
        float randomDistance = Random.Range(0, GetComponent<Plane>().distance);

    }
}
