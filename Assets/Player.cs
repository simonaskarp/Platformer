using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public bool onGround;
    public float moveSpeed = 4;
    public float jumpHeight = 2;
    public LayerMask layerMask = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var hit = Physics2D.Raycast(transform.position, Vector2.down, 0.6f, layerMask);
        onGround = hit.collider != null;


        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            var speed = Mathf.Sqrt(jumpHeight * -rb.gravityScale * Physics2D.gravity.y * 2);
            rb.velocity = Vector2.up * speed;
            onGround = false;
        }

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);
    }
}
