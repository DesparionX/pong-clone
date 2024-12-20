using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoAI : MonoBehaviour
{
    public float movementSpeed;
    public GameObject ball;

    private void FixedUpdate()
    {
        if(Mathf.Abs(transform.position.y - ball.transform.position.y) > 1)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movementSpeed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
