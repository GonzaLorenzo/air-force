﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstAttackState : IState
{
    private StateMachine _fsm;
    private FinalBoss _enemy;
    private float _timePassed;
    private float _attackTime = 2f;

    public BurstAttackState(StateMachine fsm, FinalBoss p)
    {
        _fsm = fsm;
        _enemy = p;
    }

    public void OnStart()
    {
        _timePassed = _attackTime;
    }

    public void OnUpdate()
    {
        _enemy.BurstAttack();
        
        if(_timePassed > 0)
        {
            _timePassed -= Time.deltaTime;
        }
        else
        {
            _fsm.ChangeState(EnemyStatesEnum.BombAttack);
        }
    }
    
    public void OnExit()
    {
        _enemy.ResetShots();
    }

}
