using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{
    public float speed = 1f;
    Vector2 velocity;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // transform.position += new Vector3(0f, speed, 0f);
        rb.MovePosition(rb.position + velocity);
    }

    public void MoveLeft()
    {
        Debug.Log("Move left");
        velocity = new Vector2(-speed, 0.1f);
    }

    public void MoveRight()
    {
        Debug.Log("Move right");
        velocity = new Vector2(speed, 0.1f);
    }
}
