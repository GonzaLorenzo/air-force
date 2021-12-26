using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public List<Transform> waypoints;
    private int _currentWaypoint;
    public float speed;
    protected bool canShoot;

    public void Patrol()
    {
        Vector3 dir = waypoints[_currentWaypoint].position - transform.position;
        Vector3 actualDir = dir.normalized;
        //transform.up = dir.normalized;
        transform.position += actualDir * speed * Time.deltaTime;

        if(dir.magnitude < 0.1f)
        {
            _currentWaypoint++;
            if(_currentWaypoint > waypoints.Count - 1)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public Enemy SetPos (Vector3 newPos)
    {
        transform.position = newPos;
        return this;
    }

    public Enemy SetWaypoints (List<Transform> newWaypoints)
    {
        waypoints = newWaypoints;
        return this;
    }
}
