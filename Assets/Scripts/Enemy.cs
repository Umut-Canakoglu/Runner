using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector2 pointA;
    Vector2 pointB;
    Transform transform;
    bool goDown;
    public float Speed;

    void Start()
    {
        transform = GetComponent<Transform>();
        pointA = new Vector2(transform.position.x, 4);
        pointB = new Vector2(transform.position.x, -1);   
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 4)
        {
            goDown = true;
        }

        if(transform.position.y <= -1)
        {
            goDown = false;
        }

        if(goDown){
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
        } else{
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
        
        
    }
}
