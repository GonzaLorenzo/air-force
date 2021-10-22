using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float Speed;

    private void Awake()
    {
        Speed = 5;
    }
    private void Update()
    {
        transform.position = transform.position + (Vector3.down * Speed * Time.deltaTime);
    }
}
