using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject   Enemy;
    public float        DelayBetweenSpawns = 1f;
    public float        SpawnRadius = 0f;
    public bool         KeepSpawning;

   public void StartSpawning()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }
    IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(DelayBetweenSpawns);
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
      Instantiate(Enemy, transform.position + (Vector3)Random.insideUnitCircle * SpawnRadius, Quaternion.identity);         
    }
}
