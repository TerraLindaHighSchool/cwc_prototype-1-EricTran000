/** 
 * Allows the camera to follow the player
 * Author: Eric Tran
 * Version: 6/6/2022
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame 
    void LateUpdate()
    {
        // Lets the camera follow the player
        transform.position = player.transform.position + offset;
    }
}
