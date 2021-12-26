using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBuilder : MonoBehaviour, IObserver
{
    public Enemy enemyFighter;
    public Enemy enemyHealer;
    private int _spawnedEnemies;
    private int _firstEnemiesToSpawn = 6;
    private int _secondEnemiesToSpawn = 7;
    private int _thirdEnemiesToSpawn = 4;
    private int _fourthEnemiesToSpawn = 1;
    private int _fifthEnemiesToSpawn = 4;
    private int _sixthEnemiesToSpawn = 3;
    private int _seventhEnemiesToSpawn = 5;
    private int _eighthEnemiesToSpawn = 3;
    private int _ninthEnemiesToSpawn = 6;
    private int _tenthEnemiesToSpawn = 3;
    private int _eleventhEnemiesToSpawn = 4;



    [Header("First Spawn")]
    public Vector3 FirstEnemyPos;
    public List<Transform> FirstEnemyWaypoints;

    [Header("Second Spawn")]
    public Vector3 SecondEnemyPos;
    public Vector3 SecondEnemyPos1;
    public List<Transform> SecondEnemyWaypoints; 
    public List<Transform> SecondEnemyWaypoints1; 

    [Header("Third Spawn")]
    public Vector3 ThirdEnemyPos;    
    public List<Transform> ThirdEnemyWaypoints;

    [Header("Fourth Spawn")]
    public Vector3 FourthEnemyPos;    
    public List<Transform> FourthEnemyWaypoints;
    
    [Header("Fifth Spawn")]
    public Vector3 FifthEnemyPos;    
    public List<Transform> FifthEnemyWaypoints;

    [Header("Sixth Spawn")]
    public Vector3 SixthEnemyPos;    
    public List<Transform> SixthEnemyWaypoints;

    [Header("Seventh Spawn")]
    public Vector3 SeventhEnemyPos;    
    public List<Transform> SeventhEnemyWaypoints;

    [Header("Eighth Spawn")]
    public Vector3 EighthEnemyPos;    
    public Vector3 EighthEnemyPos1;    
    public List<Transform> EighthEnemyWaypoints;    
    public List<Transform> EighthEnemyWaypoints1;    

    [Header("Ninth Spawn")]
    public Vector3 NinthEnemyPos;    
    public List<Transform> NinthEnemyWaypoints;

    [Header("Tenth Spawn")]
    public Vector3 TenthEnemyPos;    
    public List<Transform> TenthEnemyWaypoints;

    [Header("Eleventh Spawn")]
    public Vector3 EleventhEnemyPos;    
    public List<Transform> EleventhEnemyWaypoints;

    public IEnumerator SpawnFirstEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _firstEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(FirstEnemyPos).SetWaypoints(FirstEnemyWaypoints);
            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.3f);
        }
    }

    public IEnumerator SpawnSecondEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _secondEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(SecondEnemyPos).SetWaypoints(SecondEnemyWaypoints);
            Instantiate(enemyFighter).SetPos(SecondEnemyPos1).SetWaypoints(SecondEnemyWaypoints1);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator SpawnThirdEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _thirdEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(ThirdEnemyPos).SetWaypoints(ThirdEnemyWaypoints);
            //Instantiate(enemyFighter).SetPos(ThirdEnemyPos1).SetWaypoints(ThirdEnemyWaypoints1);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }
    public IEnumerator SpawnFourthEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _fourthEnemiesToSpawn)
        {
            Instantiate(enemyHealer).SetPos(FourthEnemyPos).SetWaypoints(FourthEnemyWaypoints);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator SpawnFifthEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _fifthEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(FifthEnemyPos).SetWaypoints(FifthEnemyWaypoints);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator SpawnSixthEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _sixthEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(SixthEnemyPos).SetWaypoints(SixthEnemyWaypoints);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator SpawnSeventhEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _seventhEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(SeventhEnemyPos).SetWaypoints(SeventhEnemyWaypoints);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator SpawnEighthEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _eighthEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(EighthEnemyPos).SetWaypoints(EighthEnemyWaypoints);
            Instantiate(enemyFighter).SetPos(EighthEnemyPos1).SetWaypoints(EighthEnemyWaypoints1);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator SpawnNinthEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _ninthEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(NinthEnemyPos).SetWaypoints(NinthEnemyWaypoints);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator SpawnTenthEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _tenthEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(TenthEnemyPos).SetWaypoints(TenthEnemyWaypoints);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator SpawnEleventhEnemies()
    {
        _spawnedEnemies = 0;
        while(_spawnedEnemies < _eleventhEnemiesToSpawn)
        {
            Instantiate(enemyFighter).SetPos(EleventhEnemyPos).SetWaypoints(EleventhEnemyWaypoints);

            _spawnedEnemies ++;
            yield return new WaitForSeconds(0.2f);
        }
    }


    public void Notify(string action)
    {
        switch(action)
        {
            case "FirstSpawn":
                StartCoroutine(SpawnFirstEnemies());
                break;
            case "SecondSpawn":
                StartCoroutine(SpawnSecondEnemies());
                break;
            case "ThirdSpawn":
                StartCoroutine(SpawnThirdEnemies());
                break;
            case "FourthSpawn":
                StartCoroutine(SpawnFourthEnemies());
                break;
            case "FifthSpawn":
                StartCoroutine(SpawnFifthEnemies());
                break;
            case "SixthSpawn":
                StartCoroutine(SpawnSixthEnemies());
                break;
            case "SeventhSpawn":
                StartCoroutine(SpawnSeventhEnemies());
                break;
            case "EighthSpawn":
                StartCoroutine(SpawnEighthEnemies());
                break;
            case "NinthSpawn":
                StartCoroutine(SpawnNinthEnemies());
                break;
            case "TenthSpawn":
                StartCoroutine(SpawnTenthEnemies());
                break;
            case "EleventhSpawn":
                StartCoroutine(SpawnEleventhEnemies());
                break;

        }
    }
}
