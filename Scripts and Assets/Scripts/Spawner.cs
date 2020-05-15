using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Spawner : MonoBehaviour
{
    public GameObject pillarUp;
    public GameObject pillarDown;
    private float timeBtwSpwn;
    public float startTimeBtwSpawn;
    private Vector2 upPos;
    private Vector2 downPos;
    private double rUp=0, rDown=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if (timeBtwSpwn<=0)
        {
            rUp = 0;
            rDown = 0;
            while ((rUp - rDown) < 9.72)
            {
                System.Random r = new System.Random();
                rUp = r.NextDouble()*(7.42-1.52) + 1.52;
                rDown = r.NextDouble()*(-1.46+7.64)-7.64;
            }
            Debug.Log(rUp + " " + rDown);
            upPos = new Vector2(transform.position.x, (float)(rUp));
            downPos = new Vector2(transform.position.x, (float)(rDown));
            Instantiate(pillarUp, upPos, Quaternion.identity);
            Instantiate(pillarDown,downPos , Quaternion.identity);

            timeBtwSpwn = startTimeBtwSpawn;
            
        }
        else
        {
            timeBtwSpwn -= Time.deltaTime;
        }
       

    }
}
