using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandCreator : MonoBehaviour
{
    public List<GameObject> RockSpawnpoints;
    public List<GameObject> RockPrefab;
    public float SpawnArea = 1000;

    void Start()
    {
        foreach (GameObject point in RockSpawnpoints)
        {
            Vector3 randomOffset = new Vector3(
                Random.Range(-SpawnArea, SpawnArea),
                0f,
                Random.Range(-SpawnArea, SpawnArea)
            );

            Vector3 randomRot = new Vector3(0f, Random.Range(0f, 360f), 360f);

            GameObject prefabToSpawn = RockPrefab[Random.Range(0, RockPrefab.Count)];

            GameObject spawnedObject = Instantiate(
                prefabToSpawn,
                point.transform.position + randomOffset,
                Quaternion.Euler(randomRot)
            );

            Instantiate(spawnedObject);
        }
    }
    void Update()
    {
        
    }
}
