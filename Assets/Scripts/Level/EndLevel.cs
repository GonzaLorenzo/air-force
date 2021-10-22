using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public PlayerMovement       myPlayerMovement;
    public PlayerAttack         myPlayerAttack;
    public GameObject           PlayerWall;
    public BackgroundScrolling  myBackground;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlayerMovement.CanMove = false;
        myPlayerMovement.CanEndLevel = true;
        myPlayerAttack.CanAttack = false;       
        myBackground.CanScroll = false;

        Destroy(PlayerWall);
    }
}
