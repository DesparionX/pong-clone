using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    public float racketSpeed;

    public void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * racketSpeed;
    }
}
