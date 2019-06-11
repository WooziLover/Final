using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsOnCollide : MonoBehaviour
{
    Text mText;

    void Start()
    {
        mText = GetComponent<Text>();
    } 
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "TheWall"){
            /* x = transform.position.x.ToString();
            y = transform.position.y.ToString();
            z = transform.position.z.ToString();  */ 
            Debug.Log("(" + transform.position.x + "," + transform.position.y + "," + transform.position.z + ")");

            // + transform.position.y.ToString() + transform.position.z.ToString());
        }
    }
}
