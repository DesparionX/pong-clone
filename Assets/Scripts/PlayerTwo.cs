using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    public GameObject ball;
    public float racketSpeed;
    public bool isAIEnabled = false;

    public void FixedUpdate()
    {

        isAIEnabled = Convert.ToBoolean(PlayerPrefs.GetInt("isAIEnabled"));
        if(!isAIEnabled)
        {
            float v = Input.GetAxisRaw("Vertical2");
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * racketSpeed;
        }
        else
        {
            if (Mathf.Abs(transform.position.y - ball.transform.position.y) > 1)
            {
                if (transform.position.y < ball.transform.position.y)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * racketSpeed;
                }
                else
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * racketSpeed;
                }
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
        }
    }
}
