using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    Rigidbody2D rb;
    Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
        transform.position = new Vector2(0.12f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(2f, 0.0f);
        if(transform.position.x >= 9.45)
        {
            transform.position = new Vector2(0.12f, 0f);
        }
    }
}
