using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOneMovement : MonoBehaviour
{

    Rigidbody2D myPlayerOnePaddle;
    public float paddleSpeed = 5f;
    private int paddleDirection = 0;
    public float paddleXPosition;
    public float paddleYPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myPlayerOnePaddle = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Keyboard.current.upArrowKey.isPressed)
        {
            paddleDirection = 1;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            paddleDirection = -1;
        }
        else
        {
            paddleDirection = 0;
        }

        Vector2 paddleMovementVector = new Vector2(0f, paddleDirection * paddleSpeed);
        myPlayerOnePaddle.linearVelocity = paddleMovementVector;
        //transform.Translate(paddleMovementVector);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Playerone collided with: " + collision.gameObject.name);
    }
}
