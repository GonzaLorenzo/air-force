using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthJet : MonoBehaviour
{
    public int              BaseHealth;
    public int              CurrentHealth;
    public bool             IsAlive;
    public float            DelayBeforeDestroying;
    public AudioClip        DeathClip;
    public HealthJetReward  myReward;
    Animator myAnimator;

    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
        CurrentHealth = BaseHealth;
        IsAlive = true;
    }

    public void TakeDamage(int amount)
    {
        if (IsAlive && amount > 0)
        {
            CurrentHealth -= amount;

            if (CurrentHealth <= 0)
            {
                IsAlive = false;
                Destroy(this.gameObject, DelayBeforeDestroying);
                myAnimator.SetBool("IsExploding", true);
                SoundHelper.PlaySound(DeathClip);
            }
                
            if (myReward != null)
            {
                myReward.DropReward();
            }
        }
    }
}
