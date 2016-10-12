using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{
    private float cooldown = 1f;
    public float cdTimer;
    private bool cdOn;

    void Start()
    {
        cdOn = true;
    }

    void OnCollisionEnter(Collision other)
    {
        if(Input.GetKeyDown("e"))
        {
            if (other.gameObject.tag == "enemy")
            {
                Destroy(other.gameObject);
            }
        }

    }
}