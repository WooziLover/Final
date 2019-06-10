using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowOrNoThrow : MonoBehaviour
{
    Text mText;
    // Start is called before the first frame update
    void Start()
    {
        mText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(InventoryScore.numberOfObjects == 0)
            mText.text = "There's nothing to throw!";
        else
        {
            mText.text = "You can throw your items!";
        }

    }
}
