using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float LeftTarget,RightTarget;

    GameManager gameManager;

    private void Awake()
    {
        gameManager =Object.FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if(gameManager.gameOver)
        {
            return;
        }
        float h = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * Time.deltaTime * speed*h);

        if(transform.position.x < LeftTarget)
        {
           transform.position = new Vector2 (LeftTarget,transform.position.y);
        }
        if (transform.position.x > RightTarget)
        {
            transform.position = new Vector2(RightTarget, transform.position.y);
        }

    }
}
