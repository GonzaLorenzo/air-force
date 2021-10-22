using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    public Transform[] Waypoints;

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
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[WaypointNumber].transform.position, (Speed * Time.deltaTime));

        if (transform.position == Waypoints[WaypointNumber].transform.position)
        {
            WaypointNumber += 1;
        }
        else if (WaypointNumber == Waypoints.Length -1)
        {
            Destroy(this.gameObject);
        }
    }

    
}
