using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfigs;
    [SerializeField] int startingWave = 0;
    [SerializeField] bool looping = false;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        do
        {


            yield return StartCoroutine(SpawnAllWaves());
        }
        while (looping);
    }
    private IEnumerator SpawnAllWaves()
    {
        for(int waveIndex = startingWave; waveIndex < waveConfigs.Count; waveIndex++)
        {
            var currentWave = waveConfigs[waveIndex];
            yield return StartCoroutine(SpawAllEnemiesInWave(currentWave));
        }
    }
    private IEnumerator SpawAllEnemiesInWave(WaveConfig waveConFig)
    {
        for (int enemyCount = 0; enemyCount < waveConFig.GetNumderOfEnemies(); enemyCount++)
        {
            var newEnemy = Instantiate(waveConFig.GetEnemyPrefab(), waveConFig.GetWayPoints()[0].transform.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyPathing>().SetWaveConfig(waveConFig);
            yield return new WaitForSeconds(waveConFig.GetTimeBetweenSpawns());
        }
    }
    
    
}
