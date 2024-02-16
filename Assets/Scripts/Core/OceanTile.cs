using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanTile : MonoBehaviour
{ 
    public Transform startPoint;
    public Transform endPoint;
    public GameObject[] obstacles; //Objects that contains different obstacle types which will be randomly activated

    public void ActivateRandomObstacle()
    {
      

        System.Random random = new System.Random();
        int randomNumber = random.Next(0, obstacles.Length);
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
        // Spawn the obstace at the position
        Instantiate(obstacles[randomNumber], spawnPoint.position, Quaternion.identity, transform);
    }

   
}