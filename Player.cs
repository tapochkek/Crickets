using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private int coins;
    public int health = 10;
    public AudioSource audioSource;
    public AudioClip damageSound;

    public Transform attackPoint;

    public GameObject fireBallPrefab;
    /*public AudioSource audiosource;
    public AudioClip damageSound;*/

    public void CollectCoins()
    {
        coins++;
        print("Собранные монетки: " + coins);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("Здоровье игрока: " + health);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireBallPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
