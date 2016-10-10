using UnityEngine;
using System.Collections;

public class lvlMovement : MonoBehaviour {
    private GameObject[] spawnedBackgrounds;
    private GameObject[] spawnedPlatforms;
    private GameObject[] spawnedOjects;
    private GameObject[] spawnedEnemies;

    private Vector3 move;
    private float speed = 6;

	void FixedUpdate ()
    {
        move = new Vector3(speed * Time.deltaTime, 0, 0);

        spawnedBackgrounds = GameObject.FindGameObjectsWithTag("bg");
        spawnedPlatforms = GameObject.FindGameObjectsWithTag("platform");
        spawnedOjects = GameObject.FindGameObjectsWithTag("object");
        spawnedEnemies = GameObject.FindGameObjectsWithTag("enemy");

        for (int i = 0; i < spawnedPlatforms.Length; i++)
        {
            spawnedPlatforms[i].transform.position -= move;

            if (spawnedPlatforms[i].transform.position.x <= -40)
            {
                Destroy(spawnedPlatforms[i]);
                
            }
        }

        for (int i = 0; i < spawnedOjects.Length; i++)
        {
            spawnedOjects[i].transform.position -= move;

            if (spawnedOjects[i].transform.position.x < -40)
            {
                Destroy(spawnedOjects[i]);
            }
        }

        for (int j = 0; j < spawnedBackgrounds.Length; j++)
        {
            spawnedBackgrounds[j].transform.position -= move;
            if (spawnedBackgrounds[j].transform.position.x < -40)
            {
                Destroy(spawnedBackgrounds[j]);
            }

        }
        for (int j = 0; j < spawnedEnemies.Length; j++)
        {
            spawnedEnemies[j].transform.position -= move;
            if (spawnedEnemies[j].transform.position.x < -40)
            {
                Destroy(spawnedEnemies[j]);
            }

        }
    }
}
