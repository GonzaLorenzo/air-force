using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBomb : MonoBehaviour
{
    public Rigidbody2D  myRigidBody2D;
    public GameObject explosion;
    public float        speed;
    private float _timePassed;
    private float _shootTime = 1f;
    Transform shotPoint1;
    Transform shotPoint2;
    Transform shotPoint3;
    Transform shotPoint4;
    Transform shotPoint5;
    Transform shotPoint6;
    Transform shotPoint7;
    Transform shotPoint8;
    [SerializeField] BombProjectile bombPrefab;

    void Awake()
    {
        _timePassed = _shootTime;
        myRigidBody2D = GetComponent<Rigidbody2D>();
        shotPoint1 = transform.GetChild(0);
        shotPoint2 = transform.GetChild(1);
        shotPoint3 = transform.GetChild(2);
        shotPoint4 = transform.GetChild(3);
        shotPoint5 = transform.GetChild(4);
        shotPoint6 = transform.GetChild(5);
        shotPoint7 = transform.GetChild(6);
        shotPoint8 = transform.GetChild(7);

    }
    private void Start()
    {
        //myRigidBody2D.AddForce(Vector2.down * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    private void Update()
    {
        if(_timePassed > 0)
        {
            _timePassed -= Time.deltaTime;
            myRigidBody2D.AddForce(Vector2.down * speed);
        }
        else
        {
            myRigidBody2D.velocity = Vector2.zero;

            Vector2 dir1 = transform.position - shotPoint1.position;
            Vector2 dir2 = transform.position - shotPoint2.position;
            Vector2 dir3 = transform.position - shotPoint3.position;
            Vector2 dir4 = transform.position - shotPoint4.position;
            Vector2 dir5 = transform.position - shotPoint5.position;
            Vector2 dir6 = transform.position - shotPoint6.position;
            Vector2 dir7 = transform.position - shotPoint7.position;
            Vector2 dir8 = transform.position - shotPoint8.position;

            BombProjectile createdProjectile1 = Instantiate<BombProjectile>(bombPrefab, shotPoint1.position, Quaternion.identity);
            createdProjectile1.SetDestination(dir1);
            BombProjectile createdProjectile2 = Instantiate<BombProjectile>(bombPrefab, shotPoint2.position, Quaternion.identity);
            createdProjectile2.SetDestination(dir2);
            BombProjectile createdProjectile3 = Instantiate<BombProjectile>(bombPrefab, shotPoint3.position, Quaternion.identity);
            createdProjectile3.SetDestination(dir3);
            BombProjectile createdProjectile4 = Instantiate<BombProjectile>(bombPrefab, shotPoint4.position, Quaternion.identity);
            createdProjectile4.SetDestination(dir4);
            BombProjectile createdProjectile5 = Instantiate<BombProjectile>(bombPrefab, shotPoint5.position, Quaternion.identity);
            createdProjectile5.SetDestination(dir5);
            BombProjectile createdProjectile6 = Instantiate<BombProjectile>(bombPrefab, shotPoint6.position, Quaternion.identity);
            createdProjectile6.SetDestination(dir6);
            BombProjectile createdProjectile7 = Instantiate<BombProjectile>(bombPrefab, shotPoint7.position, Quaternion.identity);
            createdProjectile7.SetDestination(dir7);
            BombProjectile createdProjectile8 = Instantiate<BombProjectile>(bombPrefab, shotPoint8.position, Quaternion.identity);
            createdProjectile8.SetDestination(dir8);

            Destroy(this.gameObject);
        }
    }
}

