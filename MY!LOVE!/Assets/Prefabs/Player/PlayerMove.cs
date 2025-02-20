using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;
    public bool canMove = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Vector2 move = new Vector2();

            if (Input.GetKey(KeyCode.A))
            {
                move += Vector2.left;
            }
            if (Input.GetKey(KeyCode.D))
            {
                move += Vector2.right;
            }
            if (Input.GetKey(KeyCode.W))
            {
                move += Vector2.up;
            }
            if (Input.GetKey(KeyCode.S))
            {
                move += Vector2.down;
            }

            move = move.normalized;

            rb.linearVelocity = move * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
