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

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "TheWall" || collision.gameObject.name == "Sphere 1" || collision.gameObject.name == "Sphere 1(Clone)");
        {
            string xCoord = transform.position.ToString();
            mText = GameObject.Find("Coordinates").GetComponent<Text>();
            mText.text = xCoord;
        }    
    }
}
