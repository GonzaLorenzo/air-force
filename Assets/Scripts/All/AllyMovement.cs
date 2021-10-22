using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyMovement : MonoBehaviour
{
    public float        Speed;
    public bool         CanMove;
    public GameObject   MTutorialContainer;

    private void Awake()
    {
        CanMove = true;
    }
    private void Update()
    {
        if (CanMove == true)
        {
            transform.position = transform.position + (Vector3.up * Speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopMoving();
        ShowMTutorial();
    }

    public void StopMoving()
    {
        CanMove = false;
    }

    public void KeepMoving()
    {
        CanMove = true;
    }

    public void ShowMTutorial()
    {
        if(MTutorialContainer != null)
        {
            MTutorialContainer.SetActive(true);
        }
    }
}
