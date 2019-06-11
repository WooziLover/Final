using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*So Mr.Gustin meant that when a object hits a ball, then the ball gets destroyed and added to an inventory at the
 * bottom of the screen
 */

public class PickAndHold : MonoBehaviour
{
    public static List<GameObject> objectList = new List<GameObject>();
    public GameObject spherePrefab;

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere 1" || col.gameObject.name == "Sphere 1(Clone)")
        {
            objectList.Add(spherePrefab);
         //   GetComponent<LaunchHeld>().++;
            InventoryScore.numberOfObjects += 1;
            Destroy(col.gameObject);
        }
    }

}
