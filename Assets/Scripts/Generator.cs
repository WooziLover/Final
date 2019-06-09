using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject spawn;
    public int xPos;
    public int zPos;
    public int spawnCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheDrop());
    }

    IEnumerator TheDrop()
    {
        while(spawnCount < 10)
        {
            xPos = Random.Range(-8, 8);
            zPos = Random.Range(-8, 8);
            Instantiate(spawn, new Vector3(xPos, transform.position.y, zPos), Quaternion.identity);
            yield return new WaitForSeconds(.5f);
            spawnCount += 1;
        }
    }
}
