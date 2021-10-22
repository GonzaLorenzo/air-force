using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int BaseHealth;
    public int CurrentHealth;
    public bool IsAlive;
    public float DelayBeforeDestroying;
    public HealthUI myUI;
    public GameObject DeathScreen;
    public AudioClip DeathClip;
    public string DeadBoolName;
    public Animator myAnimator;

    private void Awake()
    {
        CurrentHealth = BaseHealth;
        IsAlive = true;
    }

    public void TakeDamage(int amount)
    {
        if (IsAlive && amount > 0)
        {
            CurrentHealth -= amount;

            UpdateHealth();

            if (CurrentHealth <= 0)
            {
                IsAlive = false;
                Destroy(this.gameObject, DelayBeforeDestroying);

                if (DeathScreen != null)
                {
                    DeathScreen.SetActive(true);
                }

                if (DeathClip != null)
                {
                    SoundHelper.PlaySound(DeathClip);
                }

                if(myAnimator != null)
                {
                    myAnimator.SetBool(DeadBoolName, true);
                }
            }
        }
    }

    public void Heal(int amount)
    {
        if (IsAlive && amount > 0 && CurrentHealth < BaseHealth)
        {
            CurrentHealth += amount;

            if(CurrentHealth > BaseHealth)
            {
                CurrentHealth = BaseHealth;
            }

            UpdateHealth();
        }
    }

    public void UpdateHealth()
    {
        if (myUI != null)
        {
            myUI.UpdateHealth(CurrentHealth);
        }
    }
    

   
        
  
}
