using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Background : MonoBehaviour
{
    private Vector2 targetPos;
    
    void Update()
    {
        targetPos = new Vector2(transform.position.x - 0.01f, transform.position.y);
        transform.position = targetPos;

        if (transform.position.x < -49.6f)
        {
            targetPos = new Vector2(49.9f, transform.position.y);
            transform.position = targetPos;
        }
    }
}
