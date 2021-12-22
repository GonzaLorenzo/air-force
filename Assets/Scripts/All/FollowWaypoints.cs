using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    public List<Transform> waypoints;
    private int _currentWaypoint = 0;
    public float        Speed;
    int                 WaypointNumber = 0;
    public bool         CanMove;
    private void Update()
    {
        if (CanMove == true)
        {
            Move();
        }
    }

    private void Move()
    {
        /* transform.position = Vector2.MoveTowards(transform.position, Waypoints[WaypointNumber].transform.position, (Speed * Time.deltaTime));

        if (transform.position == Waypoints[WaypointNumber].transform.position)
        {
            WaypointNumber += 1;
        }
        else if (WaypointNumber == Waypoints.Length -1)
        {
            Destroy(this.gameObject);
        } */

        Vector3 dir = waypoints[_currentWaypoint].position - transform.position;
        Vector3 actualDir = dir.normalized;
        transform.up = dir.normalized;
        transform.position += actualDir * Speed * Time.deltaTime;

        if(dir.magnitude < 0.1f)
        {
            _currentWaypoint++;
            if(_currentWaypoint > waypoints.Count - 1)
            {
                Destroy(this.gameObject);
            }
        }
    }

    
}
