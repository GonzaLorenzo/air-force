using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAttackState : IState
{
    private StateMachine _fsm;
    private FinalBoss _enemy;
    private float _timePassed;
    private float _attackTime = 1.5f;

    public BombAttackState (StateMachine fsm, FinalBoss p)
    {
        _fsm = fsm;
        _enemy = p;
    }

    public void OnStart()
    {
        _timePassed = _attackTime;
       _enemy.BombAttack();
    }

    public void OnUpdate()
    {
        if(_timePassed > 0)
        {
            _timePassed -= Time.deltaTime;
        }
        else
        {
            _fsm.ChangeState(EnemyStatesEnum.SecondBurstAttack);
        }
    }

    public void OnExit()
    {
        
    }
}
