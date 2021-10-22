using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public int amount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health HitHealth = collision.GetComponent<Health>();
        HealthJet HitHealthJet = collision.GetComponent<HealthJet>();

        if (HitHealth != null)
        {
            HitHealth.TakeDamage(amount);
        }

        if(HitHealthJet != null)
        {
            HitHealthJet.TakeDamage(amount);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health HitHealth = collision.gameObject.GetComponent<Health>();
        HealthJet HitHealthJet = collision.gameObject.GetComponent<HealthJet>();

        if (HitHealth != null)
        {
            HitHealth.TakeDamage(amount);
        }

        if (HitHealthJet != null)
        {
            HitHealthJet.TakeDamage(amount);
        }
    }

}
