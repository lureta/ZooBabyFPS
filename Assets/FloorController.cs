using UnityEngine;

public class FloorController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collider that collided with the floor is tagged as a character
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody characterRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            // Stop the character from falling by resetting its velocity to zero
            characterRigidbody.velocity = Vector3.zero;

            // Alternatively, you can set the character's position to prevent it from falling through
            // collision.gameObject.transform.position = new Vector3(x, y, z);
        }
    }
}