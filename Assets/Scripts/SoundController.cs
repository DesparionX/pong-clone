using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource racketSound;
    public AudioSource wallSound;
    public AudioSource goalSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Player1": case "Player2":
                    racketSound.Play();
                break;
            case "WallTop": case "WallBottom":
                wallSound.Play();
                break;
            case "WallLeft": case "WallRight":
                goalSound.Play();
                break;
            default:
                break;
        }
    }
}
