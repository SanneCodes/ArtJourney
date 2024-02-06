using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private bool isGrounded = true;
    public bool check = false;

    private Rigidbody2D rb2D;

    public float x;
    public float y;
    

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 velocity = rb2D.velocity;

        // Adjust velocity based on input
        velocity.x = horizontalInput * speed;

        // Apply the adjusted velocity
        rb2D.velocity = velocity;

        if (isGrounded && Input.GetButton("Jump"))
        {
            Jump2D();
            Debug.Log("Jump button clicked");
        }
    }


    void Jump2D()
    {
        rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}


