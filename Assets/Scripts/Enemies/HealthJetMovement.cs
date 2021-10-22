using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthJetMovement : MonoBehaviour
{
    public float Speed;

    private void Update()
    {
        transform.position = transform.position + (Vector3.left * Speed * Time.deltaTime);
    }
}
