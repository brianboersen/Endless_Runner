using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{ 
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            Destroy(other.gameObject);
        }
    }
}