using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public int damage = 1;
    public float speed;


    private void Update()
    {
     transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

   

}
