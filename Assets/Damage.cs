using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int DMG;
    float cooldown = 0f;

    private void Update()
    {
        cooldown -= Time.deltaTime;
    }

    private void OnCollisionStay(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        if (cooldown <= 0)
        {
            if (health != null)
            {
                health.TakeDamage(DMG);
            }
            cooldown = 1f;
        }
    }
}
