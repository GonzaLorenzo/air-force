using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLevel2 : MonoBehaviour
{
    public PlayerAttack         myPlayerAttack;
    public PlayerMovement       myPlayerMovement;
    //public EnemySpawner         mySpawner;
    public BackgroundScrolling  myBackground;
    public EnemyMovement        myEnemyMovement;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlayerAttack.CanAttack = true;
        myPlayerMovement.CanMove = true;
        //mySpawner.StartSpawning();
        myBackground.CanScroll = true;

        Destroy(this.gameObject);
    }
}
