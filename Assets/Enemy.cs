using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;
    [SerializeField] float health, maxHealth = 3f;

    public void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        source.PlayOneShot(clip);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
