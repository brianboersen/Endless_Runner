using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    
    private Click_functions lvlMeneger;
    private int startingHealth = 3;
    private int currentHealth = 0;
    private float flashSpeed = 5f;
    private Color flashColour = new Color(1f, 0f, 0f, 0.1f);


    public GameObject canvas;
    public Slider healthSlider;
    public Image damageImage;
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

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "LaserGrid")
        {
            currentHealth = 0;
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

