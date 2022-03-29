using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
   
    // Rotates the propeller
    void Update()
    {
        transform.Rotate(new Vector3(0,0,700) * Time.deltaTime);
    }
}
