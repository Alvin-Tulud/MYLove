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
            if (Input.GetKey(KeyCode.A))
            {

            }
            if (Input.GetKey(KeyCode.D))
            {

            }
            if (Input.GetKey(KeyCode.W))
            {

            }
            if (Input.GetKey(KeyCode.S))
            {

            }
        }
    }
}
