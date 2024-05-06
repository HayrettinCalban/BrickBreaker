using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScripts : MonoBehaviour
{
    [SerializeField]
    private GameObject brickEffect;

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ball")
        {
            FindObjectOfType<GameManager>().increaseScore();
            Instantiate(brickEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
