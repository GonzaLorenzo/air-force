using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLevel2 : MonoBehaviour
{
    public PlayerAttack         myPlayerAttack;
    public PlayerMovement       myPlayerMovement;
    public BackgroundScrolling  myBackground;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlayerAttack.CanAttack = true;
        myPlayerMovement.CanMove = true;

        if(myBackground != null)
        {
            myBackground.CanScroll = true;
        }

        Destroy(this.gameObject);
    }
}
