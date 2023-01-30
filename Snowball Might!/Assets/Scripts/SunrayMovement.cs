using UnityEngine;

public class SunrayMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private int wallLayerMask;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveDirection = new Vector2(speed, speed);
        rb.velocity = moveDirection;
        wallLayerMask = LayerMask.GetMask("Wall");
    }

    void Update()
    {
        // Check for collision with the Wall layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, moveDirection, speed * Time.deltaTime, wallLayerMask);
        if (hit.collider != null)
        {
            moveDirection = new Vector2(-moveDirection.x, -moveDirection.y);
            rb.velocity = moveDirection;
        }
    }
}
