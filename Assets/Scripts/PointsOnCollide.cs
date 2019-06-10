using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsOnCollide : MonoBehaviour
{
    Text mText;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere 1" || col.gameObject.name == "Sphere 1(Clone)")
        {
            //mText.text = "(" + 
        }
    }
}
