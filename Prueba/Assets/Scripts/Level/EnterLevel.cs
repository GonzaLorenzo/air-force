using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLevel : MonoBehaviour
{
    public PlayerMovement   myPlayerMovement;
    public GameObject       Walls;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlayerMovement.CanEndLevel = false;
        Walls.SetActive(true);
        Destroy(this.gameObject);
    }
}
