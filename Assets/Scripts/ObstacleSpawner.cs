/** 
 * Spawns Objects
 * Author: Eric Tran
 * Version: 6/6/2022
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private bool isGameActive;
    private float spawnRate = 1.0f;
    private float spawnRange = 0.75f;
    public Timer timeScript;
    
    public List<GameObject> obstacles;
    public GameObject vehicle;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCoroutine(Spawner());
        
    }

    // Update is called once per frame
    void Update()
    {

     

        int time = timeScript.time;
        if (time>30 && time<60)
        {
            spawnRate = 0.75f;
        }
        if (time > 60 && time< 120 )
        {
            spawnRate /= 0.65f;
        }
        if (time > 120 && time < 180)
        {
            spawnRate /= 0.5f;
        }
        if (time > 180)
        {
            spawnRate = 0.33f; 
        }




    }
    IEnumerator Spawner()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, obstacles.Count);
            int indexv2 = Random.Range(0, (obstacles.Count - 1));
            //add something about having certain obstacles spawn if certain time has passed

            int time = timeScript.time;
            if (time > 30 && time < 60)
            {
                spawnRate = 0.88f;
            }
            if (time > 60 && time < 120)
            {
                spawnRate = 0.75f;
            }
            if (time > 120 && time < 180)
            {
                spawnRate = 0.65f;
            }
            if (time > 180)
            {
                spawnRate = 0.50f;
            }
            if (time < 60)
            {
                Instantiate(obstacles[indexv2], (vehicle.transform.position + new Vector3(0, 0, 120)), transform.rotation);
            }

            if (time > 50)
            {
                Instantiate(obstacles[index], (vehicle.transform.position + new Vector3(0, 0, 120)), transform.rotation);
            }
        }

    }
 
}
