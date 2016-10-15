using UnityEngine;
using System.Collections;


public class spawner : MonoBehaviour {
    public GameObject plat;
    public GameObject[] ojects;
    public GameObject[] backgrounds;
    public GameObject[] enemies;

    private GameObject[] spawnedBackgrounds;
    private GameObject[] spawnedPlatforms;
    private GameObject[] spawnedOjects;
    private GameObject[] spawnedEnemies;
 
    private float _spawnTime = 0;
    private float _waightTime = 6;

    private Quaternion q = Quaternion.Euler(-90, 0, 0);

	void Update ()
    {
        if(Time.time > _spawnTime)
        {
            _spawnTime = Time.time + _waightTime;
            
            Instantiate(backgrounds[Random.Range(0, backgrounds.Length)], BackGroundSpawnPosition(), q);
            Instantiate(plat, PlatformSpawnPosition(), Quaternion.identity);

            for (int i = 0; i < Random.Range(3,8); i++)
            {
                Instantiate(ojects[Random.Range(0, ojects.Length)], ObjectSpawnPosition(), Quaternion.identity);
            }

            for (int i = 0; i < Random.Range(2,4); i++)
            {
                Instantiate(enemies[0], EnemySpawnPosition(), Quaternion.identity);
            }   
        }  
	}
    Vector3 EnemySpawnPosition()
    {
        spawnedEnemies = GameObject.FindGameObjectsWithTag("enemy");
            
        float min =20;
        float max = 30;
        float lastspawned;
        Vector3 enp = new Vector3(Random.Range(min, max), 5, -0.5f);
        if (spawnedEnemies.Length > 0)
        {
            lastspawned = spawnedEnemies[spawnedEnemies.Length - 1].transform.position.x;
            if(lastspawned > 20)
            {
                min =lastspawned + 2;
            }
            else
            {
                min = 20;
            }
            
            max = min + 10;
            if(max > 60)
            {
                max = 60;
            }
            enp =new Vector3 (Random.Range(min,max),5,-0.5f);
        }
        
        return enp;
    }
    Vector3 PlatformSpawnPosition()
    {
        spawnedPlatforms = GameObject.FindGameObjectsWithTag("platform");
       
        Vector3 plp = spawnedPlatforms[spawnedPlatforms.Length - 1].transform.position ;
        plp = plp + new Vector3(40, 0, 0);
        return plp;
    }
    Vector3 BackGroundSpawnPosition()
    {
        spawnedBackgrounds = GameObject.FindGameObjectsWithTag("bg");
       
        Vector3 bgp = spawnedBackgrounds[spawnedBackgrounds.Length - 1].transform.position;
        bgp = bgp + new Vector3(40, 0, 0);
        return bgp;
    }
    Vector3 ObjectSpawnPosition()
    {
        spawnedPlatforms = GameObject.FindGameObjectsWithTag("platform");
        spawnedOjects = GameObject.FindGameObjectsWithTag("object");

        Vector3 obp = spawnedPlatforms[spawnedPlatforms.Length - 1].transform.position;

        float min = -20;
        float max = -10;

        float lastPlatform = spawnedPlatforms[spawnedPlatforms.Length - 1].transform.position.x;
        float lastObject = spawnedOjects[spawnedOjects.Length - 1].transform.position.x;
       
        if (lastPlatform - 20 < lastObject)
        {
            min = lastObject - lastPlatform + 3;
            max = min + 10;
          
        }
        
        obp = obp + new Vector3(Random.Range(min, max), 5.5f, 0);
        return obp;
    }

}
