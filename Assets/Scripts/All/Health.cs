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
    public GameObject WinScreen;
    public AudioClip DeathClip;
    public string DeadBoolName;
    public Animator myAnimator;
    public CapsuleCollider2D myCollider;


    private void Awake()
    {
        CurrentHealth = BaseHealth;
        IsAlive = true;
        myAnimator = GetComponent<Animator>();
        myCollider = GetComponent<CapsuleCollider2D>();
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

                if (myCollider != null)
                {
                    myCollider.enabled = false;
                }

                if (DeathScreen != null)
                {
                    DeathScreen.SetActive(true);
                }

                if (WinScreen != null)
                {
                    WinScreen.SetActive(true);
                }

                if (DeathClip != null)
                {
                    SoundHelper.PlaySound(DeathClip);
                }

                if(myAnimator != null)
                {
                    myAnimator.SetBool("IsExploding", true);
                }
                

                Destroy(this.gameObject, DelayBeforeDestroying);
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
