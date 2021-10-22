using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChanger : MonoBehaviour
{
    public EnemyMovement    myEnemyMovement;
    public GameObject       PlayerAlert; 
    public GameObject       HealthEnemy;
    public Transform        SpawnPoint;
    public float            DelayBeforeClose;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myEnemyMovement.Speed = 8;

        PlayerAlert.SetActive(true);

        Instantiate(HealthEnemy, SpawnPoint.position, Quaternion.identity);

        StartCoroutine(CloseAlert());
    }

    IEnumerator CloseAlert()
    {
        yield return new WaitForSeconds(DelayBeforeClose);
        PlayerAlert.SetActive(false);
        Destroy(this.gameObject);
    }
}
