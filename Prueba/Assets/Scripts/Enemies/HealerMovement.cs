﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealerMovement : MonoBehaviour
{
    public float Speed;

    private void Update()
    {
        transform.position = transform.position + (Vector3.down * Speed * Time.deltaTime);
    }
}
