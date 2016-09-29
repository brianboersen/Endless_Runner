using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth = 0;

    void Start()
    {
        currentHealth = startingHealth;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            currentHealth -= 10;
            Debug.Log("yay");
        }
    }

    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    PlayerMove playerMove;

    bool isDead;
    bool damaged;

    void Awake()
    {
        playerMove = GetComponent<PlayerMove>();
        currentHealth = startingHealth;
    }

    void onCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            damaged = true;
            currentHealth -= 10;
            healthSlider.value = currentHealth;
        }
    }

    void Update()
    {
        if (damaged = true)
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

