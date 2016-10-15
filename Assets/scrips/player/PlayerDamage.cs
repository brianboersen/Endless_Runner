using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{
    private IEnumerator coroutine;

    private bool cdOn;

    void Start()
    {
        cdOn = false;

        coroutine = WaitAndPrint(2.5f);
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            cdOn = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy" && cdOn == true)
        {
            Destroy(other.gameObject);
            cdOn = false;
        }
    }

    void Update()
    {
        if (cdOn == false)
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}