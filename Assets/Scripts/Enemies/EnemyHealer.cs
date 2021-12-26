using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealer : Enemy
{
    Animator _myAnim;
    
    void Awake()
    {
        _myAnim = GetComponent<Animator>();
    }

    void Update()
    {
        Patrol();
    }


}
