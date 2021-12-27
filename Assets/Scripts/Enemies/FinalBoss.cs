using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{
    StateMachine _fsm;
    Transform shotPoint1;
    Transform shotPoint2;
    Rigidbody2D _rb;
    private int _shotsFired;
    private int _totalShots = 8;
    private GameObject _target;
    private float speed = 3f;
    private float _timePassed;
    private float _shootTime = 0.1f;

    [SerializeField] BossProjectile projectilePrefab;

    void Awake()
    {
        _timePassed = _shootTime;
        shotPoint1 = transform.GetChild(0);
        shotPoint2 = transform.GetChild(1);
        _rb = GetComponent<Rigidbody2D>();
        _target = GameObject.Find("Player");
        _fsm = new StateMachine();
        _fsm.AddState(EnemyStatesEnum.BombAttack, new BombAttackState(_fsm, this));
        _fsm.AddState(EnemyStatesEnum.BurstAttack, new BurstAttackState(_fsm, this));
        _fsm.AddState(EnemyStatesEnum.Entrance, new EntranceState(_fsm, this));
        _fsm.ChangeState(EnemyStatesEnum.Entrance);
    }

    void Update()
    {
        _fsm.OnUpdate();
    }

    public void EntranceVelocity()
    {
        _rb.velocity = Vector2.down * speed;
    }

    public void ZeroVelocity()
    {
        _rb.velocity = Vector2.zero;
    }

    public void ResetShots()
    {
        _shotsFired = 0;
    }

    public void BurstAttack()
    {
        if(_timePassed > 0)
        {
            _timePassed -= Time.deltaTime;
        }
        else if(_shotsFired < _totalShots && _target != null)
        {
            Vector2 dir1 = _target.transform.position - shotPoint1.position;
            Vector2 dir2 = _target.transform.position - shotPoint2.position;
            BossProjectile createdProjectile = Instantiate<BossProjectile>(projectilePrefab, shotPoint1.position, Quaternion.identity);
            BossProjectile createdProjectile1 = Instantiate<BossProjectile>(projectilePrefab, shotPoint2.position, Quaternion.identity);
            createdProjectile.SetDestination(dir1);
            createdProjectile1.SetDestination(dir2);
            
            _timePassed = _shootTime;
            _shotsFired ++;
        }   
    }
}
