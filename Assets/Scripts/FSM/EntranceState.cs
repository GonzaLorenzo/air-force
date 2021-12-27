using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceState : IState
{
    private StateMachine _fsm;
    private FinalBoss _enemy;
    private float _timeMoving;
    private float _topTime = 2.5f;

    public EntranceState (StateMachine fsm, FinalBoss p)
    {
        _fsm = fsm;
        _enemy = p;
    }

    public void OnStart()
    {
        
    }

    public void OnUpdate()
    {
        if(_timeMoving < _topTime)
        {
            _timeMoving += Time.deltaTime;
            _enemy.EntranceVelocity();
        }
        else
        {
            _enemy.ZeroVelocity();
            _fsm.ChangeState(EnemyStatesEnum.BurstAttack);
        }
    }

    public void OnExit()
    {
        
    }
}
