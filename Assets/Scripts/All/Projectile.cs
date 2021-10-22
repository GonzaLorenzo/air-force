using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D  myRigidBody2D;
    public float        Speed;
    public float DestroyTime = 3f;

    private void Start()
    {
        myRigidBody2D.AddForce(transform.up * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }

    private void Update()
    {
        DestroyTime -= Time.deltaTime;

        if (DestroyTime <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}

