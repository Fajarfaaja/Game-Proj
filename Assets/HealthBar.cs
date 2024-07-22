using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public float maxHealth = 100f;
    public float health;

    void Start()
    {
        health = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;
    }

    void Update()
    {
        if (healthSlider.value != health)
        {
            healthSlider.value = health;
        }
    }

    public void takeDamage(float damage) // Ubah menjadi public agar bisa diakses oleh peluru
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth); // Pastikan health tidak kurang dari 0
        if (health <= 0)
        {
            // Logika saat pemain mati
            Debug.Log("Player Dead");
        }
    }
}
