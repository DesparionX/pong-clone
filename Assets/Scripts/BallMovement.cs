using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxSpeed;

    int hitCounter = 0;

    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    void PositionBall(bool isLeft)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (isLeft)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }
    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.PositionBall(isStartingPlayer1);
        this.hitCounter = 0;
        yield return new WaitForSeconds(1);
        if (isStartingPlayer1)
            this.MoveBall(new Vector2(-1, 0));
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;

        var speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;
        Rigidbody2D rigidBody = this.gameObject.GetComponent<Rigidbody2D>();

        rigidBody.velocity = dir * speed;
    }
    public void IncreaseHitCounter()
    {
        if(this.hitCounter*this.extraSpeedPerHit <= this.maxSpeed)
        {
            this.hitCounter++;
        }
    }
}
