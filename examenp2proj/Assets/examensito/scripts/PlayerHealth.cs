using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    // slider de vida
    public Slider healthSlider;

    void Start()
    {
        // iniciar vida
        currentHealth = maxHealth;

        // configurar slider
        healthSlider.maxValue = maxHealth;

        // actualizar barra
        UpdateHealthBar();
    }

    public override void TakeDamage(float damage)
    {
        // usar daño de la clase base
        base.TakeDamage(damage);

        // actualizar barra
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        healthSlider.value = currentHealth;
    }

    protected override void Die()
    {
        Debug.Log("Player died");

        Destroy(gameObject);
    }
}