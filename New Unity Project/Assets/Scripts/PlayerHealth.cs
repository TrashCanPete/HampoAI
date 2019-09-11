using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject player;
    public int startingHealth = 100;                         
    public int currentHealth;

    public void TakeDamage(int amount)
    {
       currentHealth -= amount;
        if (currentHealth <= 0)
            {
                GameOver();
            }
    }
    void GameOver()
    {
        gameOver.SetActive(true);
    }
}
