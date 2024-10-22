using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    [Serializable]
    public struct EntityStats
    {
        public float MaxHealth;
        public float MovementSpeed;
    }

<<<<<<< HEAD
    [NonSerialized]
    public float CurrentHealth;

    bool dead = false;

    public EntityStats stats;

=======
    public EntityStats stats;

    [NonSerialized]
    public float CurrentHealth;
    bool dead = false;

>>>>>>> upstream/workshop-3-complete
    private void Start()
    {
        CurrentHealth = stats.MaxHealth;
    }

<<<<<<< HEAD
=======
    public void TakeDamage(float damage)
    {
        CurrentHealth -= Mathf.Ceil(damage);

        if (CurrentHealth <=0)
        {
            Die();
        }
    }

>>>>>>> upstream/workshop-3-complete
    private void Die()
    {
        dead = true;
        Destroy(gameObject);
    }
<<<<<<< HEAD

    public void TakeDamage(float damage)
    {
        if (dead)
        {
            return;
        }

        CurrentHealth -= Mathf.Ceil(damage);

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
=======
>>>>>>> upstream/workshop-3-complete
}