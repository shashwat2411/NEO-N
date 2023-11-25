using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] spawnPoint;
    private GameObject[] EnemyNum;

    public GameObject[] enemy;
    public float spawnInterval = 1f;
    public int maxSpawnNum = 3;
    
    private int randomGenerated = 0;
    float counter;
    private float lazerSpawnTime;
    public float lazerSpawn = 10f;
   
    
    // Update is called once per frame
    void FixedUpdate()
    {
        EnemyNum = GameObject.FindGameObjectsWithTag("Enemy");
        
        counter += Time.deltaTime;
        lazerSpawnTime += Time.deltaTime;
        if (counter >= spawnInterval && EnemyNum.Length < maxSpawnNum)
        {
            counter = 0f;
            //SpawnEnemy();
            //LaserSpawnEnemy();
        }
        
    }

    private void SpawnEnemy()
    {
        int r = Random.Range(0, spawnPoint.Length);
        while (r == randomGenerated)
        {
            r = Random.Range(0, spawnPoint.Length);
        }
        randomGenerated = r;

        float offset = Random.Range(-1f, 1f);
        Vector3 spawnPosition = new Vector3(spawnPoint[r].transform.position.x + offset, spawnPoint[r].transform.position.y, spawnPoint[r].transform.position.z);

        Instantiate(enemy[0], spawnPosition, Quaternion.identity).transform.parent = null;
    }

    public void LaserSpawnEnemy(GameObject enemyobj, int len)
    {
        
            GameObject obj = Instantiate(enemyobj, spawnPoint[len].transform);
            obj.transform.parent = spawnPoint[len].transform;
            Vector3 spawnPosition = new Vector3(spawnPoint[len].transform.localPosition.x, 0f, 0f);
            obj.transform.localPosition = spawnPosition;
        
    }

}
