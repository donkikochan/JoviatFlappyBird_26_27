using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float timeToSpawn = 3;
    public GameObject pipePrefab;
    public Transform spawnTop;
    public Transform spawnBottom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void Start()
    {
        InvokeRepeating("CreateNewPipe",timeToSpawn, timeToSpawn);   
    }
    
    // Update is called once per frame
    void Update()
    {
        
            
        
    }

    void CreateNewPipe()
    {
        float randomY = Random.Range(spawnBottom.position.y, spawnTop.position.y);
        Vector3 newPos = new Vector3(spawnTop.position.x, randomY, spawnTop.position.z);
        Instantiate(pipePrefab, newPos, Quaternion.identity);
    }
}
