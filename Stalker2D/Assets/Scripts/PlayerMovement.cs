using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float defaultSpeed;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    public float Speed => defaultSpeed;

    private void Awake()
    {
        spriteRenderer = this.GetComponentInChildren<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
    }



    public void Run(Vector2 direction)
    {
        if (direction.sqrMagnitude != 1)
        {
            direction = direction.normalized;
        }
        rb.velocity = direction * Speed;
        spriteRenderer.flipX = direction.x < 0;

    }
}
