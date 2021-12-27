using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAttackState : IState
{
    private StateMachine _fsm;
    private FinalBoss _enemy;

    public BombAttackState (StateMachine fsm, FinalBoss p)
    {
        _fsm = fsm;
        _enemy = p;
    }

    public void OnStart()
    {
       
    }

    public void OnUpdate()
    {
        
    }

    public void OnExit()
    {
        
    }
}
