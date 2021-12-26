using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFighter : Enemy, IShooter
{
    Animator _myAnim;
    private float viewDistance = 100f;
    Transform shotPoint;

    [SerializeField]
    GameObject projectilePrefab;
    public LayerMask playerMask;
    
    void Awake()
    {
        _myAnim = GetComponent<Animator>();
        canShoot = true;
        shotPoint  = transform.GetChild(0);
    }

    void Update()
    {
        Patrol();
        Shoot();
    }

    public void Shoot()
    {
        //Vector2 dir = shotPoint.position + Vector3.down * viewDistance;

        RaycastHit2D hit = Physics2D.Raycast(shotPoint.position, Vector2.down, viewDistance, playerMask);
        
        if(hit == true && canShoot)
        {   
            Instantiate(projectilePrefab, shotPoint.position, Quaternion.identity);
            canShoot = false;
        }
    }
}
