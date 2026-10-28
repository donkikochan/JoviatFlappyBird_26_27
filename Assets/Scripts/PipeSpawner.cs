using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    
    public GameObject pipePrefab;
    public Transform spawnTop;
    public Transform spawnBottom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void Start()
    {
        InvokeRepeating("CreateNewPipe",3, 3);   
    }
    
    // Update is called once per frame
    void Update()
    {
        
            
        
    }

    void CreateNewPipe()
    {
        Instantiate(pipePrefab, Vector3.zero, Quaternion.identity);
    }
}
