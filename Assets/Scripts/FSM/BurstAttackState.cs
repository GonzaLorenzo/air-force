using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstAttackState : IState
{
    private StateMachine _fsm;
    private FinalBoss _enemy;
    private float _timeShooting;
    private float _topTime = 3f;
    public BurstAttackState(StateMachine fsm, FinalBoss p)
    {
        _fsm = fsm;
        _enemy = p;
    }

    public void OnStart()
    {
        
    }

    public void OnUpdate()
    {
        _enemy.BurstAttack();
    }
    
    public void OnExit()
    {
        _enemy.ResetShots();
    }

}
