using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScripts : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    float speed = 500f;
    [SerializeField]
    bool inPlay;

    [SerializeField]
    Transform ballStartPos;

    GameManager gameManager;


    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(gameManager.gameOver)
        {
            return;
        }

        if (!inPlay)
        {
            transform.position = ballStartPos.position;
        }
        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.up * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "bottom")
            FindObjectOfType<GameManager>().decreaseLive();
            rb.velocity = Vector2.zero;
        inPlay= false;
    }



}
