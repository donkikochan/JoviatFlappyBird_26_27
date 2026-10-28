using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    
    public GameObject pipePrefab;
    public Transform spawnTop;
    public Transform spawnBottom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(pipePrefab, Vector3.zero, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
