using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    enum Difficulties { Easy = 1, Normal };
    [SerializeField] private GameObject[] enemyPrefabs;
 
    [SerializeField] private float startDelay = 2;
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private Difficulties difficulty;

    void Start()
    {
        Debug.Log(difficulty);
        Debug.Log(((int)difficulty));
       
       switch (difficulty)
       {
           case Difficulties.Easy:
               Debug.Log("FACIL");
               InvokeRepeating("SpawnEnemy", (startDelay + 3f), (spawnInterval + 3f));
           break;
           case Difficulties.Normal:
               Debug.Log("NORMAL");
               InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
           break;
        default:
               Debug.Log("<color=#FF0000>ERROR AL ELEGIR NIVEL</color>");
               break;
       }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], transform.position, enemyPrefabs[enemyIndex].transform.rotation);
    }


}