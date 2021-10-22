using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public KeyCode      AttackKey;
    public GameObject   ProjectilePrefab;
    public GameObject   SpawnedProjectile;
    public Transform    ShotPoint1;
    public Transform    ShotPoint2;
    public float        ShotSpeed;
    public Health       myHealth;
    public AudioClip    ShotClip;
    public bool         CanAttack;
    void Update()
    {
        if (myHealth.IsAlive && Time.timeScale != 0f && CanAttack)
        {
            if (Input.GetKeyDown(AttackKey))
            {
                SpawnedProjectile = Instantiate(ProjectilePrefab, ShotPoint1.position, Quaternion.identity);

                SpawnedProjectile = Instantiate(ProjectilePrefab, ShotPoint2.position, Quaternion.identity);

                SpawnedProjectile.transform.up = SpawnedProjectile.transform.up * ShotSpeed;

                if (ShotClip != null)
                {
                    SoundHelper.PlaySound(ShotClip);
                }

            }
        }
    }
}
