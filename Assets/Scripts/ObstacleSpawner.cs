using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private bool isGameActive;
    private float spawnRate = 1.0f;
    private float spawnRange = 0.75f;
    
    public List<GameObject> obstacles;
    public GameObject vechile;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCoroutine(Spawner());
        
        
    }

    // Update is called once per frame
    void Update()
    {
 
        
    }
    IEnumerator Spawner()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, obstacles.Count);
            //For the range it can spawn try finding the position of the vechile and then make sure it spawns in front
            Instantiate(obstacles[index], (vechile.transform.position + new Vector3(0, 0, 20)), transform.rotation);
        }

    }
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        spawnRate /= difficulty;
        


    }
}

