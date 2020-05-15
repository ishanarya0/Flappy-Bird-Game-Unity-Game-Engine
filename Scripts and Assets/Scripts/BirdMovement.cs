using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
public class BirdMovement : MonoBehaviour
{
    private Vector2 targetPos;
    public int life;
    public Text lifeDisplay;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + 1.5f);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, 10.5f);
        }
        else if (transform.position.y > -4.6f)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - 0.03f);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, 10.5f);
        }

        lifeDisplay.text = "Life: " + life.ToString();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pillar"))
        {
            life--;
           
            NewBehaviourScript.score = NewBehaviourScript.score - 1;
            if (life < 1)
            {
                NewBehaviourScript.score = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
           
        }

    }
}                