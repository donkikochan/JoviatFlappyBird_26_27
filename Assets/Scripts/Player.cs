using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;
    public float force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = new Vector2(0, 1);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(dir * force);
        }
    }
}
