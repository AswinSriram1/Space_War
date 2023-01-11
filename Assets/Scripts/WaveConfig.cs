using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="enemy wave config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPreFab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

       
    public GameObject GetEnemyPrefab() { return enemyPrefab; }

    public List<Transform> GetWayPoints()
    {
        var WaveWaypoints = new List<Transform>();
        foreach(Transform child in pathPreFab.transform)
        {
            WaveWaypoints.Add(child);
        }
        return WaveWaypoints;
    }

    public float GetTimeBetweenSpawns() { return timeBetweenSpawns; }

    public float GetSpawnRandomFactor() { return spawnRandomFactor; }

    public int GetNumderOfEnemies() { return numberOfEnemies; }

    public float GetmoveSpeed() { return moveSpeed; }


}
