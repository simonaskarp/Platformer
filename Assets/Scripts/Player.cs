using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sprite;
    BoxCollider2D boxColl;
    public bool onGround;
    public float moveSpeed = 4;
    public float jumpHeight = 2;
    public LayerMask layerMask = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        //var hit = Physics2D.Raycast(transform.position, Vector2.down, 0.6f, layerMask);
        var hit = Physics2D.BoxCast(boxColl.bounds.center, boxColl.bounds.size, 0f, Vector2.down, 0.1f, layerMask);
        onGround = hit.collider != null;


        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            var speed = Mathf.Sqrt(jumpHeight * -rb.gravityScale * Physics2D.gravity.y * 2);
            rb.velocity = Vector2.up * speed;
            onGround = false;
        }

        var h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(h * moveSpeed, rb.velocity.y);

        if (h != 0)
        {
            sprite.flipX = h < 0;
        }
    }
}
