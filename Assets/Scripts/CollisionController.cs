using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;
    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHigh = c.collider.bounds.size.y;

        float x;
        if(c.gameObject.name == "Player1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y = (ballPosition.y - racketPosition.y) / racketHigh;
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Player1":
                this.BounceFromRacket(collision);
                break;
            case "Player2":
                this.BounceFromRacket(collision);
                break;
            case "WallLeft":
                this.scoreController.GoalPTwo();
                StartCoroutine(this.ballMovement.StartBall(false));
                break;
            case "WallRight":
                this.scoreController.GoalPOne();
                StartCoroutine(this.ballMovement.StartBall(true));
                break;
            default:
                break;
        }
    }

}
