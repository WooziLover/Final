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
            string x = transform.position.x.ToString();
            string y = transform.position.y.ToString();
            string z = transform.position.z.ToString();
            mText.text = x + y + z;
            //Debug.Log("(" + transform.position.x + "," + transform.position.y + "," + transform.position.z + ")");
        }
    }
}
