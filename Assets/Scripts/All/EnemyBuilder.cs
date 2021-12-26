using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBuilder : MonoBehaviour, IObserver
{
    public Enemy enemyFighter;
    public Enemy enemyHealer;

    [Header("First Spawn")]
    public Vector3 FirstLvlEnemy1Pos;
    public List<Transform> FirstLvlEnemy1Waypoints;

    [Header("Second Spawn")]
    public Vector3 SecondLvlEnemy1Pos;
    public List<Transform> SecondLvlEnemy1Waypoints; 

    [Header("Third Spawn")]
    public Vector3 ThirdLvlEnemy1Pos;    
    public List<Transform> ThirdLvlEnemy1Waypoints;

    private void InstantiateFirstEnemies()
    {
        Instantiate(enemyFighter).SetPos(FirstLvlEnemy1Pos).SetWaypoints(FirstLvlEnemy1Waypoints);
        
    }

    private void InstantiateSecondEnemies()
    {
        Instantiate(enemyFighter).SetPos(SecondLvlEnemy1Pos).SetWaypoints(SecondLvlEnemy1Waypoints);
    }

    private void InstantiateThirdEnemies()
    {
        Instantiate(enemyFighter).SetPos(ThirdLvlEnemy1Pos).SetWaypoints(ThirdLvlEnemy1Waypoints);
    }

    public void Notify(string action)
    {
        if(action == "FirstSpawn")
        {
            InstantiateFirstEnemies();
        }
        else if (action == "SecondSpawn")
        {
            InstantiateSecondEnemies();
        }
    }
}
