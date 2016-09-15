using UnityEngine;
using System.Collections;

public class endless : MonoBehaviour {
    public GameObject plat;
    public GameObject[] ojects;
    public GameObject[] spawnedOjects;
    public GameObject[] platforms;

   
    private Vector3 objSpawn;
    private Vector3 platformSpawnpoint;
    
	void Start () {
       
        
        platformSpawnpoint.x = 40;
        platformSpawnpoint.y = -5.5f;

        Instantiate(plat, platformSpawnpoint, Quaternion.identity);

        
	}
	
	
	void Update () {
        objSpawn.x = Random.Range(20.5f, 39.5f);

       

        platforms = GameObject.FindGameObjectsWithTag("platform");
        spawnedOjects = GameObject.FindGameObjectsWithTag("object");

        for (int i = 0; i<platforms.Length; i++)
        {
            platforms[i].transform.position -= new Vector3(5 * Time.deltaTime, 0, 0);
            if (platforms[i].transform.position.x <= -40)
            {
                Instantiate(plat, platformSpawnpoint, Quaternion.identity);
                Instantiate(ojects[0], objSpawn, Quaternion.identity);
                Destroy(platforms[i]);
            }
        }
        for(int j = 0; j < spawnedOjects.Length; j++)
        {
            spawnedOjects[j].transform.position -= new Vector3(5 * Time.deltaTime, 0, 0);
        }
	}
}
