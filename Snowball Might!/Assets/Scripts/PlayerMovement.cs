using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    [SerializeField] SpriteRenderer snowmanSpriteRenderer;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 lastMovement;
    public Vector2 LastMovement
    {
        get { return lastMovement; }
        set { lastMovement = value; }
    }
    
    private bool isMoving;
    public bool IsMoving
    {
        get { return isMoving; }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastMovement = new Vector2(0, 0);
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        movement = new Vector2(horizontal, vertical).normalized;
        if (movement != new Vector2(0, 0))
        {
            isMoving = true;
            lastMovement = movement;
        }
        else
        {
            isMoving = false;
        }

        FlipSprite();
    }

    private void FixedUpdate()
    {
        rb.velocity = movement * speed * Time.fixedDeltaTime;
    }

    private void FlipSprite()
    {
        if (lastMovement.x >= 0)
        {
            snowmanSpriteRenderer.flipX = false;
        }
        else
        {
            snowmanSpriteRenderer.flipX = true;
        }
    }
}
