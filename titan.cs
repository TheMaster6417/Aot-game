﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titans : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("enemy died");

        animator.SetBool("IsDead", true);

        this.enabled = false;
       
   
    }

}
