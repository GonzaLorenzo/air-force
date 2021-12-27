using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBurstAttackState : IState
{
    private StateMachine _fsm;
    private FinalBoss _enemy;
    private float _timePassed;
    private float _attackTime = 2f;

    public SecondBurstAttackState(StateMachine fsm, FinalBoss p)
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
        _enemy.SecondBurstAttack();

        if(_timePassed > 0)
        {
            _timePassed -= Time.deltaTime;
        }
        else
        {
            _fsm.ChangeState(EnemyStatesEnum.BurstAttack);
        }
    }
    
    public void OnExit()
    {
        _enemy.ResetShots();
    }

}
