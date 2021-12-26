using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour, IObservable
{
    [SerializeField] private string ID;
    IObserver _myObserver;
    private EnemyBuilder enemyBuilder;
    private bool firstSpawn;

    void Awake()
    {
        firstSpawn = true;
        enemyBuilder = GameObject.Find("EnemyBuilder").GetComponent<EnemyBuilder>();
        Subscribe(enemyBuilder);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(firstSpawn)
        {
            NotifyToObservers(ID);
            firstSpawn = false;
        }

    }

    public void NotifyToObservers(string action)
    {
        _myObserver.Notify(action);
    }

    public void Subscribe(IObserver obs)
    {
        if (_myObserver == null)
        {
            _myObserver = obs;
        }
    }

    public void Unsubscribe(IObserver obs)
    {
        if (_myObserver != null)
        {
            _myObserver = null;
        }
    }
}
