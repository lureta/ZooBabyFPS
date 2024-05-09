using UnityEngine;
public class BulletHit : MonoBehaviour
{
    public float damage;

    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dummie"))
        {
            other.GetComponent<PlayerStats1>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}