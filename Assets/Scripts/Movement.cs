﻿/** 
 * Moves Objects Forward
 * Author: Eric Tran
 * Version: 6/6/2022
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(transform.forward * 5);
    }
}
