using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brickdown : MonoBehaviour
{
    [SerializeField]
    private Sprite brokenImage;
    [SerializeField]
    private GameObject brickEffect;

    int count = 0;

    private void Start()
    {
        count = 0;

    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag=="Ball")
        {
            count++;



            if(count == 1)
            {
                GetComponent<SpriteRenderer>().sprite = brokenImage;
            }
            else if(count == 2)
            {
                FindObjectOfType<GameManager>().increaseScore();
                Instantiate(brickEffect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
