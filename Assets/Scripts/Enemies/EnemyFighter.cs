using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFighter : Enemy
{
    Animator _myAnim;
    private bool canShoot;

    void Awake()
    {
        _myAnim = GetComponent<Animator>();
        canShoot = true;
    }

    void Update()
    {
        Patrol();
    }

    public void Shoot()
    {
        if(canShoot)
        {
            //Instantiate shooting
            canShoot = false;
        }
    }
}
