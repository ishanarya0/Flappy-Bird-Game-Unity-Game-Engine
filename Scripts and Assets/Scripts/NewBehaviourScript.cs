using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    public static double score=0;
    public Text scoreDisplay;
    void Update() {
        scoreDisplay.text ="Score: "+score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        score += 0.5;
       
    }
}
