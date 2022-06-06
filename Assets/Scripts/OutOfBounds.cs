/** 
 * Destroys objects out of bounds
 * Author: Eric Tran
 * Version: 6/6/2022
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    private GameObject vehicle;
    // Start is called before the first frame update
    void Start()
    {
        vehicle = GameObject.Find("Vehicle");

    }

    // Update is called once per frame
    void Update()
    {
        //MAKE SOMETHING IF TRANSFORM POSITION OF CAR IS GREATER THAN OBSTACLE BY 100 DELETE THE OBJECT
        if (transform.position.x > 15 || transform.position.x < -15 || transform.position.y < -10 || this.transform.position.z + 70 < (vehicle.transform.position.z))
        {
            Destroy(gameObject);
        }
    }
}
