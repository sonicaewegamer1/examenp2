using UnityEngine;

public class Health : MonoBehaviour
{
    // vida maxima
    public float maxHealth = 100f;

    // vida actual
    protected float currentHealth;

    void Start()
    {
        // iniciar vida
        currentHealth = maxHealth;
    }

    // recibir daño
    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;

        Debug.Log(gameObject.name + " HP: " + currentHealth);

        // verificar si murió
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // muerte
    protected virtual void Die()
    {
        Debug.Log(gameObject.name + " died");

        Destroy(gameObject);
    }
}