using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _defaultSpeed;

    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;

    public float Speed => _defaultSpeed;

    private void Awake()
    {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
    }
    public void Run(Vector2 direction)
    {
        if (direction.sqrMagnitude != 1)
        {
            direction = direction.normalized;
        }
        _rb.velocity = direction * Speed;
        _spriteRenderer.flipX = direction.x < 0;

    }
}
