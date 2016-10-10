using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("sdfghj");
        if (other.gameObject.tag == "Enemy1")
        {
            Debug.Log("ouch");
            Destroy(other.gameObject);
        }
    }
}