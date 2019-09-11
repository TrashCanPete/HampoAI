
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public GameObject explosion;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

        void Die()
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
