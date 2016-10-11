﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public GameObject canvas;
    private Click_functions lvlMeneger;
    private int startingHealth = 3;
    public int currentHealth = 0;

    public Slider healthSlider;
    public Image damageImage;
    private float flashSpeed = 5f;
    private Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    
    public PlayerMove playerMove;

    bool isDead;
    private bool damaged = false;


    void Start()
    {
       
        lvlMeneger = canvas.GetComponent <Click_functions>();
        currentHealth = startingHealth;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            damaged = true;
            currentHealth -= 1;
            healthSlider.value = currentHealth;
            Debug.Log(currentHealth);
        }
    }


    void Awake()
    {
        playerMove = GetComponent<PlayerMove>();
        currentHealth = startingHealth;
    }


    void Update()
    {
        if (currentHealth <= 0)
        {
            lvlMeneger.LoadScene(2);
        }

        if (damaged == true)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }
}

