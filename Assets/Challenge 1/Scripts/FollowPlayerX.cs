using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(20, 1, 0);


    // Makes the camera follow the player
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
