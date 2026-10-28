using System;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 pos = GetComponent<Transform>().position;
        pos.x -= speed;
        GetComponent<Transform>().position = pos;
    }
}
