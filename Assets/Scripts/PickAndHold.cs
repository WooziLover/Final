using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*So Mr.Gustin meant that when a object hits a ball, then the ball gets destroyed and added to an inventory at the
 * bottom of the screen
 */

public class PickAndHold : MonoBehaviour
{
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere 1" || col.gameObject.name == "Sphere 1(Clone)")
          //  || col.gameObject.name == "Cube" || col.gameObject.name == "Cube(Clone)"
        {
            
            GetComponent<LaunchHeld>().numberHeldRightNow++;
            //InventoryScore.numberOfObjects += 1;
            Destroy(col.gameObject);
        }
    }

}
