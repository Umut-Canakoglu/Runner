using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    void Update()
    {
        Vector2 direction =  Vector2.right;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 100f);
        if(Input.GetKeyDown(KeyCode.Space)){
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
            }
        }
        
    }
}
