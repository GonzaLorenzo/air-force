using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSpawn : MonoBehaviour
{
    public EnemySpawner myEnemySpawner;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(myEnemySpawner);   
    }
}
