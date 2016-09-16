using UnityEngine;
using System.Collections;

public class endless : MonoBehaviour {
    public GameObject plat;
    public GameObject[] ojects;
    public GameObject[] backgrounds;

    private GameObject[] spawnedBackgrounds;
    private GameObject[] spawnedPlatforms;
    private GameObject[] spawnedOjects;

    private Vector3 bgSpawn;
    private Vector3 objSpawn;
    private Vector3 platformSpawnpoint;



    Quaternion q = Quaternion.Euler(-90, 0, 0);
    void Start () {
        bgSpawn.x = 39;
        bgSpawn.y = 4f;

        platformSpawnpoint.x = 39;
        platformSpawnpoint.y = -5.5f;

        Instantiate(backgrounds[Random.Range(0, 1)], bgSpawn, q);
        Instantiate(plat, platformSpawnpoint, Quaternion.identity);

        
	}
	
	
	void Update () {
        objSpawn.x = Random.Range(20.5f, 39.5f);


        spawnedBackgrounds = GameObject.FindGameObjectsWithTag("bg");
        spawnedPlatforms = GameObject.FindGameObjectsWithTag("platform");
        spawnedOjects = GameObject.FindGameObjectsWithTag("object");

        for (int i = 0; i<spawnedPlatforms.Length; i++)
        {
            spawnedPlatforms[i].transform.position -= new Vector3(5 * Time.deltaTime, 0, 0);

            if (spawnedPlatforms[i].transform.position.x <= -40)
            {
                
                
                Instantiate(backgrounds[Random.Range(0, 1)], bgSpawn, q);
                Instantiate(plat, platformSpawnpoint, Quaternion.identity);
                Instantiate(ojects[0], objSpawn, Quaternion.identity);
                Destroy(spawnedPlatforms[i]);
            }
        }
        for(int i = 0; i < spawnedOjects.Length; i++)
        {
            spawnedOjects[i].transform.position -= new Vector3(5 * Time.deltaTime, 0, 0);
        }
        for(int j = 0; j< spawnedBackgrounds.Length; j++)
        {
            spawnedBackgrounds[j].transform.position -= new Vector3(5 * Time.deltaTime, 0, 0);
        }
        
	}
}
