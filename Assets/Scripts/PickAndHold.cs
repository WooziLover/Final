using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*So Mr.Gustin meant that when a object hits a ball, then the ball gets destroyed and added to an inventory at the
 * bottom of the screen
 */

public class PickAndHold : MonoBehaviour
{ 

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Sphere 1")
            Destroy(collision.gameObject); 
    }

}
