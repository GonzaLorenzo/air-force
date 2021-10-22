using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public float Speed;
    public bool CanScroll;

    private void Awake()
    {
        CanScroll = false;
    }
    void Update()
    {
        if (CanScroll == true)
        {
            transform.position = transform.position + (Vector3.down * Speed * Time.deltaTime);
        }
    }

}
