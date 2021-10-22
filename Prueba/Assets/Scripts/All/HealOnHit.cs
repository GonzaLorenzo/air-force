using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOnHit : MonoBehaviour
{
    public int amount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health HitHealth = collision.GetComponent<Health>();
        if (HitHealth != null)
        {
            HitHealth.Heal(amount);

            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health HitHealth = collision.gameObject.GetComponent<Health>();       
        if (HitHealth != null)
        {
            HitHealth.Heal(amount);

            Destroy(this.gameObject);
        }
    }
}
