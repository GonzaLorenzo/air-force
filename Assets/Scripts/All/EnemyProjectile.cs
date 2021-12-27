using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public Rigidbody2D  myRigidBody2D;
    public GameObject explosion;
    public float        speed;
    public float        destroyTime = 3f;

    void Awake()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        myRigidBody2D.AddForce(Vector2.down * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    private void Update()
    {
        destroyTime -= Time.deltaTime;

        if (destroyTime <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}

