using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   public static int userDistance = 0;

   public void GetInput(string mDist)
    {
        //Debug.Log("you entered" + mDist);
        userDistance = (int.Parse(mDist));
    }

    public static int GetDist()
    {
        return userDistance;
    }




}
