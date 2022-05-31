using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //MAKE SOMETHING IF TRANSFORM POSITION OF CAR IS GREATER THAN OBSTACLE BY 100 DELETE THE OBJECT
        if (transform.position.x > 15 || transform.position.x < -15 || transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
