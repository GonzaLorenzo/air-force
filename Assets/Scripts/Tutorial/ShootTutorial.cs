using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTutorial : MonoBehaviour
{
    public KeyCode              CloseKey = KeyCode.J;
    public float                DelayBeforeEnemy;
    public GameObject           STutorialContainer;
    public GameObject           Enemy;
    public GameObject           AllyBlock;
    public PlayerMovement       myPlayerMovement;
    public BackgroundScrolling  myBackground;
    public EnemySpawner         myEnemySpawner;
    public Transform            SpawnPoint;
    public bool                 EnemySpawned;
    public AllyMovement         myAlly;
    public FollowWaypoints      myWaypoints;
    private void Update()
    {
        if (Input.GetKeyDown(CloseKey))
        {
            if (STutorialContainer != null && STutorialContainer.activeSelf == true)
            {
                STutorialContainer.SetActive(false);

                myPlayerMovement.CanMove = true;

                StartCoroutine(SpawnTutorialEnemy());

                myEnemySpawner.StartSpawning();

                myBackground.CanScroll = true;

                myAlly.CanMove = true;

                myWaypoints.CanMove = true;

                Destroy(AllyBlock);
            }
        }
    }

    IEnumerator SpawnTutorialEnemy()
    {
        yield return new WaitForSeconds(DelayBeforeEnemy);

        Instantiate(Enemy, SpawnPoint.position, Quaternion.identity);               
    }
}
